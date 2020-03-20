using EKANBAN_SYS_LIB;
using PRINT_FORM;
using SYS_MODELS;
using SYS_MODELS._ENUM;
using System;
using System.Windows.Forms;

namespace VIEW_SEQUENCE_FORM
{
    public partial class SEQUENCE_FORM : Form
    {
        private int SequenceCounter = 0;

        SysHistoryQuery SysHistoryQuery = new SysHistoryQuery(_SERVER.ServerName.Database);
        public SEQUENCE_FORM()
        {
            InitializeComponent();
        }

        public SEQUENCE_FORM(Schedule _schedule)
        {
            InitializeComponent();
            AddNewSequenceViewer(_schedule);
        }

        public void AddNewSequenceViewer(Schedule _schedule)
        {
            SequenceCounter++;
            SequenceCtrl seqCtrl = new SequenceCtrl(_schedule, true);
            SequenceLoader.Controls.Add(new SequenceItem(seqCtrl, SequenceCounter));

            AppHistory his = new AppHistory
            {
                SysActionCode = (int)(SysActionCode.VIEW_SEQUENCE),
                Remark = $"PO:{(_schedule as Schedule).PoNumber}",
            };
            SysHistoryQuery.AddNewAppHistory(his);
        }

        private void Prints_Click(object sender, EventArgs e)
        {
            PRT_FORM pRT_FORM = new PRT_FORM();
            pRT_FORM.Show();
            pRT_FORM.AddNewPanel(SequenceLoader);
        }

        private void SequenceLoader_Paint(object sender, PaintEventArgs e)
        {
            SequenceCounter = SequenceLoader.Controls.Count;
        }
    }
}
