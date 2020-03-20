using System;
using System.Drawing;
using System.Windows.Forms;

namespace PRINT_FORM
{
    public partial class SequenceItem : UserControl
    {
        public SequenceItem()
        {
            InitializeComponent();
        }

        public SequenceItem(Control _panel, int _counter)
        {
            InitializeComponent();

            lb_No.Text = _counter.ToString();
            if (_counter % 2 == 0)
            {
                lb_No.BackColor = Color.LightBlue;
            }

            this.Height = _panel.Height;
            this.Width = 850 + 50;
            this.ItemLoader.Controls.Add(_panel);
            _panel.Dock = DockStyle.Fill;
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            this.ItemLoader.Controls.Clear();
            this.Dispose();
        }
    }
}
