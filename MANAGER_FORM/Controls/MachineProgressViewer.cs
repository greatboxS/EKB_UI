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

namespace MANAGER_FORM.Controls
{
    public partial class MachineProgressViewer : UserControl
    {
        public MachineProgressViewer()
        {
            InitializeComponent();
        }

        private BeamCutDevice bdevice;
        BeamCutQuery BeamCutQuery;
        OrderDetail OrderDetail;
        public MachineProgressViewer(BeamCutDevice bmachine)
        {
            try
            {
                InitializeComponent();
                bdevice = new BeamCutDevice();
                bdevice = bmachine;
                BeamCutQuery = new BeamCutQuery(_SERVER.ServerName.Database);

                var orders = BeamCutQuery.GetAllBDeviceOrders(bmachine.id);
                OrderTab.Controls.Clear();
                OrderDetail = new OrderDetail(orders);
                OrderTab.Controls.Add(OrderDetail);
                OrderDetail.Dock = DockStyle.Fill;

                if (startTime.Value.DayOfYear > stopTime.Value.DayOfYear)
                    return;

                UpdateProgress();
            }
            catch { }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void UpdateProgress()
        {
            if ((startTime.Value - stopTime.Value).TotalDays > 0.1)
                return;

            var BInterfaces = BeamCutQuery.GetBeamCutInterfaces(bdevice.id, startTime.Value, stopTime.Value);

            if (BInterfaces == null)
                return;

            MachineProgressLoader.Controls.Clear();

            int row = 0;
            int place = 1;
            foreach (var item in BInterfaces)
            {
                BeamInterface beamInterface = new BeamInterface(item, place);
               
                if (!beamInterface.Error)
                {
                    MachineProgressLoader.Controls.Add(beamInterface, 0, row);
                    place++;
                    row++;
                }
            }
        }

        public void UpdateOrderViewer(ICollection<BDeviceOrder> orders)
        {
            OrderTab.Controls.Clear();
            OrderDetail = new OrderDetail(orders);
            OrderTab.Controls.Add(OrderDetail);
            OrderDetail.Dock = DockStyle.Fill;
            
        }

        public void UpdateOrderDetail(Schedule schedule)
        {
            OrderDetail.UpdateOrderDetail(schedule);
            TabControl.SelectedIndex = 1;
        }
    }
}
