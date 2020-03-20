using EKANBAN_SYS_LIB;
using SYS_MODELS;
using System.Drawing;
using System.Windows.Forms;

namespace VIEW_SEQUENCE_FORM
{
    public partial class SizeCtrl : UserControl
    {
        private OriginalPOsequence CurrentSeq;

        SequenceQuery SequenceQuery = new SequenceQuery(_SERVER.ServerName.Database);
        public SizeCtrl(object sequence, bool header)
        {
            InitializeComponent();
            this.Margin = new Padding(0);

            CurrentSeq = new OriginalPOsequence();
            try
            {
                CurrentSeq = sequence as OriginalPOsequence;

                CurrentSeq = SequenceQuery.GetOriginalSequence(CurrentSeq.id);
            }
            catch { }

            if (!header)
            {
                tableLayoutPanel1.RowStyles[0].Height = 0;
                this.Height = 20;
                if (CurrentSeq.SequenceNo % 2 != 0)
                {
                    this.tableLayoutPanel1.BackColor = Color.FromArgb(179, 195, 203);
                }
                else
                    this.tableLayoutPanel1.BackColor = Color.FromArgb(230, 254, 253);
            }
            else
            {
                tableLayoutPanel1.RowStyles[1].Height = 0;
                this.Height = 30;
                this.tableLayoutPanel1.BackColor = Color.FromArgb(155, 252, 246);
                this.tableLayoutPanel1.ForeColor = Color.FromArgb(6, 10, 255);
                return;
            }

            tableLayoutPanel1.Controls.Add(new Label
            {
                Text = $"{CurrentSeq.SequenceNo}/{CurrentSeq.TotalSequence}",
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial Narrow", 10, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)))
            }
            , 0, 1);
            tableLayoutPanel1.Controls.Add(new Label
            {
                Text = CurrentSeq.Quantity.ToString(),
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial Narrow", 10, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)))
            }, 1, 1);

            foreach (var item in CurrentSeq.OriginalSizes)
            {
                for (int i = 3; i <= 32; i++)
                {
                    if (item.SizeId != null && item.SizeId == i)
                    {
                        tableLayoutPanel1.Controls.Add(
                            new Label
                            {
                                Text = item.Quantity.ToString(),
                                AutoSize = false,
                                Dock = DockStyle.Fill,
                                TextAlign = ContentAlignment.MiddleCenter,
                                Font = new Font("Arial Narrow", 10, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)))
                            }
                            , i - 1, 1);
                    }
                }
            }
        }
    }
}
