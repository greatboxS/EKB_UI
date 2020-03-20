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
    public partial class OrderDetail : UserControl
    {
        public OrderDetail()
        {
            InitializeComponent();
        }

        BeamCutQuery BeamCutQuery = new BeamCutQuery(_SERVER.ServerName.Database);
        SequenceQuery SequenceQuery = new SequenceQuery(_SERVER.ServerName.Database);

        public int TotalCutQty { get; set; }
        private ContextMenu _menu;
        public OrderDetail(ICollection<BDeviceOrder> orders)
        {
            InitializeComponent();
            _menu = new ContextMenu();
            _menu.MenuItems.Add("Bring forward");
            _menu.MenuItems.Add("Send backward");
            _menu.MenuItems.Add("Delete");

            _menu.MenuItems[0].Click += SelectOrderTask_Click;
            _menu.MenuItems[1].Click += SelectOrderTask_Click1;
            _menu.MenuItems[2].Click += SelectOrderTask_Click2;

            lbBmachineOrder.ContextMenu = _menu;
            if (orders != null)
                DS_BDeviceOrders.DataSource = orders;
        }

        private void lbBmachineOrder_MouseClick(object sender, MouseEventArgs e)
        {
            if (lbBmachineOrder.SelectedItem == null)
                return;

            BDeviceOrder order = lbBmachineOrder.SelectedItem as BDeviceOrder;
            UpdateOrderDetail(order);
        }

        public void UpdateOrderDetail(BDeviceOrder order)
        {
            try
            {
                TotalCutQty = 0;
                lbTotalQty.Text = "";

                if (order != null)
                {
                    BMachineLoader.Controls.Clear();
                    var po = SequenceQuery.GetOriginalPo(order);
                    var BeamPos = BeamCutQuery.GetBeamCutPos(po.id);
                    if (BeamPos != null)
                    {
                        int i = 0;
                        foreach (var item in BeamPos)
                        {
                            OrderResult orderResult = new OrderResult(item);
                            TotalCutQty += orderResult.TotalCutQty;
                            BMachineLoader.Controls.Add(orderResult, 0, i);
                            i++;
                        }
                    }
                }

                lbTotalCut.Text = TotalCutQty.ToString();
                label1.Text = order.PoNumber;
                lbTotalQty.Text = order.PoQty.ToString();
            }
            catch { }
        }

        public void UpdateOrderDetail(Schedule schedule)
        {
            try
            {
                TotalCutQty = 0;
                lbTotalCut.Text = "";
                lbTotalQty.Text = "";

                if (schedule != null)
                {
                    BMachineLoader.Controls.Clear();
                    var po = SequenceQuery.GetOriginalPo(schedule);
                    var BeamPos = BeamCutQuery.GetBeamCutPos(po.id);
                    if (BeamPos != null)
                    {
                        int i = 0;
                        foreach (var item in BeamPos)
                        {
                            OrderResult orderResult = new OrderResult(item);
                            TotalCutQty += orderResult.TotalCutQty;
                            BMachineLoader.Controls.Add(orderResult, 0, i);
                            i++;
                        }
                    }
                }

                lbTotalCut.Text = TotalCutQty.ToString();
                label1.Text = schedule.PoNumber;
                lbTotalQty.Text = schedule.Quantity.ToString();
            }
            catch { }
        }

        private void SelectOrderTask_Click2(object sender, EventArgs e)
        {
            //delete
            var order = lbBmachineOrder.SelectedItem as BDeviceOrder;
            var orders = BeamCutQuery.DeleteOrder(order);
            if (orders != null)
                DS_BDeviceOrders.DataSource = orders;
        }

        private void SelectOrderTask_Click1(object sender, EventArgs e)
        {
            //send backward
            try
            {
                var order = lbBmachineOrder.SelectedItem as BDeviceOrder;
                var orders = BeamCutQuery.MoveOrder(order, 2);
                if (orders != null)
                    DS_BDeviceOrders.DataSource = orders;


                if (lbBmachineOrder.SelectedIndex < lbBmachineOrder.Items.Count - 1)
                    lbBmachineOrder.SelectedIndex += 1;
                else
                    lbBmachineOrder.SelectedIndex = lbBmachineOrder.Items.Count - 1;
            }
            catch { }
        }

        private void SelectOrderTask_Click(object sender, EventArgs e)
        {
            //bring forward
            try
            {
                var order = lbBmachineOrder.SelectedItem as BDeviceOrder;
                var orders = BeamCutQuery.MoveOrder(order, 1); if (orders != null)
                    DS_BDeviceOrders.DataSource = orders;

                if (lbBmachineOrder.SelectedIndex > 0)
                    lbBmachineOrder.SelectedIndex -= 1;
                else
                    lbBmachineOrder.SelectedIndex = 0;
            }
            catch { }
        }
        private void lbBmachineOrder_DoubleClick(object sender, EventArgs e)
        {
            if (lbBmachineOrder.SelectedItems == null)
                return;
            //_menu.Show(lbBmachineOrder, MousePosition);
        }
    }
}
