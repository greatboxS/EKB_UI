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
using SCHEDULE;

namespace MANAGER_FORM.Pages
{
    public partial class PrepareQuantity : UserControl
    {
        private EKanbanTaskQuery EKanbanTaskQuery = new EKanbanTaskQuery(_SERVER.ServerName.Database);
        private BuildingQuery BuildingQuery = new BuildingQuery(_SERVER.ServerName.Database);
        private ScheduleQuery ScheduleQuery = new ScheduleQuery(_SERVER.ServerName.Database);

        public PrepareQuantity()
        {
            InitializeComponent();
            UpdateTreeViewSource();
        }

        void UpdateTreeViewSource()
        {
            var scheduleClass = ScheduleQuery.GetScheduleClasses();

            if (scheduleClass == null) return;

            foreach (var cls in scheduleClass)
            {
                treeView1.Nodes.Add(cls.Name, $"Schedule: {cls.Name}");
                var buildings = BuildingQuery.GetBuildings();
                treeView1.Nodes[cls.Name].ExpandAll();
                foreach (var building in buildings)
                {
                    treeView1.Nodes[cls.Name].Nodes.Add(building.Name, $"Building: {building.Name}");
                    string[] modelName = GetScheduleModelName(building, cls);
                    foreach (string s in modelName)
                    {
                        treeView1.Nodes[cls.Name].Nodes[building.Name].Nodes.Add(s, $"Model name: {s}");
                    }
                }
            }
        }


        string[] GetScheduleModelName(Building buildind, ScheduleClass cls)
        {
            var productionLines = BuildingQuery.GetProductionLines(buildind.id);
            List<Schedule> schedules = new List<Schedule>();
            foreach (var line in productionLines)
            {
                using (ScheduleContext db = new ScheduleContext(_SERVER.ServerName.Database))
                {
                    var schs = db.Schedules.Where(i => i.ScheduleClass_Id == cls.id && i.ProductionLine_Id == line.id);
                    if (schs.Count() > 0)
                        schedules.AddRange(schs.ToList());

                }
            }

            IEnumerable<IGrouping<string, Schedule>> group = schedules.GroupBy(i => i.ModelName).ToList();

            List<string> modelName = new List<string>();
            foreach (var item in group)
            {
                modelName.Add(item.Key);
            }
            return modelName.ToArray();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string path = e.Node.FullPath;
            string[] splitedPath = path.Split(new string[1] { "\\" }, StringSplitOptions.None);
            
            switch(splitedPath.Count())
            {
                case 1:
                        break;

                case 2:
                    break;

                case 3:
                    break;

                default:
                    break;
            }
        }
    }
}
