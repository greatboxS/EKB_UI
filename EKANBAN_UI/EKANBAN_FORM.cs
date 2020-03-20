using BUILDING;
using SCHEDULE;
using COMPONENT;
using SEQUENCE;
using EKANBAN_HIS;
using BEAMCUT_TASK;
using EKANBAN_TASK;
using SYS_MODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EKANBAN_SYS_LIB;
using EMPLOYEE;

namespace EKANBAN_UI
{
    public partial class EKANBAN_FORM : Form
    {
        static IDbName database = new FakeDb();
        public bool ViewAllCart { get; set; }
        public bool ModelNameFilter { get; set; }

        BuildingQuery BuildingQuery = new BuildingQuery(database);
        ScheduleQuery ScheduleQuery = new ScheduleQuery(database);
        EKanbanTaskQuery EKanbanTaskQuery = new EKanbanTaskQuery(database);
        SysHistoryQuery SysHistoryQuery = new SysHistoryQuery(database);
        SequenceQuery SequenceQuery = new SequenceQuery(database);
        EmployeeQuery EmployeeQuery = new EmployeeQuery(database);


        //
        private ProductionLine SelectedProductionLine = new ProductionLine();
        private Building SelectedBuilding = new Building();
        private EKanbanDevice SelectedDevice = new EKanbanDevice();
        private ICollection<EKanbanDevice> eKanbanDevices = new List<EKanbanDevice>();
        private ICollection<Schedule> Schedules = new List<Schedule>();
        private Schedule SelectedSchedule = new Schedule();
        private string SelectedScheduleLine { get; set; }
        private ScheduleClass SelectedScheduleClass = new ScheduleClass();

        public EKANBAN_FORM()
        {
            InitializeComponent();
            Checkbox_ViewAllCart.DataBindings.Add(new Binding("Checked", this, "ViewAllCart", false, DataSourceUpdateMode.OnPropertyChanged));
            chbx_modelFilter.DataBindings.Add(new Binding("Checked", this, "ModelNameFilter", false, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DS_Building.DataSource = BuildingQuery.GetBuildings();
            SelectBuildingChanges();

            cbx_ScheduleTime.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cbx_ScheduleTime.Items.Add($"{i.ToString("00")}/{DateTime.Now.Year}");
            }
            cbx_ScheduleTime.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void SelectBuildingChanges()
        {
            if (cbx_Building.SelectedItem == null)
                return;

            SelectedBuilding = cbx_Building.SelectedItem as Building;

            DS_ProductionLine.DataSource = SelectedBuilding.ProductionLines;
            SelectProductionLineChanges();
        }

        private void cbx_Building_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectBuildingChanges();
        }

        private void UpdateEKanbanDevices()
        {
            eKanbanDevices = EKanbanTaskQuery.GetEKanbanDevicesByBuilding(SelectedBuilding.id);

            if (ViewAllCart)
            {
                DS_EKanbanDevice.DataSource = eKanbanDevices;
            }
            else
            {
                DS_EKanbanDevice.DataSource = EKanbanTaskQuery.GetEKanbanDevicesByProductionLine(SelectedProductionLine.id);
            }
        }

        private void SelectProductionLineChanges()
        {
            if (lb_ProductionLine.SelectedItem == null)
                return;

            SelectedProductionLine = lb_ProductionLine.SelectedItem as ProductionLine;
            UpdateEKanbanDevices();
        }
        private void lb_ProductionLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectProductionLineChanges();
        }

        private void Checkbox_ViewAllCart_CheckStateChanged(object sender, EventArgs e)
        {
            UpdateEKanbanDevices();
        }

        private void lbEKanbanDevice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateSchedules()
        {
            Schedules = ScheduleQuery.GetSchedules(SelectedScheduleClass);
            if (SelectedProductionLine == null)
            {
                MessageBox.Show("An error occurred during execution", "Error");
                return;
            }
            try
            {
                DS_Schedule.DataSource = Schedules = Schedules
                    .Where(i => i.ProductionLine_Id == SelectedProductionLine.id)
                    .ToList();
            }
            catch
            {
                DS_Schedule.DataSource = new List<Schedule>();
            }

            GetModelFilter();
            UpdateScheduleGroupByModelName();
        }

        private void cbx_ScheduleTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            string className = GetScheduleClassName(cbx_ScheduleTime.Text);
            SelectedScheduleClass = ScheduleQuery.GetScheduleClass(className);

            UpdateSchedules();
        }

        private string GetScheduleClassName(string _string)
        {
            try
            {
                string[] ClassNameArr = _string.Split(new string[] { "/" }, StringSplitOptions.None);
                string className = $"{ClassNameArr[1]}{ClassNameArr[0]}";
                return className;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Get Schedule class name failed");
                return null;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            UpdateSchedules();
        }

        private void GetSelectedSchedule()
        {
            if (lbSchedule.SelectedItem == null)
                return;

            SelectedSchedule = lbSchedule.SelectedItem as Schedule;
            SelectedProductionLine = BuildingQuery.GetProductionLine(ShareFuncs.GetInt(SelectedSchedule.ProductionLine_Id));
            txtProductionLine.Text = SelectedProductionLine.LineName;

            UpdateOgiginalSequence();
        }

        private void UpdateModelComponent()
        {

        }
        private void lbSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSelectedSchedule();
        }

        private void UpdateOgiginalSequence()
        {
            try
            {
                DS_Sequence.DataSource = SequenceQuery.GetOriginalSequence(SelectedSchedule);
            }
            catch { }
        }

        private void GetModelFilter()
        {
            cbxModelName.DataSource = null;
            List<string> ModelName = new List<string>();
            if (Schedules == null)
                return;

            if (ModelNameFilter)
            {

                var group = Schedules.GroupBy(i => i.ModelName);

                foreach (var item in group)
                {
                    ModelName.Add(item.Key);
                }

                cbxModelName.DataSource = ModelName;
            }
            else
                DS_Schedule.DataSource = Schedules;
        }

        private void chbx_modelFilter_CheckStateChanged(object sender, EventArgs e)
        {
            GetModelFilter();
        }

        private void UpdateScheduleGroupByModelName()
        {
            if (Schedules == null)
                return;

            foreach (var item in Schedules.GroupBy(i => i.ModelName))
            {
                if (item.Key == cbxModelName.Text)
                {
                    DS_Schedule.DataSource = item.ToList();
                }
            }
        }

        private void cbxModelName_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateScheduleGroupByModelName();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EXCEL_TO_DATABASE.UPDATE_FORM uPDATE_FORM = new EXCEL_TO_DATABASE.UPDATE_FORM();
            uPDATE_FORM.ShowDialog();
        }

        private void btnSequence_Click(object sender, EventArgs e)
        {
            if (SelectedSchedule.id == 0)
                return;

            VIEW_SEQUENCE_FORM.SEQUENCE_FORM sEQUENCE_FORM = new VIEW_SEQUENCE_FORM.SEQUENCE_FORM(SelectedSchedule);

            sEQUENCE_FORM.Show();
            sEQUENCE_FORM.BringToFront();
        }
    }
}
