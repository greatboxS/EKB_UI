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
    public partial class EkanbanItem : UserControl
    {
        private EKanbanDevice EKanbanDevice = new EKanbanDevice();
        public EkanbanItem()
        {
            InitializeComponent();

        }

        public EkanbanItem(EKanbanDevice ekanbandevice)
        {
            InitializeComponent();
            
            EKanbanDevice = ekanbandevice;
            lbName.Text = EKanbanDevice.Name;
            Online.BackColor = Color.Red;

            if (ekanbandevice.LastOnline != null)
            {
                if ((DateTime.Now - (DateTime)ekanbandevice.LastOnline).TotalSeconds < 60)
                {
                    Online.BackColor = Color.Green;
                }
            }

            if(EKanbanDevice.ScreenOff==true)
            {
                ScreenOff.Checked = true;
            }
        }

        private void ScreenOff_CheckStateChanged(object sender, EventArgs e)
        {
            EKanbanDevice.ScreenOff = ScreenOff.Checked;
            EKanbanTaskQuery eKanbanTaskQuery = new EKanbanTaskQuery(_SERVER.ServerName.Database);
            eKanbanTaskQuery.UpdateEKanbanDevice(EKanbanDevice);
        }
    }
}
