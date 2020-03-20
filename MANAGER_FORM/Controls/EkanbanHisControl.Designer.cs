namespace MANAGER_FORM.Controls
{
    partial class EkanbanHisControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DS_Interface = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbCartName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbTotalQty = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Interface)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_Interface, "PO", true));
            this.label2.Location = new System.Drawing.Point(46, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // DS_Interface
            // 
            this.DS_Interface.DataSource = typeof(SYS_MODELS.EKanbanInterface);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_Interface, "POqty", true));
            this.label3.Location = new System.Drawing.Point(78, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_Interface, "SequenceNo", true));
            this.label5.Location = new System.Drawing.Point(376, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sequence:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_Interface, "CartQty", true));
            this.label7.Location = new System.Drawing.Point(496, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Seq quantity:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(697, 9);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 16);
            this.lbStatus.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(635, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Status:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(88, 52);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(835, 127);
            this.dataGridView1.TabIndex = 11;
            // 
            // lbCartName
            // 
            this.lbCartName.AutoSize = true;
            this.lbCartName.Location = new System.Drawing.Point(10, 47);
            this.lbCartName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCartName.Name = "lbCartName";
            this.lbCartName.Size = new System.Drawing.Size(37, 16);
            this.lbCartName.TabIndex = 12;
            this.lbCartName.Text = "ADD";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(635, 25);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "Prepare quantity:";
            // 
            // lbTotalQty
            // 
            this.lbTotalQty.AutoSize = true;
            this.lbTotalQty.Location = new System.Drawing.Point(759, 25);
            this.lbTotalQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalQty.Name = "lbTotalQty";
            this.lbTotalQty.Size = new System.Drawing.Size(0, 16);
            this.lbTotalQty.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(155, 25);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "Production Line:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_Interface, "Line", true));
            this.label17.Location = new System.Drawing.Point(263, 25);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 16);
            this.label17.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbTotalQty);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.lbStatus);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 47);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbCartName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(5, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 127);
            this.panel2.TabIndex = 14;
            // 
            // EkanbanHisControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EkanbanHisControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(928, 184);
            this.Load += new System.EventHandler(this.EkanbanHisControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Interface)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource DS_Interface;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbCartName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbTotalQty;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
