using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PRINT_FORM
{
    public partial class PRT_FORM : Form
    {
        public PRT_FORM()
        {
            InitializeComponent();
        }

        public PRT_FORM(Control _obj)
        {
            InitializeComponent();
            this.PrintLoader.Controls.Add(_obj);
            _obj.Dock = DockStyle.Fill;
        }

        public void AddNewPanel(Control _panel)
        {
            PrintLoader.Controls.Add(new SequenceItem(_panel, 0));
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            GetPrintArea(this.PrintLoader);
            PrintPreviewDialog pd = new PrintPreviewDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += PrintDoc_PrintPage;

            pd.Document = printDoc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (this.PrintLoader.Width / 2), this.PrintLoader.Location.Y);
        }

        //Rest of the code
        Bitmap MemoryImage;
        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (MemoryImage != null)
            {
                e.Graphics.DrawImage(MemoryImage, 0, 0);
                base.OnPaint(e);
            }
        }
    }
}
