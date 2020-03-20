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
using BUILDING;
using MANAGER_FORM.Controls;

namespace MANAGER_FORM.Pages
{
    public partial class BDeviceStatistic : UserControl
    {
        BeamCutQuery BeamCutQuery = new BeamCutQuery(_SERVER.ServerName.Database);
        BuildingQuery BuildingQuery = new BuildingQuery(_SERVER.ServerName.Database);
        BuildingContext BuildingContext = new BuildingContext(_SERVER.ServerName.Database);
        MachineProgressViewer MachineProgressViewer;
        BeamCutDevice SelectedDevice = new BeamCutDevice();
        public BDeviceStatistic()
        {
            InitializeComponent();
        }
        private void BDeviceStatistic_Load(object sender, EventArgs e)
        {
            try
            {
                DS_Building.DataSource = BuildingQuery.GetBuildings();
                comboBox1.SelectedIndex = 1;
                comboBox1.SelectedIndex = 0;
            }
            catch { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DS_BDevice.DataSource = BeamCutQuery.GetBeamCutDevices((comboBox1.SelectedItem as Building).id);
                listBox1.SelectedIndex = 1;
                listBox1.SelectedIndex = 0;
            }
            catch { }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SelectedDevice = (listBox1.SelectedItem as BeamCutDevice);
                MachineProgressViewer = new MachineProgressViewer(SelectedDevice);
                OrderLoader.Controls.Clear();
                OrderLoader.Controls.Add(MachineProgressViewer);
                MachineProgressViewer.Dock = DockStyle.Fill;
                UpdateChart();
            }
            catch (Exception ex)
            { }
        }

        private void btnGetChart_Click(object sender, EventArgs e)
        {
            UpdateChart();
        }

        private void UpdateChart()
        {
            if ((StartTime.Value - StopTime.Value).TotalDays > 0.2)
            {
                MessageBox.Show("Invalid time value");
                return;
            }

            try
            {
                SelectedDevice = (listBox1.SelectedItem as BeamCutDevice);
                StatisticLoader.Controls.Clear();
                BDeviceChart bDeviceChart = new BDeviceChart(StartTime.Value, StopTime.Value, SelectedDevice);
                StatisticLoader.Controls.Add(bDeviceChart);
                bDeviceChart.Dock = DockStyle.Fill;
            }
            catch { }
        }
    }
}
