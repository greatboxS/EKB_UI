namespace EXCEL_TO_DATABASE.Views
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DS_ExcelSettingPars = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DS_ExcelSettingPars)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Po number:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_ExcelSettingPars, "PoCol", true));
            this.textBox1.Location = new System.Drawing.Point(95, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(57, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // DS_ExcelSettingPars
            // 
            this.DS_ExcelSettingPars.DataSource = typeof(EXCEL_TO_DATABASE.Views.ExcelColumnDef);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_ExcelSettingPars, "ModelNumberCol", true));
            this.textBox2.Location = new System.Drawing.Point(95, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(57, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Model number:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_ExcelSettingPars, "ArticleCol", true));
            this.textBox3.Location = new System.Drawing.Point(95, 136);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(57, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Article:";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_ExcelSettingPars, "ModelNameCol", true));
            this.textBox4.Location = new System.Drawing.Point(95, 109);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(57, 20);
            this.textBox4.TabIndex = 6;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Model name:";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_ExcelSettingPars, "ExtendCol", true));
            this.textBox5.Location = new System.Drawing.Point(95, 32);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(57, 20);
            this.textBox5.TabIndex = 10;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Po extend:";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_ExcelSettingPars, "StartKidFirst", true));
            this.textBox6.Location = new System.Drawing.Point(380, 6);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(57, 20);
            this.textBox6.TabIndex = 14;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Start kid first:";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_ExcelSettingPars, "StopKidFirst", true));
            this.textBox7.Location = new System.Drawing.Point(380, 33);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(57, 20);
            this.textBox7.TabIndex = 16;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Stop kid first:";
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_ExcelSettingPars, "StopKidSec", true));
            this.textBox8.Location = new System.Drawing.Point(380, 87);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(57, 20);
            this.textBox8.TabIndex = 20;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Stop kid second:";
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_ExcelSettingPars, "StartKidSec", true));
            this.textBox9.Location = new System.Drawing.Point(380, 60);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(57, 20);
            this.textBox9.TabIndex = 18;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            this.textBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(297, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Start kid second:";
            // 
            // textBox12
            // 
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_ExcelSettingPars, "StopMen", true));
            this.textBox12.Location = new System.Drawing.Point(380, 141);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(57, 20);
            this.textBox12.TabIndex = 24;
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            this.textBox12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(297, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Stop men:";
            // 
            // textBox13
            // 
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_ExcelSettingPars, "StartMen", true));
            this.textBox13.Location = new System.Drawing.Point(380, 114);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(57, 20);
            this.textBox13.TabIndex = 22;
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            this.textBox13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(297, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Start men:";
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_ExcelSettingPars, "StopKidSecSizeId", true));
            this.textBox10.Location = new System.Drawing.Point(491, 87);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(35, 20);
            this.textBox10.TabIndex = 28;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            this.textBox10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_ExcelSettingPars, "StartKidSecSizeId", true));
            this.textBox11.Location = new System.Drawing.Point(491, 60);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(35, 20);
            this.textBox11.TabIndex = 27;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            this.textBox11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // textBox14
            // 
            this.textBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_ExcelSettingPars, "StopKidFirstSizeid", true));
            this.textBox14.Location = new System.Drawing.Point(491, 33);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(35, 20);
            this.textBox14.TabIndex = 26;
            this.textBox14.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            this.textBox14.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // textBox15
            // 
            this.textBox15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_ExcelSettingPars, "StartKidFirstSizeId", true));
            this.textBox15.Location = new System.Drawing.Point(491, 6);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(35, 20);
            this.textBox15.TabIndex = 25;
            this.textBox15.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            this.textBox15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // textBox18
            // 
            this.textBox18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_ExcelSettingPars, "StopMenSizeId", true));
            this.textBox18.Location = new System.Drawing.Point(492, 141);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(35, 20);
            this.textBox18.TabIndex = 30;
            this.textBox18.TextChanged += new System.EventHandler(this.textBox18_TextChanged);
            this.textBox18.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // textBox19
            // 
            this.textBox19.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_ExcelSettingPars, "StartMenSizeId", true));
            this.textBox19.Location = new System.Drawing.Point(492, 114);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(35, 20);
            this.textBox19.TabIndex = 29;
            this.textBox19.TextChanged += new System.EventHandler(this.textBox19_TextChanged);
            this.textBox19.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(380, 279);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBox16
            // 
            this.textBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_ExcelSettingPars, "CuttingDateCol", true));
            this.textBox16.Location = new System.Drawing.Point(95, 163);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(57, 20);
            this.textBox16.TabIndex = 33;
            this.textBox16.TextChanged += new System.EventHandler(this.textBox16_TextChanged);
            this.textBox16.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Cutting date:";
            // 
            // textBox17
            // 
            this.textBox17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_ExcelSettingPars, "StitchingDateCol", true));
            this.textBox17.Location = new System.Drawing.Point(95, 190);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(57, 20);
            this.textBox17.TabIndex = 35;
            this.textBox17.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            this.textBox17.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Stitching date:";
            // 
            // textBox20
            // 
            this.textBox20.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_ExcelSettingPars, "ProductionLineCol", true));
            this.textBox20.Location = new System.Drawing.Point(95, 217);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(57, 20);
            this.textBox20.TabIndex = 37;
            this.textBox20.TextChanged += new System.EventHandler(this.textBox20_TextChanged);
            this.textBox20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 220);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Production line:";
            // 
            // textBox21
            // 
            this.textBox21.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_ExcelSettingPars, "QuantityCol", true));
            this.textBox21.Location = new System.Drawing.Point(95, 57);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(57, 20);
            this.textBox21.TabIndex = 39;
            this.textBox21.TextChanged += new System.EventHandler(this.textBox21_TextChanged);
            this.textBox21.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxKeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Quantity:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.DS_ExcelSettingPars, "EnableModelCol", true));
            this.checkBox1.Location = new System.Drawing.Point(206, 84);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(59, 17);
            this.checkBox1.TabIndex = 40;
            this.checkBox1.Text = "Enable";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.DS_ExcelSettingPars, "EnableModelName", true));
            this.checkBox2.Location = new System.Drawing.Point(206, 111);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox2.Size = new System.Drawing.Size(59, 17);
            this.checkBox2.TabIndex = 41;
            this.checkBox2.Text = "Enable";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.DS_ExcelSettingPars, "EnableArtilce", true));
            this.checkBox3.Location = new System.Drawing.Point(206, 138);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox3.Size = new System.Drawing.Size(59, 17);
            this.checkBox3.TabIndex = 42;
            this.checkBox3.Text = "Enable";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.DS_ExcelSettingPars, "EnableCuttingDate", true));
            this.checkBox4.Location = new System.Drawing.Point(206, 165);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox4.Size = new System.Drawing.Size(59, 17);
            this.checkBox4.TabIndex = 43;
            this.checkBox4.Text = "Enable";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.DS_ExcelSettingPars, "EnableStitchingDate", true));
            this.checkBox5.Location = new System.Drawing.Point(206, 192);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox5.Size = new System.Drawing.Size(59, 17);
            this.checkBox5.TabIndex = 44;
            this.checkBox5.Text = "Enable";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(158, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "#";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(158, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 13);
            this.label17.TabIndex = 46;
            this.label17.Text = "#";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(158, 87);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 13);
            this.label18.TabIndex = 48;
            this.label18.Text = "#";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(158, 60);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 13);
            this.label19.TabIndex = 47;
            this.label19.Text = "#";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(158, 139);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 13);
            this.label20.TabIndex = 50;
            this.label20.Text = "#";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(158, 112);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 13);
            this.label21.TabIndex = 49;
            this.label21.Text = "#";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(158, 193);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 13);
            this.label22.TabIndex = 52;
            this.label22.Text = "#";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(158, 166);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 13);
            this.label23.TabIndex = 51;
            this.label23.Text = "#";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(443, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(14, 13);
            this.label24.TabIndex = 54;
            this.label24.Text = "#";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(158, 220);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(14, 13);
            this.label25.TabIndex = 53;
            this.label25.Text = "#";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(443, 36);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(14, 13);
            this.label26.TabIndex = 55;
            this.label26.Text = "#";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(443, 63);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(14, 13);
            this.label27.TabIndex = 56;
            this.label27.Text = "#";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(443, 90);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(14, 13);
            this.label28.TabIndex = 57;
            this.label28.Text = "#";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(443, 117);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(14, 13);
            this.label29.TabIndex = 58;
            this.label29.Text = "#";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(443, 144);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(14, 13);
            this.label30.TabIndex = 59;
            this.label30.Text = "#";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.DS_ExcelSettingPars, "NewProductionLineFormat", true));
            this.checkBox6.Location = new System.Drawing.Point(324, 193);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox6.Size = new System.Drawing.Size(176, 17);
            this.checkBox6.TabIndex = 60;
            this.checkBox6.Text = "Use new production Line format\r\n";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(158, 247);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(14, 13);
            this.label31.TabIndex = 63;
            this.label31.Text = "#";
            // 
            // textBox22
            // 
            this.textBox22.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_ExcelSettingPars, "SequenceCol", true));
            this.textBox22.Location = new System.Drawing.Point(95, 244);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(57, 20);
            this.textBox22.TabIndex = 62;
            this.textBox22.TextChanged += new System.EventHandler(this.textBox22_TextChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(12, 247);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(59, 13);
            this.label32.TabIndex = 61;
            this.label32.Text = "Sequence:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(550, 144);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(14, 13);
            this.label33.TabIndex = 69;
            this.label33.Text = "#";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(550, 117);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(14, 13);
            this.label34.TabIndex = 68;
            this.label34.Text = "#";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(550, 90);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(14, 13);
            this.label35.TabIndex = 67;
            this.label35.Text = "#";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(550, 63);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(14, 13);
            this.label36.TabIndex = 66;
            this.label36.Text = "#";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(550, 36);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(14, 13);
            this.label37.TabIndex = 65;
            this.label37.Text = "#";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(550, 9);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(14, 13);
            this.label38.TabIndex = 64;
            this.label38.Text = "#";
            // 
            // textBox23
            // 
            this.textBox23.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_ExcelSettingPars, "ExcelSheetNumber", true));
            this.textBox23.Location = new System.Drawing.Point(341, 218);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(57, 20);
            this.textBox23.TabIndex = 71;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(258, 221);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(65, 13);
            this.label40.TabIndex = 70;
            this.label40.Text = "Excel sheet:";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.DS_ExcelSettingPars, "EnableSelectSheetIndex", true));
            this.checkBox7.Location = new System.Drawing.Point(414, 220);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox7.Size = new System.Drawing.Size(113, 17);
            this.checkBox7.TabIndex = 72;
            this.checkBox7.Text = "Select sheet index";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 281);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 73;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 74;
            this.button1.Text = "Add Setting";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 75;
            this.button2.Text = "Clear setting";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(135, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 23);
            this.button3.TabIndex = 76;
            this.button3.Text = "Save changes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 310);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(603, 349);
            this.MinimumSize = new System.Drawing.Size(603, 349);
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingForm";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_ExcelSettingPars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.BindingSource DS_ExcelSettingPars;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}