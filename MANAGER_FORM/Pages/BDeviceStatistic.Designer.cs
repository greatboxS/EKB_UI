namespace MANAGER_FORM.Pages
{
    partial class BDeviceStatistic
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DS_Building = new System.Windows.Forms.BindingSource(this.components);
            this.DS_BDevice = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnGetChart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.StopTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.StartTime = new System.Windows.Forms.DateTimePicker();
            this.StatisticLoader = new System.Windows.Forms.Panel();
            this.OrderLoader = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Building)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_BDevice)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // DS_Building
            // 
            this.DS_Building.DataSource = typeof(SYS_MODELS.Building);
            // 
            // DS_BDevice
            // 
            this.DS_BDevice.DataSource = typeof(SYS_MODELS.BeamCutDevice);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.DS_Building;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(57, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.DS_BDevice;
            this.listBox1.DisplayMember = "Name";
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(5, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(74, 457);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(84, 531);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(74, 64);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Building:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnGetChart);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.StopTime);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.StartTime);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(493, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(450, 88);
            this.panel5.TabIndex = 4;
            // 
            // btnGetChart
            // 
            this.btnGetChart.Location = new System.Drawing.Point(347, 10);
            this.btnGetChart.Name = "btnGetChart";
            this.btnGetChart.Size = new System.Drawing.Size(189, 23);
            this.btnGetChart.TabIndex = 4;
            this.btnGetChart.Text = "Get Bdevice Data";
            this.btnGetChart.UseVisualStyleBackColor = true;
            this.btnGetChart.Click += new System.EventHandler(this.btnGetChart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stop day:";
            // 
            // StopTime
            // 
            this.StopTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StopTime.Location = new System.Drawing.Point(210, 11);
            this.StopTime.Name = "StopTime";
            this.StopTime.Size = new System.Drawing.Size(69, 20);
            this.StopTime.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Start day:";
            // 
            // StartTime
            // 
            this.StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartTime.Location = new System.Drawing.Point(67, 11);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(69, 20);
            this.StartTime.TabIndex = 0;
            // 
            // StatisticLoader
            // 
            this.StatisticLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatisticLoader.Location = new System.Drawing.Point(493, 88);
            this.StatisticLoader.Name = "StatisticLoader";
            this.StatisticLoader.Padding = new System.Windows.Forms.Padding(5);
            this.StatisticLoader.Size = new System.Drawing.Size(450, 443);
            this.StatisticLoader.TabIndex = 5;
            // 
            // OrderLoader
            // 
            this.OrderLoader.Dock = System.Windows.Forms.DockStyle.Left;
            this.OrderLoader.Location = new System.Drawing.Point(84, 0);
            this.OrderLoader.Name = "OrderLoader";
            this.OrderLoader.Size = new System.Drawing.Size(409, 531);
            this.OrderLoader.TabIndex = 3;
            // 
            // BDeviceStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.StatisticLoader);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.OrderLoader);
            this.Controls.Add(this.panel1);
            this.Name = "BDeviceStatistic";
            this.Size = new System.Drawing.Size(943, 531);
            this.Load += new System.EventHandler(this.BDeviceStatistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Building)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_BDevice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource DS_Building;
        private System.Windows.Forms.BindingSource DS_BDevice;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnGetChart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker StopTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker StartTime;
        private System.Windows.Forms.Panel StatisticLoader;
        private System.Windows.Forms.Panel OrderLoader;
    }
}
