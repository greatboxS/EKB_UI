using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SYS_MODELS;
using EKANBAN_SYS_LIB;
using ZedGraph;

namespace MANAGER_FORM.Pages
{
    public partial class MachineTimeLine : Form
    {
        public MachineTimeLine()
        {
            InitializeComponent();
        }

        BeamCutQuery BeamCutQuery = new BeamCutQuery(_SERVER.ServerName.Database);
        private BeamCutDevice BDevice = new BeamCutDevice();
        private DateTime ViewDate;
        Timer Timer = new Timer { Enabled = true, Interval = 60*1000*2 };

        void UpdateCurrentDateStatistic(BeamCutDevice device, DateTime date, int totalCutQty, int totalCutTime)
        {
            lbDate.Text = $"Date: {date.ToString("dd/MM/yyyy")}";
            lbTotalCut.Text = totalCutQty.ToString();
            lbTotalCutTime.Text = totalCutTime.ToString();

            var timeLine = BeamCutQuery.GetBeamCutDeviceTimeLineRecorde(device.id, date);

            ZedGraphControl ZedGraphControl = new ZedGraphControl();

            ZedGraphControl.IsShowPointValues = true;

            ZedGraphControl.GraphPane.XAxis.Title.Text = "Date";
            ZedGraphControl.GraphPane.YAxis.Title.Text = "Confirm (ps), Cut times (t)";

            var pane = ZedGraphControl.GraphPane;

            pane.XAxis.MajorGrid.DashOn = 2.0F;
            pane.XAxis.MajorGrid.Color = Color.LightGray;
            pane.YAxis.MajorGrid.DashOn = 2.0F;
            pane.YAxis.MajorGrid.Color = Color.LightGray;

            pane.XAxis.Scale.IsVisible = true;
            pane.YAxis.Scale.IsVisible = true;

            pane.XAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.IsVisible = true;


            //var pointsCurve;
            pane.XAxis.Scale.TextLabels = timeLine.Select(i => i.Date).ToArray();
            pane.XAxis.Type = ZedGraph.AxisType.Text;

            List<double> pointVal1 = new List<double>();
            List<double> pointVal2 = new List<double>();

            int index = 0;
            foreach (var item in timeLine)
            {
                pointVal1.Add(0);
                pointVal2.Add(0);

                if (item.ConfirmQuantity != null)
                    pointVal1[index] = (double)item.ConfirmQuantity;

                if (item.TotalCutTime != null)
                    pointVal2[index] = (double)item.TotalCutTime;

                index++;
            }

            LineItem ConfirmQty = pane.AddCurve("Confirm Quantity", null, pointVal1.ToArray(), Color.DarkRed, SymbolType.VDash);
            LineItem CutTimes = pane.AddCurve("Cut Times", null, pointVal2.ToArray(), Color.Blue, SymbolType.Plus);

            ConfirmQty.Line.IsVisible = true;
            ConfirmQty.Line.Width = 1.0F;
            //Create your own scale of colors.

            ConfirmQty.Symbol.Fill = new Fill(new System.Drawing.Color[] { Color.DarkRed, Color.DarkRed, Color.DarkRed });
            ConfirmQty.Symbol.Fill.Type = FillType.Solid;
            ConfirmQty.Symbol.Type = SymbolType.Circle;
            ConfirmQty.Symbol.Border.IsVisible = true;

            CutTimes.Line.IsVisible = true;
            CutTimes.Line.Width = 1.0F;
            CutTimes.Symbol.Fill = new Fill(new Color[] { Color.Blue, Color.Blue, Color.Blue });
            CutTimes.Symbol.Fill.Type = FillType.Solid;
            CutTimes.Symbol.Type = SymbolType.Diamond;
            CutTimes.Symbol.Border.IsVisible = true;

            pane.AxisChange();
            ZedGraphControl.Refresh();
            panel2.Controls.Clear();
            this.panel2.Controls.Add(ZedGraphControl);
            ZedGraphControl.Dock = DockStyle.Fill;
            ZedGraphControl.BringToFront();
        }

        public MachineTimeLine(BeamCutDevice device, DateTime date, int totalCutQty, int totalCutTime)
        {
            InitializeComponent();
            ViewDate = date;
            BDevice = device;
            Timer.Tick += Timer_Tick;
            Timer.Start();
            var Record = BeamCutQuery.GetBMachineStatistic(BDevice.id, ViewDate);
            lbBegin.Text = ((DateTime)Record.StartTime).ToString("hh:mm:ss tt");
            lbLastUpdate.Text = ((DateTime)Record.StopTime).ToString("hh:mm:ss tt");
            UpdateCurrentDateStatistic(device, date, totalCutQty, totalCutTime);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer.Stop();
            try
            {
                if (ViewDate.DayOfYear == DateTime.Now.DayOfYear)
                {
                    var Record = BeamCutQuery.GetBMachineStatistic(BDevice.id, ViewDate);
                    lbBegin.Text = ((DateTime)Record.StartTime).ToString("hh:mm:ss tt");
                    lbLastUpdate.Text = ((DateTime)Record.StopTime).ToString("hh:mm:ss tt");
                    UpdateCurrentDateStatistic(BDevice, ViewDate, (int)Record.TotalCutQty, (int)Record.TotalCuttime);
                }
            }
            catch { }

            Timer.Start();
        }
    }
}
