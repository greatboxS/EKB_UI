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
using MANAGER_FORM.Pages;

namespace MANAGER_FORM
{
    public partial class MANG_FORM : Form
    {
        AppUser CurrentUser = new AppUser();
        EKanbanTaskQuery EKanbanTaskQuery = new EKanbanTaskQuery(_SERVER.ServerName.Database);
        BuildingQuery BuildingQuery = new BuildingQuery(_SERVER.ServerName.Database);
        EmployeeQuery employeeQr = new EmployeeQuery(_SERVER.ServerName.Database);
        OrderPage OrderPage;

        Pages.EKanbanHistories EKanbanHistories = new Pages.EKanbanHistories();
        Pages.PrepareQuantity PrepareQuantity = new Pages.PrepareQuantity();
        Timer Timer = new Timer { Interval = 10000, Enabled = true };
        bool exit = false;
        public MANG_FORM()
        {
            InitializeComponent();
            Timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateEkanbanContainer();
        }

        private void MANG_FORM_Load(object sender, EventArgs e)
        {
            try
            {
                DS_Building.DataSource = BuildingQuery.GetBuildings();
                UpdateEkanbanContainer();
            }
            catch { }

            EkanbanContainerPn.VerticalScroll.Enabled = true;
            EkanbanContainerPn.VerticalScroll.Value = 10;
            EkanbanContainerPn.VerticalScroll.Visible = true;

            
            var admin = employeeQr.GetAppUser("admin", "admin");

            //LOGIN_UI.LOGIN_FORM LOGIN_FORM = new LOGIN_UI.LOGIN_FORM(3);
            //LOGIN_FORM.ShowDialog();

            //if (!LOGIN_FORM.LoginStatus)
            //    this.Close();

            //CurrentUser = LOGIN_FORM.User;
            OrderPage = new OrderPage(admin);
        }

        private void btnPrepareQty_Click(object sender, EventArgs e)
        {
            LoaderPanel.Controls.Clear();
            LoaderPanel.Controls.Add(PrepareQuantity);
            PrepareQuantity.Dock = DockStyle.Fill;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            LoaderPanel.Controls.Clear();
            LoaderPanel.Controls.Add(EKanbanHistories);
            EKanbanHistories.Dock = DockStyle.Fill;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEkanbanContainer();
        }

        ICollection<EKanbanDevice> oldEkanbanDevice = new List<EKanbanDevice>();
        void UpdateEkanbanContainer()
        {
            try
            {
                EkanbanContainerPn.Controls.Clear();
                Building building = BuildingQuery.GetBuilding(comboBox1.Text);
                ICollection<EKanbanDevice> ekanbans = EKanbanTaskQuery.GetEKanbanDevicesByBuilding(building.id);
                foreach (var item in ekanbans)
                {
                    EkanbanContainerPn.Controls.Add(new Controls.EkanbanItem(item));
                }
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BeamCutManager beamCutManager = new BeamCutManager(CurrentUser);
            LoaderPanel.Controls.Clear();
            LoaderPanel.Controls.Add(beamCutManager);
            beamCutManager.Dock = DockStyle.Fill;
        }

        private void MANG_FORM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!exit)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit = true;
            this.Close();
        }
    }
}
