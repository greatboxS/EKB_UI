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
using BEAMCUT_TASK;
using MANAGER_FORM.Controls;

namespace MANAGER_FORM.Pages
{

    public partial class OrderPage : UserControl
    {

        BeamCutQuery BeamCutQuery = new BeamCutQuery(_SERVER.ServerName.Database);
        ScheduleQuery ScheduleQuery = new ScheduleQuery(_SERVER.ServerName.Database);
        BuildingQuery BuildingQuery = new BuildingQuery(_SERVER.ServerName.Database);
        BeamCutContext BeamCutContext;
        SequenceQuery SequenceQuery = new SequenceQuery(_SERVER.ServerName.Database);
        MachineProgressViewer MachineProgressViewer;

        public int TotalCutQty { get; set; }
        public OrderPage()
        {
            InitializeComponent();
        }

        private AppUser CurrentUser;
        public OrderPage(AppUser user)
        {
            InitializeComponent();
            CurrentUser = user;
        }

        private void OrderPage_Load(object sender, EventArgs e)
        {
            try
            {
                DS_Building.DataSource = BuildingQuery.GetBuildings();
                DS_ScheduleClass.DataSource = ScheduleQuery.GetScheduleClasses();
                cbxBuilding.SelectedIndex = 1;
                cbxBuilding.SelectedIndex = 0;
                cbxScheduleClass.SelectedIndex = cbxScheduleClass.Items.Count - 1;
                cbxLine.SelectedIndex = 1;
                cbxLine.SelectedIndex = 0;
                lbBDevice.SelectedIndex = 1;
                lbBDevice.SelectedIndex = 0;
            }
            catch { }
        }

        private void cbxBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxBuilding.SelectedItem == null)
                return;

            var building = BuildingQuery.GetBuilding((cbxBuilding.SelectedItem as Building).id);

            if (building == null)
                return;

            if (building.ProductionLines != null)
                DS_Line.DataSource = building.ProductionLines;

            DS_BDevice.DataSource = BeamCutQuery.GetBeamCutDevices(building.id);
        }

        private void cbxLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLine.SelectedItem == null)
                return;

            var schedules = ScheduleQuery.GetSchedules(cbxLine.SelectedItem as ProductionLine);

            var scheduleClass = DS_ScheduleClass.Current as ScheduleClass;

            var temp = schedules.Where(i => i.ScheduleClass_Id == scheduleClass.id);
            if (temp.Count() > 0)
                schedules = temp.ToList();

            if (schedules != null)
                DS_Schedule.DataSource = schedules;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            
            try
            {
                var currentSchedule = DS_Schedule.Current as Schedule;
                var currentDevice = DS_BDevice.Current as BeamCutDevice;
                var currentLine = DS_Line.Current as ProductionLine;

                if(MessageBox.Show($"Do you really want to add PO: {currentSchedule.PoNumber} to device: {currentDevice.Name}",
                    "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)!= DialogResult.Yes)
                    return;

                BDeviceOrder BDeviceOrder = new BDeviceOrder
                {
                    AddPeople_Id = CurrentUser.id,
                    BeamCutDevice_Id = currentDevice.id,
                    PoNumber = currentSchedule.PoNumber,
                    PoQty = currentSchedule.Quantity,
                    ProductionLine_Id = currentLine.id,
                    Schedule_Id = currentSchedule.id,
                    OrderDate = DateTime.Now,
                };

                var orders = BeamCutQuery.AddNewOrder(BDeviceOrder);
                if (orders != null)
                {
                    MachineProgressViewer.UpdateOrderViewer(orders);
                }
            }
            catch (Exception ex)
            { }
        }

        private void lbBDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbxOrderDate.Items.Clear();

                var device = DS_BDevice.Current as BeamCutDevice;

                if (device != null)
                {
                    device = BeamCutQuery.GetDeviceOrders(device.id);
                    var orderGroup = device.BDeviceOrders.GroupBy(i => i.Date);
                    foreach (var item in orderGroup)
                    {
                        cbxOrderDate.Items.Add(item.Key);
                    }
                }

                MachineProgressViewer = new MachineProgressViewer(device);
                if (!OrderLoader.IsDisposed)
                    OrderLoader.Controls.Clear();
                OrderLoader.Controls.Add(MachineProgressViewer);
                MachineProgressViewer.Dock = DockStyle.Fill;

                var orders = BeamCutQuery.GetBDeviceOrders(device.id, cbxOrderDate.Text);

                if (orders != null)
                {
                    MachineProgressViewer.UpdateOrderViewer(orders);
                }
            }
            catch (Exception ex)
            { }
        }

        private void cbxOrderDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var device = DS_BDevice.Current as BeamCutDevice;

                var orders = BeamCutQuery.GetBDeviceOrders(device.id, cbxOrderDate.Text);

                if (orders != null)
                {
                    MachineProgressViewer.UpdateOrderViewer(orders);
                }
            }
            catch { }
        }

        private void lbSchedule_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateSchedule();
        }

        void UpdateSchedule()
        {
            try
            {
                var currentSchedule = DS_Schedule.Current as Schedule;

                ComponentQuery componentQuery = new ComponentQuery(_SERVER.ServerName.Database);
                var component = componentQuery.GetShoeComponents(currentSchedule.Model, currentSchedule.ModelName);
                var order = BeamCutQuery.GetBDeviceOrder(currentSchedule);

                MachineProgressViewer.UpdateOrderDetail(currentSchedule);

                BeginInvoke(new MethodInvoker(() =>
                {
                    lvComponent.Items.Clear();
                    if (component == null) return;
                    var names = component.Select(i => i.Reference).ToArray();
                    foreach (string name in names)
                    {
                        lvComponent.Items.Add(name);
                    }
                }));
            }
            catch { }
        }
        private void lbSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSchedule();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var schedules = ScheduleQuery.GetSchedules(textBox1.Text);
                if (schedules != null)
                    DS_Schedule.DataSource = schedules;
            }
            catch { }
        }
    }
}
