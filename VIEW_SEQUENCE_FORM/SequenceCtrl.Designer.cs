namespace VIEW_SEQUENCE_FORM
{
    partial class SequenceCtrl
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
            this.LoaderPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.txtUpdateTime = new System.Windows.Forms.TextBox();
            this.txProductionLine = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ds_schedule = new System.Windows.Forms.BindingSource(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_schedule)).BeginInit();
            this.SuspendLayout();
            // 
            // LoaderPanel
            // 
            this.LoaderPanel.AutoScroll = true;
            this.LoaderPanel.AutoSize = true;
            this.LoaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LoaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoaderPanel.Location = new System.Drawing.Point(0, 56);
            this.LoaderPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoaderPanel.Name = "LoaderPanel";
            this.LoaderPanel.Size = new System.Drawing.Size(823, 336);
            this.LoaderPanel.TabIndex = 3;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.HeaderPanel.Controls.Add(this.txtUpdateTime);
            this.HeaderPanel.Controls.Add(this.txProductionLine);
            this.HeaderPanel.Controls.Add(this.label7);
            this.HeaderPanel.Controls.Add(this.label6);
            this.HeaderPanel.Controls.Add(this.textBox5);
            this.HeaderPanel.Controls.Add(this.textBox4);
            this.HeaderPanel.Controls.Add(this.label5);
            this.HeaderPanel.Controls.Add(this.textBox3);
            this.HeaderPanel.Controls.Add(this.label4);
            this.HeaderPanel.Controls.Add(this.textBox2);
            this.HeaderPanel.Controls.Add(this.label3);
            this.HeaderPanel.Controls.Add(this.textBox1);
            this.HeaderPanel.Controls.Add(this.label2);
            this.HeaderPanel.Controls.Add(this.label1);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(4);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(823, 56);
            this.HeaderPanel.TabIndex = 2;
            // 
            // txtUpdateTime
            // 
            this.txtUpdateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateTime.Location = new System.Drawing.Point(636, 25);
            this.txtUpdateTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUpdateTime.Name = "txtUpdateTime";
            this.txtUpdateTime.Size = new System.Drawing.Size(179, 22);
            this.txtUpdateTime.TabIndex = 4;
            // 
            // txProductionLine
            // 
            this.txProductionLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txProductionLine.Location = new System.Drawing.Point(515, 4);
            this.txProductionLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txProductionLine.Name = "txProductionLine";
            this.txProductionLine.Size = new System.Drawing.Size(98, 22);
            this.txProductionLine.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(633, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Update Time (Cập nhật) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Line:";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_schedule, "Article", true));
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(515, 30);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(98, 22);
            this.textBox5.TabIndex = 6;
            // 
            // ds_schedule
            // 
            this.ds_schedule.DataSource = typeof(SYS_MODELS.Schedule);
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_schedule, "Quantity", true));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(382, 5);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(71, 22);
            this.textBox4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Article:";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_schedule, "ModelName", true));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(244, 30);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 22);
            this.textBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "MName:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_schedule, "Model", true));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(84, 30);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(98, 22);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds_schedule, "PoNumber", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Blue;
            this.textBox1.Location = new System.Drawing.Point(133, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Order:";
            // 
            // SequenceCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LoaderPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "SequenceCtrl";
            this.Size = new System.Drawing.Size(823, 392);
            this.Load += new System.EventHandler(this.SequenceCtrl_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_schedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource ds_schedule;
        private System.Windows.Forms.FlowLayoutPanel LoaderPanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.TextBox txtUpdateTime;
        private System.Windows.Forms.TextBox txProductionLine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
