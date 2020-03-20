namespace MANAGER_FORM
{
    partial class MANG_FORM
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.EkanbanContainerPn = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DS_Building = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPrepareQty = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.LoaderPanel = new System.Windows.Forms.Panel();
            this.DS_EkanbanDevice = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Building)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_EkanbanDevice)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.EkanbanContainerPn);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(218, 572);
            this.panel1.TabIndex = 1;
            // 
            // EkanbanContainerPn
            // 
            this.EkanbanContainerPn.AutoScroll = true;
            this.EkanbanContainerPn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EkanbanContainerPn.BackColor = System.Drawing.Color.White;
            this.EkanbanContainerPn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EkanbanContainerPn.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.EkanbanContainerPn.Location = new System.Drawing.Point(5, 79);
            this.EkanbanContainerPn.Name = "EkanbanContainerPn";
            this.EkanbanContainerPn.Size = new System.Drawing.Size(208, 488);
            this.EkanbanContainerPn.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(208, 74);
            this.panel4.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.DS_Building;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DS_Building
            // 
            this.DS_Building.DataSource = typeof(SYS_MODELS.Building);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Online EKanban";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnPrepareQty);
            this.panel2.Controls.Add(this.btnHistory);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(218, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(988, 42);
            this.panel2.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(726, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 22);
            this.button4.TabIndex = 0;
            this.button4.Text = "Storage ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(553, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 22);
            this.button3.TabIndex = 0;
            this.button3.Text = "Beam cut";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPrepareQty
            // 
            this.btnPrepareQty.Location = new System.Drawing.Point(379, 12);
            this.btnPrepareQty.Name = "btnPrepareQty";
            this.btnPrepareQty.Size = new System.Drawing.Size(141, 22);
            this.btnPrepareQty.TabIndex = 0;
            this.btnPrepareQty.Text = "Prepare quantity";
            this.btnPrepareQty.UseVisualStyleBackColor = true;
            this.btnPrepareQty.Click += new System.EventHandler(this.btnPrepareQty_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(212, 12);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(141, 22);
            this.btnHistory.TabIndex = 0;
            this.btnHistory.Text = "EKanban histories";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // LoaderPanel
            // 
            this.LoaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoaderPanel.Location = new System.Drawing.Point(218, 42);
            this.LoaderPanel.Name = "LoaderPanel";
            this.LoaderPanel.Padding = new System.Windows.Forms.Padding(5);
            this.LoaderPanel.Size = new System.Drawing.Size(988, 530);
            this.LoaderPanel.TabIndex = 3;
            // 
            // DS_EkanbanDevice
            // 
            this.DS_EkanbanDevice.DataSource = typeof(SYS_MODELS.EKanbanDevice);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(5, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MANG_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 572);
            this.Controls.Add(this.LoaderPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MANG_FORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MANG_FORM_FormClosing);
            this.Load += new System.EventHandler(this.MANG_FORM_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Building)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_EkanbanDevice)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel LoaderPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnPrepareQty;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource DS_Building;
        private System.Windows.Forms.BindingSource DS_EkanbanDevice;
        private System.Windows.Forms.FlowLayoutPanel EkanbanContainerPn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

