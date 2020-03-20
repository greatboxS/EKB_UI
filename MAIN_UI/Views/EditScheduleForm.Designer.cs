namespace MAIN_UI.Views
{
    partial class EditScheduleForm
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
            this.DS_Schedule = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txt_oPO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_OModelName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_OArt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_OQty = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtStitchingDate = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.btnSaveSchedule = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DS_Line = new System.Windows.Forms.BindingSource(this.components);
            this.DS_OriginalPo = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.DS_OriginalPoLine = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveOriginalPo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetPo = new System.Windows.Forms.Button();
            this.txtSearchPo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Schedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_OriginalPo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_OriginalPoLine)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DS_Schedule
            // 
            this.DS_Schedule.DataSource = typeof(SYS_MODELS.Schedule);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "PO number:";
            // 
            // txt_oPO
            // 
            this.txt_oPO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_Schedule, "PoNumber", true));
            this.txt_oPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_oPO.Location = new System.Drawing.Point(9, 22);
            this.txt_oPO.Name = "txt_oPO";
            this.txt_oPO.Size = new System.Drawing.Size(139, 22);
            this.txt_oPO.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Model:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_Schedule, "Model", true));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(163, 22);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 22);
            this.textBox3.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Model name:";
            // 
            // txt_OModelName
            // 
            this.txt_OModelName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_Schedule, "ModelName", true));
            this.txt_OModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OModelName.Location = new System.Drawing.Point(163, 63);
            this.txt_OModelName.Name = "txt_OModelName";
            this.txt_OModelName.Size = new System.Drawing.Size(139, 22);
            this.txt_OModelName.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(163, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Article:";
            // 
            // txt_OArt
            // 
            this.txt_OArt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_Schedule, "Article", true));
            this.txt_OArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OArt.Location = new System.Drawing.Point(163, 104);
            this.txt_OArt.Name = "txt_OArt";
            this.txt_OArt.Size = new System.Drawing.Size(139, 22);
            this.txt_OArt.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Quantity:";
            // 
            // txt_OQty
            // 
            this.txt_OQty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_Schedule, "Quantity", true));
            this.txt_OQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OQty.Location = new System.Drawing.Point(9, 63);
            this.txt_OQty.Name = "txt_OQty";
            this.txt_OQty.Size = new System.Drawing.Size(139, 22);
            this.txt_OQty.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Cutting date:";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_Schedule, "CuttingDate", true));
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(9, 145);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(139, 22);
            this.textBox6.TabIndex = 12;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(163, 129);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(75, 13);
            this.label30.TabIndex = 15;
            this.label30.Text = "Stitching date:";
            // 
            // txtStitchingDate
            // 
            this.txtStitchingDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_Schedule, "StitchindDate", true));
            this.txtStitchingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStitchingDate.Location = new System.Drawing.Point(163, 145);
            this.txtStitchingDate.Name = "txtStitchingDate";
            this.txtStitchingDate.Size = new System.Drawing.Size(139, 22);
            this.txtStitchingDate.TabIndex = 16;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(9, 88);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(80, 13);
            this.label32.TabIndex = 47;
            this.label32.Text = "Production line:";
            // 
            // btnSaveSchedule
            // 
            this.btnSaveSchedule.Location = new System.Drawing.Point(98, 229);
            this.btnSaveSchedule.Name = "btnSaveSchedule";
            this.btnSaveSchedule.Size = new System.Drawing.Size(117, 22);
            this.btnSaveSchedule.TabIndex = 49;
            this.btnSaveSchedule.Text = "Save Schedule";
            this.btnSaveSchedule.UseVisualStyleBackColor = true;
            this.btnSaveSchedule.Click += new System.EventHandler(this.btnSaveSchedule_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.DS_Line;
            this.comboBox1.DisplayMember = "LineName";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 50;
            // 
            // DS_Line
            // 
            this.DS_Line.DataSource = typeof(SYS_MODELS.ProductionLine);
            // 
            // DS_OriginalPo
            // 
            this.DS_OriginalPo.DataSource = typeof(SYS_MODELS.OriginalPO);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.13269F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.86731F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(631, 267);
            this.tableLayoutPanel1.TabIndex = 51;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(326, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 259);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.btnSaveOriginalPo);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(127, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(174, 259);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "PO number:";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.DS_OriginalPoLine;
            this.comboBox2.DisplayMember = "LineName";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(16, 105);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(139, 21);
            this.comboBox2.TabIndex = 67;
            // 
            // DS_OriginalPoLine
            // 
            this.DS_OriginalPoLine.DataSource = typeof(SYS_MODELS.ProductionLine);
            // 
            // btnSaveOriginalPo
            // 
            this.btnSaveOriginalPo.Location = new System.Drawing.Point(38, 229);
            this.btnSaveOriginalPo.Name = "btnSaveOriginalPo";
            this.btnSaveOriginalPo.Size = new System.Drawing.Size(117, 22);
            this.btnSaveOriginalPo.TabIndex = 66;
            this.btnSaveOriginalPo.Text = "Save Seq Po";
            this.btnSaveOriginalPo.UseVisualStyleBackColor = true;
            this.btnSaveOriginalPo.Click += new System.EventHandler(this.btnSaveOriginalPo_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_OriginalPo, "Quantity", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 22);
            this.textBox1.TabIndex = 62;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_OriginalPo, "PoNumber", true));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(16, 22);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(139, 22);
            this.textBox4.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Quantity:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 65;
            this.label14.Text = "Production line:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.listBox1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panel4.Size = new System.Drawing.Size(127, 259);
            this.panel4.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.DS_OriginalPo;
            this.listBox1.DisplayMember = "PoNumber";
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(5, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(117, 186);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.btnGetPo);
            this.panel5.Controls.Add(this.txtSearchPo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(117, 73);
            this.panel5.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Search for Po";
            // 
            // btnGetPo
            // 
            this.btnGetPo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPo.Location = new System.Drawing.Point(25, 43);
            this.btnGetPo.Name = "btnGetPo";
            this.btnGetPo.Size = new System.Drawing.Size(71, 24);
            this.btnGetPo.TabIndex = 53;
            this.btnGetPo.Text = "Refresh";
            this.btnGetPo.UseVisualStyleBackColor = true;
            this.btnGetPo.Click += new System.EventHandler(this.btnGetPo_Click);
            // 
            // txtSearchPo
            // 
            this.txtSearchPo.Location = new System.Drawing.Point(3, 22);
            this.txtSearchPo.Name = "txtSearchPo";
            this.txtSearchPo.Size = new System.Drawing.Size(111, 20);
            this.txtSearchPo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnSaveSchedule);
            this.panel1.Controls.Add(this.txt_OQty);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.txt_oPO);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.txt_OArt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtStitchingDate);
            this.panel1.Controls.Add(this.txt_OModelName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 259);
            this.panel1.TabIndex = 0;
            // 
            // EditScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 267);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(647, 306);
            this.MinimumSize = new System.Drawing.Size(647, 306);
            this.Name = "EditScheduleForm";
            this.Text = "EditScheduleForm";
            ((System.ComponentModel.ISupportInitialize)(this.DS_Schedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_OriginalPo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_OriginalPoLine)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource DS_Schedule;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_oPO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_OModelName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_OArt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_OQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtStitchingDate;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button btnSaveSchedule;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource DS_Line;
        private System.Windows.Forms.BindingSource DS_OriginalPo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource DS_OriginalPoLine;
        private System.Windows.Forms.Button btnSaveOriginalPo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetPo;
        private System.Windows.Forms.TextBox txtSearchPo;
    }
}