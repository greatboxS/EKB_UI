using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EKANBAN_SYS_LIB;
using SYS_MODELS;
using Newtonsoft.Json;
using LOGIN_UI;

namespace EXCEL_TO_DATABASE.Views
{
    public partial class SettingForm : Form
    {
        public ExcelColumnDef ExcelColumnDef = new ExcelColumnDef();
        ComponentQuery ComponentQuery = new ComponentQuery(_SERVER.ServerName.Database);
        ICollection<ShoeSize> ShoeSizes = new List<ShoeSize>();

        List<ExcelColumnDef> ExcelColumnDefs = new List<ExcelColumnDef>();

        public SettingForm()
        {
            InitializeComponent();
        }

        public SettingForm(ExcelColumnDef excelColumnDef)
        {
            InitializeComponent();
            ExcelColumnDef = excelColumnDef;
            DS_ExcelSettingPars.DataSource = ExcelColumnDef;

            try
            {
                string temp = Properties.Settings.Default.ParameterHis;
                if (temp != string.Empty)
                    ExcelColumnDefs = JsonConvert.DeserializeObject<List<ExcelColumnDef>>(temp);
                else
                    ExcelColumnDefs = new List<ExcelColumnDef>();
            }
            catch { }

            if (ExcelColumnDefs == null)
                return;

            for (int i = 0; i < ExcelColumnDefs.Count; i++)
            {
                comboBox1.Items.Add($"Setting {i + 1}");
            }
        }

        string GetColumnName(TextBox textbox)
        {
            int columNum = 0;
            int.TryParse(textbox.Text, out columNum);
            string ColumnName = "";
            columNum += 1;

            if (columNum <= 26)
            {
                ColumnName = ((char)(columNum + 64)).ToString();
                return ColumnName;
            }
            else
            {
                int first = columNum / 26;
                int second = columNum % 26;

                if (second == 0)
                {
                    ColumnName = ((char)(first + 64 - 1)).ToString();
                    ColumnName += "Z";
                }
                else
                {
                    ColumnName = ((char)(first - 1 + 65)).ToString();
                    ColumnName += ((char)(second - 1 + 65)).ToString();
                }

                return ColumnName;
            }
        }
        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label16.Text = GetColumnName(sender as TextBox);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label21.Text = GetColumnName(sender as TextBox);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            label17.Text = GetColumnName(sender as TextBox);
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            label19.Text = GetColumnName(sender as TextBox);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label18.Text = GetColumnName(sender as TextBox);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label20.Text = GetColumnName(sender as TextBox);
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            label23.Text = GetColumnName(sender as TextBox);
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            label22.Text = GetColumnName(sender as TextBox);
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            label25.Text = GetColumnName(sender as TextBox);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            label24.Text = GetColumnName(sender as TextBox);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            label26.Text = GetColumnName(sender as TextBox);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            label27.Text = GetColumnName(sender as TextBox);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            label28.Text = GetColumnName(sender as TextBox);
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            label29.Text = GetColumnName(sender as TextBox);
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            label30.Text = GetColumnName(sender as TextBox);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            label31.Text = GetColumnName(sender as TextBox);
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            ShoeSizes = ComponentQuery.GetShoeSizes();
        }

        private string GetShoeName(TextBox textbox)
        {
            try
            {
                int sizeId = 0;
                int.TryParse(textbox.Text, out sizeId);

                return ShoeSizes.Where(i => i.id == sizeId).First().SizeName;
            }
            catch { return null; }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            label38.Text = GetShoeName(sender as TextBox);
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            label37.Text = GetShoeName(sender as TextBox);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            label36.Text = GetShoeName(sender as TextBox);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            label35.Text = GetShoeName(sender as TextBox);
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            label34.Text = GetShoeName(sender as TextBox);
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            label33.Text = GetShoeName(sender as TextBox);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ExcelColumnDef = ExcelColumnDefs[comboBox1.SelectedIndex];
                DS_ExcelSettingPars.DataSource = ExcelColumnDefs[comboBox1.SelectedIndex];
            }
            catch { };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ExcelColumnDefs == null)
                ExcelColumnDefs = new List<ExcelColumnDef>();

            try
            {
                ExcelColumnDefs.Add(ExcelColumnDef);
                Properties.Settings.Default.ParameterHis = JsonConvert.SerializeObject(ExcelColumnDefs);
                Properties.Settings.Default.Save();
                MessageBox.Show("Save setting success");

                comboBox1.Items.Clear();
                for (int i = 0; i < ExcelColumnDefs.Count; i++)
                {
                    comboBox1.Items.Add($"Setting {i + 1}");
                }
            }
            catch (Exception ex)
            { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LOGIN_FORM FLogin = new LOGIN_FORM(2);
            FLogin.ShowDialog();

            if (!FLogin.LoginStatus)
                return;

            Properties.Settings.Default.ParameterHis = "";
            Properties.Settings.Default.Save();
            comboBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex >= 0 && ExcelColumnDefs != null)
                {
                    if (ExcelColumnDefs.Count > comboBox1.SelectedIndex)
                    {
                        ExcelColumnDefs[comboBox1.SelectedIndex] = ExcelColumnDef;
                        Properties.Settings.Default.ParameterHis = JsonConvert.SerializeObject(ExcelColumnDefs);
                        Properties.Settings.Default.Save();
                        MessageBox.Show("Save changes success");
                        //
                    }
                }
            }
            catch { }
        }
    }
}
