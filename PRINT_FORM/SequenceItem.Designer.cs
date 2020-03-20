namespace PRINT_FORM
{
    partial class SequenceItem
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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ItemLoader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_No = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Delete.Location = new System.Drawing.Point(3, 67);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(30, 26);
            this.btn_Delete.TabIndex = 0;
            this.btn_Delete.Text = "X";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Delete, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(745, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(36, 162);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ItemLoader
            // 
            this.ItemLoader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemLoader.Location = new System.Drawing.Point(41, 0);
            this.ItemLoader.Name = "ItemLoader";
            this.ItemLoader.Size = new System.Drawing.Size(704, 162);
            this.ItemLoader.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_No);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(41, 162);
            this.panel1.TabIndex = 0;
            // 
            // lb_No
            // 
            this.lb_No.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_No.Location = new System.Drawing.Point(0, 0);
            this.lb_No.Name = "lb_No";
            this.lb_No.Size = new System.Drawing.Size(41, 162);
            this.lb_No.TabIndex = 0;
            this.lb_No.Text = "#";
            this.lb_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SequenceItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemLoader);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "SequenceItem";
            this.Size = new System.Drawing.Size(781, 162);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel ItemLoader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_No;
    }
}
