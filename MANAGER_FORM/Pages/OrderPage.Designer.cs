namespace MANAGER_FORM.Pages
{
    partial class OrderPage
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
            this.cbxBuilding = new System.Windows.Forms.ComboBox();
            this.DS_Building = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxScheduleClass = new System.Windows.Forms.ComboBox();
            this.DS_ScheduleClass = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxLine = new System.Windows.Forms.ComboBox();
            this.DS_Line = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbBDevice = new System.Windows.Forms.ListBox();
            this.DS_BDevice = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbSchedule = new System.Windows.Forms.ListBox();
            this.DS_Schedule = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lbBeamMachine = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbxOrderDate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lvComponent = new System.Windows.Forms.ListView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbArticle = new System.Windows.Forms.Label();
            this.lbModelName = new System.Windows.Forms.Label();
            this.lbModelNumber = new System.Windows.Forms.Label();
            this.lbPoNumber = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.OrderLoader = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTotalAddPO = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.DS_BDeviceOrders = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Building)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_ScheduleClass)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Line)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_BDevice)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Schedule)).BeginInit();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_BDeviceOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxBuilding
            // 
            this.cbxBuilding.DataSource = this.DS_Building;
            this.cbxBuilding.DisplayMember = "Name";
            this.cbxBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBuilding.FormattingEnabled = true;
            this.cbxBuilding.Location = new System.Drawing.Point(346, 16);
            this.cbxBuilding.Name = "cbxBuilding";
            this.cbxBuilding.Size = new System.Drawing.Size(70, 21);
            this.cbxBuilding.TabIndex = 0;
            this.cbxBuilding.SelectedIndexChanged += new System.EventHandler(this.cbxBuilding_SelectedIndexChanged);
            // 
            // DS_Building
            // 
            this.DS_Building.DataSource = typeof(SYS_MODELS.Building);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Building";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Schedule";
            // 
            // cbxScheduleClass
            // 
            this.cbxScheduleClass.DataSource = this.DS_ScheduleClass;
            this.cbxScheduleClass.DisplayMember = "Name";
            this.cbxScheduleClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxScheduleClass.FormattingEnabled = true;
            this.cbxScheduleClass.Location = new System.Drawing.Point(181, 16);
            this.cbxScheduleClass.Name = "cbxScheduleClass";
            this.cbxScheduleClass.Size = new System.Drawing.Size(99, 21);
            this.cbxScheduleClass.TabIndex = 2;
            // 
            // DS_ScheduleClass
            // 
            this.DS_ScheduleClass.DataSource = typeof(SYS_MODELS.ScheduleClass);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbxLine);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbxBuilding);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxScheduleClass);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 42);
            this.panel1.TabIndex = 5;
            // 
            // cbxLine
            // 
            this.cbxLine.DataSource = this.DS_Line;
            this.cbxLine.DisplayMember = "LineName";
            this.cbxLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLine.FormattingEnabled = true;
            this.cbxLine.Location = new System.Drawing.Point(503, 16);
            this.cbxLine.Name = "cbxLine";
            this.cbxLine.Size = new System.Drawing.Size(70, 21);
            this.cbxLine.TabIndex = 6;
            this.cbxLine.SelectedIndexChanged += new System.EventHandler(this.cbxLine_SelectedIndexChanged);
            // 
            // DS_Line
            // 
            this.DS_Line.DataSource = typeof(SYS_MODELS.ProductionLine);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Line";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(775, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(610, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 27);
            this.textBox1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbBDevice);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(5, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(72, 465);
            this.panel2.TabIndex = 6;
            // 
            // lbBDevice
            // 
            this.lbBDevice.DataSource = this.DS_BDevice;
            this.lbBDevice.DisplayMember = "Name";
            this.lbBDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBDevice.FormattingEnabled = true;
            this.lbBDevice.Location = new System.Drawing.Point(0, 0);
            this.lbBDevice.Name = "lbBDevice";
            this.lbBDevice.Size = new System.Drawing.Size(72, 465);
            this.lbBDevice.TabIndex = 7;
            this.lbBDevice.SelectedIndexChanged += new System.EventHandler(this.lbBDevice_SelectedIndexChanged);
            // 
            // DS_BDevice
            // 
            this.DS_BDevice.DataSource = typeof(SYS_MODELS.BeamCutDevice);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbSchedule);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(781, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(155, 465);
            this.panel4.TabIndex = 7;
            // 
            // lbSchedule
            // 
            this.lbSchedule.DataSource = this.DS_Schedule;
            this.lbSchedule.DisplayMember = "PoNumber";
            this.lbSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSchedule.FormattingEnabled = true;
            this.lbSchedule.Location = new System.Drawing.Point(0, 0);
            this.lbSchedule.Name = "lbSchedule";
            this.lbSchedule.Size = new System.Drawing.Size(155, 465);
            this.lbSchedule.TabIndex = 0;
            this.lbSchedule.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbSchedule_MouseClick);
            this.lbSchedule.SelectedIndexChanged += new System.EventHandler(this.lbSchedule_SelectedIndexChanged);
            // 
            // DS_Schedule
            // 
            this.DS_Schedule.DataSource = typeof(SYS_MODELS.Schedule);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Selected Beam cut:";
            // 
            // lbBeamMachine
            // 
            this.lbBeamMachine.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_BDevice, "Name", true));
            this.lbBeamMachine.Location = new System.Drawing.Point(109, 6);
            this.lbBeamMachine.Name = "lbBeamMachine";
            this.lbBeamMachine.Size = new System.Drawing.Size(100, 13);
            this.lbBeamMachine.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbxOrderDate);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.lbBeamMachine);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(77, 47);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(704, 55);
            this.panel5.TabIndex = 10;
            // 
            // cbxOrderDate
            // 
            this.cbxOrderDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrderDate.FormattingEnabled = true;
            this.cbxOrderDate.Location = new System.Drawing.Point(72, 26);
            this.cbxOrderDate.Name = "cbxOrderDate";
            this.cbxOrderDate.Size = new System.Drawing.Size(181, 21);
            this.cbxOrderDate.TabIndex = 11;
            this.cbxOrderDate.SelectedIndexChanged += new System.EventHandler(this.cbxOrderDate_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Order date:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.panel8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(77, 102);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(704, 410);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.lvComponent);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(513, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(188, 404);
            this.panel8.TabIndex = 2;
            // 
            // lvComponent
            // 
            this.lvComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvComponent.Location = new System.Drawing.Point(0, 123);
            this.lvComponent.Name = "lvComponent";
            this.lvComponent.Size = new System.Drawing.Size(186, 279);
            this.lvComponent.TabIndex = 1;
            this.lvComponent.UseCompatibleStateImageBehavior = false;
            this.lvComponent.View = System.Windows.Forms.View.List;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lbQuantity);
            this.panel9.Controls.Add(this.lbArticle);
            this.panel9.Controls.Add(this.lbModelName);
            this.panel9.Controls.Add(this.lbModelNumber);
            this.panel9.Controls.Add(this.lbPoNumber);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(186, 123);
            this.panel9.TabIndex = 0;
            // 
            // lbQuantity
            // 
            this.lbQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_Schedule, "Quantity", true));
            this.lbQuantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbQuantity.Location = new System.Drawing.Point(0, 88);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(186, 22);
            this.lbQuantity.TabIndex = 8;
            this.lbQuantity.Text = "lbQuantity";
            this.lbQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbArticle
            // 
            this.lbArticle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_Schedule, "Article", true));
            this.lbArticle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbArticle.Location = new System.Drawing.Point(0, 66);
            this.lbArticle.Name = "lbArticle";
            this.lbArticle.Size = new System.Drawing.Size(186, 22);
            this.lbArticle.TabIndex = 7;
            this.lbArticle.Text = "lbArticle";
            this.lbArticle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbModelName
            // 
            this.lbModelName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_Schedule, "ModelName", true));
            this.lbModelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbModelName.Location = new System.Drawing.Point(0, 44);
            this.lbModelName.Name = "lbModelName";
            this.lbModelName.Size = new System.Drawing.Size(186, 22);
            this.lbModelName.TabIndex = 6;
            this.lbModelName.Text = "lbModelName";
            this.lbModelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbModelNumber
            // 
            this.lbModelNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_Schedule, "Model", true));
            this.lbModelNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbModelNumber.Location = new System.Drawing.Point(0, 22);
            this.lbModelNumber.Name = "lbModelNumber";
            this.lbModelNumber.Size = new System.Drawing.Size(186, 22);
            this.lbModelNumber.TabIndex = 5;
            this.lbModelNumber.Text = "lbModelNumber";
            this.lbModelNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPoNumber
            // 
            this.lbPoNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_Schedule, "PoNumber", true));
            this.lbPoNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPoNumber.Location = new System.Drawing.Point(0, 0);
            this.lbPoNumber.Name = "lbPoNumber";
            this.lbPoNumber.Size = new System.Drawing.Size(186, 22);
            this.lbPoNumber.TabIndex = 4;
            this.lbPoNumber.Text = "lbPoNumber";
            this.lbPoNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.OrderLoader);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel6.Size = new System.Drawing.Size(444, 404);
            this.panel6.TabIndex = 0;
            // 
            // OrderLoader
            // 
            this.OrderLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderLoader.Location = new System.Drawing.Point(5, 44);
            this.OrderLoader.Name = "OrderLoader";
            this.OrderLoader.Size = new System.Drawing.Size(437, 358);
            this.OrderLoader.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbTotalAddPO);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(5, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(437, 44);
            this.panel3.TabIndex = 1;
            // 
            // lbTotalAddPO
            // 
            this.lbTotalAddPO.Location = new System.Drawing.Point(100, 12);
            this.lbTotalAddPO.Name = "lbTotalAddPO";
            this.lbTotalAddPO.Size = new System.Drawing.Size(87, 13);
            this.lbTotalAddPO.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total adding PO:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnAddOrder, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(453, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(54, 404);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddOrder.Location = new System.Drawing.Point(3, 175);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(48, 54);
            this.btnAddOrder.TabIndex = 0;
            this.btnAddOrder.Text = "<<";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // DS_BDeviceOrders
            // 
            this.DS_BDeviceOrders.DataSource = typeof(SYS_MODELS.BDeviceOrder);
            // 
            // DS
            // 
            this.DS.DataSource = typeof(SYS_MODELS.BeamCutDevice);
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "OrderPage";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(941, 517);
            this.Load += new System.EventHandler(this.OrderPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Building)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_ScheduleClass)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Line)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DS_BDevice)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Schedule)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DS_BDeviceOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxBuilding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxScheduleClass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lbBDevice;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox lbSchedule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbBeamMachine;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTotalAddPO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvComponent;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbArticle;
        private System.Windows.Forms.Label lbModelName;
        private System.Windows.Forms.Label lbModelNumber;
        private System.Windows.Forms.Label lbPoNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.BindingSource DS_ScheduleClass;
        private System.Windows.Forms.BindingSource DS_Building;
        private System.Windows.Forms.ComboBox cbxLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource DS_BDevice;
        private System.Windows.Forms.BindingSource DS;
        private System.Windows.Forms.BindingSource DS_Schedule;
        private System.Windows.Forms.BindingSource DS_Line;
        private System.Windows.Forms.BindingSource DS_BDeviceOrders;
        private System.Windows.Forms.ComboBox cbxOrderDate;
        private System.Windows.Forms.Panel OrderLoader;
    }
}
