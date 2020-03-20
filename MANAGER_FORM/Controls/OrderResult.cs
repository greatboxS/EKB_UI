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
    public partial class OrderResult : UserControl
    {
        public OrderResult()
        {
            InitializeComponent();
        }

        public int TotalCutQty { get; set; }

        private BeamCutPo BeamCutPo;
        public OrderResult(BeamCutPo beamCutPo)
        {
            try
            {
                InitializeComponent();
                BeamCutPo = new BeamCutPo();
                BeamCutPo = beamCutPo;
                BeamCutQuery beamCutQuery = new BeamCutQuery(_SERVER.ServerName.Database);
                ComponentQuery componentQuery = new ComponentQuery(_SERVER.ServerName.Database);
                SequenceQuery sequenceQuery = new SequenceQuery(_SERVER.ServerName.Database);
                var originalPo = sequenceQuery.GetOriginalPo(beamCutPo.OriginalPo_Id);
                var component = componentQuery.GetShoeComponent(BeamCutPo.Component_Id);
                label2.Text = component != null ? component.Reference : "";
                var Binterface = beamCutQuery.GetBeamInterface(beamCutPo.id);

                int totalCutQty = 0;
                int totalCutTime = 0;

                bool first = false;
                bool last = false;

                double totalTime = 0;
                DateTime? start = null, stop = null, last_update = null;

                foreach (var item in Binterface)
                {
                    if (!first)
                    {
                        if (item.StartCutTime != null)
                        {
                            start = (DateTime)item.StartCutTime;
                            label9.Text = start != null ? start.ToString() : "";
                        }
                        first = true;
                    }

                    totalCutTime += ShareFuncs.GetInt(item.BeamCutCounter);
                    totalCutQty += ShareFuncs.GetInt(item.CuttingQty);
                    if (item.StopCutTime != null)
                        label7.Text = item.StopCutTime.ToString();

                    try
                    {
                        if (item.StopCutTime != null)
                        {
                            stop = (DateTime)item.StopCutTime;

                        }
                        else
                        {
                            stop = (DateTime)item.LastConfirmSize;
                        }
                        label11.Text = stop != null ? ((DateTime)stop).ToString() : "";

                        totalTime = ((DateTime)stop - (DateTime)start).TotalSeconds;
                        label13.Text = $"{((int)totalTime / 60)}min {(int)totalTime % 60}sec";

                        label15.Text = $"{(int)(totalCutQty * 60 / totalTime)} c/min";
                    }
                    catch { }
                }

                label3.Text = totalCutQty.ToString();
                label5.Text = totalCutTime.ToString();
                TotalCutQty = totalCutQty;
            }
            catch { }
        }

        private void OrderResult_Load(object sender, EventArgs e)
        {

        }
    }

}
