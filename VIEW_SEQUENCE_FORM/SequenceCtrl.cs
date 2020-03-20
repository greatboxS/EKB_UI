using EKANBAN_SYS_LIB;
using SYS_MODELS;
using System;
using System.Windows.Forms;

namespace VIEW_SEQUENCE_FORM
{
    public partial class SequenceCtrl : UserControl
    {
        private OriginalPO OriginalPo;
        private Schedule Schedule;
        private bool header = false;

        SequenceQuery SequenceQuery = new SequenceQuery(_SERVER.ServerName.Database);
        ScheduleQuery ScheduleQuery = new ScheduleQuery(_SERVER.ServerName.Database);
        BuildingQuery BuildingQuery = new BuildingQuery(_SERVER.ServerName.Database);

        public SequenceCtrl()
        {
            InitializeComponent();
            OriginalPo = new OriginalPO();
        }

        public SequenceCtrl(Schedule _schedule, bool _displayHeader)
        {
            InitializeComponent();
            header = _displayHeader;
            Schedule = new Schedule();

            if (Schedule != null)
            {
                Schedule = ScheduleQuery.GetSchedule(_schedule.id);
                ds_schedule.DataSource = Schedule;
                var ProductionLine = BuildingQuery.GetProductionLine(ShareFuncs.GetInt(Schedule.ProductionLine_Id));
                txProductionLine.Text = ProductionLine.LineName;
                txtUpdateTime.Text = Schedule.ScheduleClass.LastModified.ToString("hh::mm: tt, dd/MM/yyyy");
            }

            OriginalPo = new OriginalPO();
            Draw();
        }

        private void Draw()
        {
            try
            {
                OriginalPo = SequenceQuery.GetOriginalPo(Schedule);

                LoaderPanel.Controls.Clear();
                SizeCtrl Sviewer = new SizeCtrl(null, true);
                LoaderPanel.Controls.Add(Sviewer);

                foreach (var s in OriginalPo.OriginalPOsequences)
                {
                    Sviewer = new SizeCtrl(s, false);
                    LoaderPanel.Controls.Add(Sviewer);
                }
            }
            catch { }

            int hedaderHeigth = 100;
            if (!header)
                hedaderHeigth = 0;

            if (OriginalPo.OriginalPOsequences != null)
                this.Height = OriginalPo.OriginalPOsequences.Count * 23 + hedaderHeigth;

            this.Width = 1000;
        }

        private void SequenceCtrl_Load(object sender, EventArgs e)
        {
            if (!header)
                HeaderPanel.Hide();
        }
    }
}