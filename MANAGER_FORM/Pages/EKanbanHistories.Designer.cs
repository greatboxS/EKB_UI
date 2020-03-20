namespace MANAGER_FORM.Pages
{
    partial class EKanbanHistories
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.HistoryFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTotalPrepareDay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTotalPrepareQty = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTotalPrepare = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(162, 525);
            this.panel1.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(5, 5);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(152, 515);
            this.treeView1.TabIndex = 4;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView_NodeMouseClick);
            // 
            // HistoryFlow
            // 
            this.HistoryFlow.AutoScroll = true;
            this.HistoryFlow.AutoSize = true;
            this.HistoryFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoryFlow.Location = new System.Drawing.Point(162, 43);
            this.HistoryFlow.Name = "HistoryFlow";
            this.HistoryFlow.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.HistoryFlow.Size = new System.Drawing.Size(898, 482);
            this.HistoryFlow.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.lbTotalPrepareDay);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbTotalPrepareQty);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbTotalPrepare);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(162, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 43);
            this.panel2.TabIndex = 5;
            // 
            // lbTotalPrepareDay
            // 
            this.lbTotalPrepareDay.Location = new System.Drawing.Point(482, 5);
            this.lbTotalPrepareDay.Name = "lbTotalPrepareDay";
            this.lbTotalPrepareDay.Size = new System.Drawing.Size(79, 13);
            this.lbTotalPrepareDay.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total preparing day:";
            // 
            // lbTotalPrepareQty
            // 
            this.lbTotalPrepareQty.Location = new System.Drawing.Point(303, 5);
            this.lbTotalPrepareQty.Name = "lbTotalPrepareQty";
            this.lbTotalPrepareQty.Size = new System.Drawing.Size(79, 13);
            this.lbTotalPrepareQty.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total preparing quantity:";
            // 
            // lbTotalPrepare
            // 
            this.lbTotalPrepare.Location = new System.Drawing.Point(91, 5);
            this.lbTotalPrepare.Name = "lbTotalPrepare";
            this.lbTotalPrepare.Size = new System.Drawing.Size(79, 13);
            this.lbTotalPrepare.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total prepared:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(637, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 34);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // EKanbanHistories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HistoryFlow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EKanbanHistories";
            this.Size = new System.Drawing.Size(1060, 525);
            this.Load += new System.EventHandler(this.EKanbanHistories_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.FlowLayoutPanel HistoryFlow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTotalPrepareDay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTotalPrepareQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTotalPrepare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
    }
}
