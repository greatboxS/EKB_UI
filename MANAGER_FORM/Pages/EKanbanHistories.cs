using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EKANBAN_SYS_LIB;
using SYS_MODELS;
using MANAGER_FORM.Controls;

namespace MANAGER_FORM.Pages
{
    public partial class EKanbanHistories : UserControl
    {
        BuildingQuery BuildingQuery = new BuildingQuery(_SERVER.ServerName.Database);
        EKanbanTaskQuery EKanbanTaskQuery = new EKanbanTaskQuery(_SERVER.ServerName.Database);
        public EKanbanHistories()
        {
            InitializeComponent();
        }

        string currentNodeName = "";
        private void EKanbanHistories_Load(object sender, EventArgs e)
        {
            try
            {
                var buildings = BuildingQuery.GetBuildings();
                int i = 0, k = 0;

                foreach (var b in buildings)
                {
                    treeView1.Nodes.Add(b.Name, $"Building: {b.Name}");

                    var lines = BuildingQuery.GetProductionLines(b.id);

                    foreach (var l in lines)
                    {
                        treeView1.Nodes[b.Name].Nodes.Add(l.LineName, $"Line: {l.LineName}");

                        var ekanbans = EKanbanTaskQuery.GetEKanbanDevicesByProductionLine(l.id);

                        foreach (var ekb in ekanbans)
                        {
                            treeView1.Nodes[b.Name].Nodes[l.LineName].Nodes.Add(ekb.Name, ekb.Name);
                        }
                        k++;
                    }
                    i++;
                }
            }
            catch { }
        }

        private void TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            currentNodeName = e.Node.Name;
            var ekb = EKanbanTaskQuery.GetEKanbanDevice(currentNodeName);
            if (ekb == null)
                return;

            SplitEkanbanDeviceHistories(ekb);
        }

        private void SplitEkanbanDeviceHistories(EKanbanDevice eKanbanDevice)
        {
            HistoryFlow.Controls.Clear();
            SysHistoryQuery sysHistoryQuery = new SysHistoryQuery(_SERVER.ServerName.Database);
            var ehis = sysHistoryQuery.GetEKanbanHistories(eKanbanDevice.id);
            int TotalQty = 0;
            if (ehis != null)
            {
                int i = 0;
                foreach (var item in ehis)
                {
                    EkanbanHisControl ekanbanHisControl = new EkanbanHisControl(item, eKanbanDevice, _SERVER.ServerName.Database);

                    HistoryFlow.Controls.Add(ekanbanHisControl);
                    if (!ekanbanHisControl.ErrorHis)
                    {
                        i++;
                        TotalQty += ekanbanHisControl.TotaPrepareQty;
                    }
                }
                lbTotalPrepare.Text = i.ToString();
                lbTotalPrepareQty.Text = TotalQty.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var ekb = EKanbanTaskQuery.GetEKanbanDevice(currentNodeName);
            if (ekb == null)
                return;

            SplitEkanbanDeviceHistories(ekb);
        }
    }
}
