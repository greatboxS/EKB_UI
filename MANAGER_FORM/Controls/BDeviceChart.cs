using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SYS_MODELS;
using EKANBAN_SYS_LIB;
using System.Windows.Media;
using ZedGraph;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Forms.DataVisualization.Charting;
using HitTestResult = System.Windows.Forms.DataVisualization.Charting.HitTestResult;
using MANAGER_FORM.Pages;

namespace MANAGER_FORM.Controls
{
    public partial class BDeviceChart : UserControl
    {
        ZedGraphControl ZedGraphControl = new ZedGraphControl();
        MachineTimeLine MachineTimeLineForm;
        private BeamCutDevice Device = new BeamCutDevice();

        public BDeviceChart()
        {
            InitializeComponent();
        }

        BeamCutQuery BeamCutQuery = new BeamCutQuery(_SERVER.ServerName.Database);

        public BDeviceChart(DateTime start, DateTime stop, BeamCutDevice device)
        {
            InitializeComponent();
            Device = device;
            MachineTimeLineForm = new MachineTimeLine();

            ZedGraphControl.GraphPane.Title.Text = $"Device: {Device.Name}";
            ZedGraphControl.MouseDoubleClick += ZedGraphControl_MouseDoubleClick;
            ZedGraphControl.IsShowPointValues = true;

            ZedGraphControl.GraphPane.XAxis.Title.Text = "Date";
            ZedGraphControl.GraphPane.YAxis.Title.Text = "Cut quantity (ps), Cut times (t)";

            var RecordList = BeamCutQuery.GetBDeviceStatistic(start, stop, device);
            if (RecordList == null)
                return;

            var pane = ZedGraphControl.GraphPane;

            pane.XAxis.MajorGrid.DashOn = 2.0F;
            pane.XAxis.MajorGrid.Color = System.Drawing.Color.LightGray;
            pane.YAxis.MajorGrid.DashOn = 2.0F;
            pane.YAxis.MajorGrid.Color = System.Drawing.Color.LightGray;

            pane.XAxis.Scale.IsVisible = true;
            pane.YAxis.Scale.IsVisible = true;

            pane.XAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.IsVisible = true;


            //var pointsCurve;
            pane.XAxis.Scale.TextLabels = RecordList.Select(i => i.Date).ToArray();
            pane.XAxis.Type = ZedGraph.AxisType.Text;

            LineItem CutQuantity = pane.AddCurve("Quantity", null, RecordList.Select(i => (double)i.TotalCutQty).ToArray(), System.Drawing.Color.DarkRed);
            LineItem CutTimes = pane.AddCurve("Cut Times", null, RecordList.Select(i => (double)i.TotalCuttime).ToArray(), System.Drawing.Color.Blue);

            CutQuantity.Line.IsVisible = true;
            CutQuantity.Line.Width = 1.0F;
            //Create your own scale of colors.

            CutQuantity.Symbol.Fill = new Fill(new System.Drawing.Color[] { System.Drawing.Color.Blue, System.Drawing.Color.Green, System.Drawing.Color.Red });
            CutQuantity.Symbol.Fill.Type = FillType.Solid;
            CutQuantity.Symbol.Type = SymbolType.Circle;
            CutQuantity.Symbol.Border.IsVisible = true;

            CutTimes.Line.IsVisible = true;
            CutTimes.Line.Width = 1.0F;
            CutTimes.Symbol.Fill = new Fill(new System.Drawing.Color[] { System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black });
            CutTimes.Symbol.Fill.Type = FillType.Solid;
            CutTimes.Symbol.Type = SymbolType.Diamond;
            CutTimes.Symbol.Border.IsVisible = true;

            for (int i = 0; i < CutQuantity.Points.Count; i++)
            {
                var pt = CutQuantity.Points[i];
                string date = ZedGraphControl.GraphPane.XAxis.Scale.TextLabels[i];

                TextObj text1 = new TextObj(
                    $"{pt.Y}", pt.X, pt.Y + 0.1,
                    CoordType.AxisXYScale, AlignH.Left, AlignV.Top);
                text1.ZOrder = ZOrder.A_InFront;
                text1.FontSpec.Angle = 0;

                pane.GraphObjList.Add(text1);

                pt = CutTimes.Points[i];
                TextObj text2 = new TextObj(
                    $"{pt.Y}", pt.X, pt.Y + 0.1,
                    CoordType.AxisXYScale, AlignH.Left, AlignV.Center);
                text2.ZOrder = ZOrder.A_InFront;
                text2.FontSpec.Angle = 0;
                pane.GraphObjList.Add(text2);
            }

            pane.AxisChange();
            ZedGraphControl.Refresh();
            this.Controls.Add(ZedGraphControl);
            ZedGraphControl.Dock = DockStyle.Fill;
            ZedGraphControl.BringToFront();
        }

        private void ZedGraphControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                CurveItem n_curve;
                int index;
                ZedGraphControl.GraphPane.FindNearestPoint(e.Location, out n_curve, out index);
                if (n_curve != null)
                {
                    string date = ZedGraphControl.GraphPane.XAxis.Scale.TextLabels[index];
                    int totalCutQty = (int)ZedGraphControl.GraphPane.CurveList[0].Points[index].Y;
                    int totalCutTime = (int)ZedGraphControl.GraphPane.CurveList[1].Points[index].Y;

                    DateTime Date;
                    DateTime.TryParseExact(date, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None,out Date);

                    MachineTimeLineForm = new MachineTimeLine(Device, Date, totalCutQty, totalCutTime);
                    MachineTimeLineForm.Show();
                    MachineTimeLineForm.BringToFront();
                }
            }
            catch { }
        }
    }
}

