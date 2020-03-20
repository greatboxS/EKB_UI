using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXCEL_TO_DATABASE.Views
{
    public partial class SelectNameForm : Form
    {
        public SelectNameForm()
        {
            InitializeComponent();
        }

        public SelectNameForm(string[] names)
        {
            InitializeComponent();
            comboBox1.Items.AddRange(names);
        }

        public string SheetName { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            SheetName = comboBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            SheetName = comboBox1.Text;
        }
    }
}
