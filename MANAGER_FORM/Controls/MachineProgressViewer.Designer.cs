namespace MANAGER_FORM.Controls
{
    partial class MachineProgressViewer
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.BIterfaceTab = new System.Windows.Forms.TabPage();
            this.MachineProgressLoader = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stopTime = new System.Windows.Forms.DateTimePicker();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.OrderTab = new System.Windows.Forms.TabPage();
            this.TabControl.SuspendLayout();
            this.BIterfaceTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.BIterfaceTab);
            this.TabControl.Controls.Add(this.OrderTab);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(3, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(434, 400);
            this.TabControl.TabIndex = 1;
            // 
            // BIterfaceTab
            // 
            this.BIterfaceTab.Controls.Add(this.MachineProgressLoader);
            this.BIterfaceTab.Controls.Add(this.panel1);
            this.BIterfaceTab.Location = new System.Drawing.Point(4, 22);
            this.BIterfaceTab.Name = "BIterfaceTab";
            this.BIterfaceTab.Padding = new System.Windows.Forms.Padding(3);
            this.BIterfaceTab.Size = new System.Drawing.Size(426, 374);
            this.BIterfaceTab.TabIndex = 0;
            this.BIterfaceTab.Text = "Machine Progress";
            this.BIterfaceTab.UseVisualStyleBackColor = true;
            // 
            // MachineProgressLoader
            // 
            this.MachineProgressLoader.AutoScroll = true;
            this.MachineProgressLoader.AutoSize = true;
            this.MachineProgressLoader.ColumnCount = 1;
            this.MachineProgressLoader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MachineProgressLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MachineProgressLoader.Location = new System.Drawing.Point(3, 34);
            this.MachineProgressLoader.Name = "MachineProgressLoader";
            this.MachineProgressLoader.RowCount = 1;
            this.MachineProgressLoader.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MachineProgressLoader.Size = new System.Drawing.Size(420, 337);
            this.MachineProgressLoader.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.stopTime);
            this.panel1.Controls.Add(this.startTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 31);
            this.panel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRefresh.Location = new System.Drawing.Point(308, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "End";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Begin";
            // 
            // stopTime
            // 
            this.stopTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.stopTime.Location = new System.Drawing.Point(188, 6);
            this.stopTime.Name = "stopTime";
            this.stopTime.Size = new System.Drawing.Size(87, 20);
            this.stopTime.TabIndex = 1;
            // 
            // startTime
            // 
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startTime.Location = new System.Drawing.Point(38, 6);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(87, 20);
            this.startTime.TabIndex = 0;
            // 
            // OrderTab
            // 
            this.OrderTab.Location = new System.Drawing.Point(4, 22);
            this.OrderTab.Name = "OrderTab";
            this.OrderTab.Padding = new System.Windows.Forms.Padding(3);
            this.OrderTab.Size = new System.Drawing.Size(426, 374);
            this.OrderTab.TabIndex = 1;
            this.OrderTab.Text = "Order";
            this.OrderTab.UseVisualStyleBackColor = true;
            // 
            // MachineProgressViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabControl);
            this.Name = "MachineProgressViewer";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Size = new System.Drawing.Size(440, 400);
            this.TabControl.ResumeLayout(false);
            this.BIterfaceTab.ResumeLayout(false);
            this.BIterfaceTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage BIterfaceTab;
        private System.Windows.Forms.TabPage OrderTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel MachineProgressLoader;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker stopTime;
        private System.Windows.Forms.DateTimePicker startTime;
    }
}
