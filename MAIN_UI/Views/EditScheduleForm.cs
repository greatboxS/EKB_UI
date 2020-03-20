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
using SCHEDULE;
using SEQUENCE;
using EKANBAN_SYS_LIB;

namespace MAIN_UI.Views
{
    public partial class EditScheduleForm : Form
    {
        public EditScheduleForm()
        {
            InitializeComponent();
        }

        private Schedule schedule = new Schedule();
        ICollection<ProductionLine> ScheduleLine = new List<ProductionLine>();
        ICollection<ProductionLine> PoLine = new List<ProductionLine>();
        BuildingQuery buildingQuery;
        SequenceQuery sequenceQuery;
        ScheduleQuery ScheduleQuery;
        public EditScheduleForm(Schedule schedule)
        {
            InitializeComponent();
            try
            {
                DS_Schedule.DataSource = this.schedule;
                this.schedule = schedule;
                buildingQuery = new BuildingQuery(_SERVER.ServerName.Database);
                sequenceQuery = new SequenceQuery(_SERVER.ServerName.Database);
                ScheduleQuery = new ScheduleQuery(_SERVER.ServerName.Database);

                ScheduleLine = PoLine = buildingQuery.GetProductionLines();

                DS_Schedule.DataSource = this.schedule;
                DS_Line.DataSource = ScheduleLine;
                DS_OriginalPoLine.DataSource = PoLine;

                var temp1 = buildingQuery.GetProductionLine(schedule.ProductionLine_Id);
                if (temp1 != null)
                {
                    comboBox1.SelectedItem = ScheduleLine.Where(i => i.id == temp1.id).First();
                }
                var pos = sequenceQuery.GetOriginalPos(schedule);

                if (pos != null)
                    DS_OriginalPo.DataSource = pos;

            }
            catch { }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem == null)
                    return;
                var currentPo = listBox1.SelectedItem as OriginalPO;

                var temp1 = buildingQuery.GetProductionLine(currentPo.ProductionLine_Id);
                if (temp1 != null)
                {
                    comboBox2.SelectedItem = PoLine.Where(i => i.id == temp1.id).First();
                }
            }
            catch { }
        }

        private void btnSaveOriginalPo_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;
            var currentPo = listBox1.SelectedItem as OriginalPO;

            if (comboBox2.SelectedItem == null)
                return;
            var currentLine = comboBox2.SelectedItem as ProductionLine;

            currentPo.ProductionLine_Id = currentLine.id;

            if (sequenceQuery.UpdateOriginalPo(currentPo))
            {
                MessageBox.Show("Update success");
            }
            else
            {
                MessageBox.Show("Update failed");
            }
        }

        private void btnSaveSchedule_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                return;
            var currentLine = comboBox1.SelectedItem as ProductionLine;

            schedule.ProductionLine_Id = currentLine.id;

            if (ScheduleQuery.UpdateScheule(schedule))
            {
                MessageBox.Show("Update success");
            }
            else
            {
                MessageBox.Show("Update failed");
            }
        }

        private void btnGetPo_Click(object sender, EventArgs e)
        {
            if (txtSearchPo.Text == string.Empty)
                return;
            var pos = sequenceQuery.GetOriginalPos(txtSearchPo.Text);
            if (pos == null)
                return;
            DS_OriginalPo.DataSource = pos;
        }
    }
}
