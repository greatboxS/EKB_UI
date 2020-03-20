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
    public partial class BeamInterface : UserControl
    {
        public BeamInterface()
        {
            InitializeComponent();
        }

        public bool Error { get; set; }
        public BeamInterface(BeamCutInterface BInterface, int place)
        {
            InitializeComponent();
            try
            {
                lbStartTime.Text = BInterface.StartCutTime.ToString();
                lbStopTime.Text = BInterface.StopCutTime.ToString();
                ScheduleQuery scheduleQuery = new ScheduleQuery(_SERVER.ServerName.Database);
                SequenceQuery sequenceQuery = new SequenceQuery(_SERVER.ServerName.Database);
                BuildingQuery buildingQuery = new BuildingQuery(_SERVER.ServerName.Database);

                var po = sequenceQuery.GetOriginalPo(ShareFuncs.GetInt(BInterface.OriginalPo_Id));
                var schedule = scheduleQuery.GetSchedule(ShareFuncs.GetInt(BInterface.Schedule_Id));
                if (schedule == null)
                {
                    if (po != null)
                        schedule = scheduleQuery.GetSchedule(po);

                    if (schedule == null)
                    {
                        this.Hide();
                        Error = true;
                        return;
                    }
                }
                lbPlace.Text = place.ToString();
                DS_Interface.DataSource = BInterface;
                DS_Po.DataSource = schedule;
                lbLine.Text = buildingQuery.GetProductionLine(ShareFuncs.GetInt(schedule.ProductionLine_Id)).LineName;
            }
            catch {
                this.Hide();
                Error = true;
                return;
            }
        }
    }
}
