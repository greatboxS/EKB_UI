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

namespace MANAGER_FORM.Pages
{
    public partial class BeamCutManager : UserControl
    {
        public BeamCutManager()
        {
            InitializeComponent();
        }

        public BeamCutManager(AppUser user)
        {
            InitializeComponent();
            OrderPage orderPage = new OrderPage(user);
            BDeviceStatistic bDeviceStatistic = new BDeviceStatistic();
            Tab1.Controls.Add(bDeviceStatistic);
            bDeviceStatistic.Dock = DockStyle.Fill;
            Tab2.Controls.Add(orderPage);
            orderPage.Dock = DockStyle.Fill;
        }
    }
}
