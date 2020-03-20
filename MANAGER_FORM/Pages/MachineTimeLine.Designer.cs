namespace MANAGER_FORM.Pages
{
    partial class MachineTimeLine
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotalCut = new System.Windows.Forms.Label();
            this.lbTotalCutTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLastUpdate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbBegin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbLastUpdate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbBegin);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbTotalCutTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbTotalCut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 27);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(829, 300);
            this.panel2.TabIndex = 1;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(3, 9);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(0, 13);
            this.lbDate.TabIndex = 0;
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total cut qty:";
            // 
            // lbTotalCut
            // 
            this.lbTotalCut.AutoSize = true;
            this.lbTotalCut.Location = new System.Drawing.Point(632, 9);
            this.lbTotalCut.Name = "lbTotalCut";
            this.lbTotalCut.Size = new System.Drawing.Size(0, 13);
            this.lbTotalCut.TabIndex = 2;
            // 
            // lbTotalCutTime
            // 
            this.lbTotalCutTime.AutoSize = true;
            this.lbTotalCutTime.Location = new System.Drawing.Point(762, 9);
            this.lbTotalCutTime.Name = "lbTotalCutTime";
            this.lbTotalCutTime.Size = new System.Drawing.Size(0, 13);
            this.lbTotalCutTime.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(683, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total cut time:";
            // 
            // lbLastUpdate
            // 
            this.lbLastUpdate.AutoSize = true;
            this.lbLastUpdate.Location = new System.Drawing.Point(421, 9);
            this.lbLastUpdate.Name = "lbLastUpdate";
            this.lbLastUpdate.Size = new System.Drawing.Size(0, 13);
            this.lbLastUpdate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last update:";
            // 
            // lbBegin
            // 
            this.lbBegin.AutoSize = true;
            this.lbBegin.Location = new System.Drawing.Point(229, 9);
            this.lbBegin.Name = "lbBegin";
            this.lbBegin.Size = new System.Drawing.Size(0, 13);
            this.lbBegin.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Begin time:";
            // 
            // MachineTimeLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 327);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MachineTimeLine";
            this.Text = "MachineTimeLine";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTotalCutTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotalCut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLastUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbBegin;
        private System.Windows.Forms.Label label6;
    }
}