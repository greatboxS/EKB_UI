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
using SYS_MODELS._ENUM;

namespace MANAGER_FORM.Controls
{
    public partial class EkanbanHisControl : UserControl
    {
        public EkanbanHisControl()
        {
            InitializeComponent();
        }

        private EKanbanHis EKanbanHis;
        private EKanbanTaskQuery eKanbanTaskQuery;
        private SysHistoryQuery SysHistoryQuery;
        public bool ErrorHis { get; set; }
        public int TotaPrepareQty { get; set; }
        public EkanbanHisControl(EKanbanHis ekanbanHis, EKanbanDevice eKanbanDevice, IDbName _database)
        {
            InitializeComponent();
            EKanbanHis = new EKanbanHis();
            EKanbanHis = ekanbanHis;
            eKanbanTaskQuery = new EKanbanTaskQuery(_database);
            SysHistoryQuery = new SysHistoryQuery(_database);
            lbCartName.Text = eKanbanDevice.Name;
        }

        private void EkanbanHisControl_Load(object sender, EventArgs e)
        {
            int height = 120;
            if (EKanbanHis.EKanbanClearHis.Count > 0)
            {
                ErrorHis = true;
                //this.Hide();
                //return;
            }

            EKanbanInterface eKanbanInterface = new EKanbanInterface();
            try
            {
                try
                {
                    eKanbanInterface = Newtonsoft.Json.JsonConvert.DeserializeObject<EKanbanInterface>(EKanbanHis.Data);
                    DS_Interface.DataSource = eKanbanInterface;
                    lbStatus.Text = ((SysActionCode)eKanbanInterface.SysActionCode).ToString();
                }
                catch { }

                if (EKanbanHis.EKanbanAddHis != null)
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("Sequence No");
                    table.Columns.Add("Sequence Quantity");
                    table.Columns.Add("Add Time");
                    table.Columns.Add("Confirm Time");
                   

                    foreach (var item in EKanbanHis.EKanbanAddHis)
                    {
                        string finishTime = "";
                        try
                        {
                            finishTime = ((SysActionCode)eKanbanInterface.SysActionCode == SysActionCode.EKANBAN_CONFIRM_ITEM) ? eKanbanInterface.LastUpdate.ToString() : "";
                        }
                        catch { }
                        table.Rows.Add(new object[] { item.SequenceNo, item.SequenceQty, item.DateTime, finishTime });
                        height += 20;
                    }

                    dataGridView1.DataSource = table;
                }
                TotaPrepareQty = 0;
                foreach (var item in EKanbanHis.EKanbanAddHis)
                {
                    TotaPrepareQty += ShareFuncs.GetInt(item.SequenceQty);
                }

                lbTotalQty.Text = TotaPrepareQty.ToString();

                this.Height = height;
            }
            catch { }
        }
    }
}
