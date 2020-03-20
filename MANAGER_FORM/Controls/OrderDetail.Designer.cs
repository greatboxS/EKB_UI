namespace MANAGER_FORM.Controls
{
    partial class OrderDetail
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
            this.BMachineLoader = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbTotalQty = new System.Windows.Forms.Label();
            this.lbTotalCut = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbBmachineOrder = new System.Windows.Forms.ListBox();
            this.DS_BDeviceOrders = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_BDeviceOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // BMachineLoader
            // 
            this.BMachineLoader.AutoScroll = true;
            this.BMachineLoader.AutoSize = true;
            this.BMachineLoader.ColumnCount = 1;
            this.BMachineLoader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BMachineLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BMachineLoader.Location = new System.Drawing.Point(115, 55);
            this.BMachineLoader.Name = "BMachineLoader";
            this.BMachineLoader.Padding = new System.Windows.Forms.Padding(5);
            this.BMachineLoader.RowCount = 1;
            this.BMachineLoader.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.BMachineLoader.Size = new System.Drawing.Size(280, 258);
            this.BMachineLoader.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.lbTotalQty);
            this.panel7.Controls.Add(this.lbTotalCut);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.ForeColor = System.Drawing.Color.Blue;
            this.panel7.Location = new System.Drawing.Point(115, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(280, 55);
            this.panel7.TabIndex = 7;
            // 
            // lbTotalQty
            // 
            this.lbTotalQty.AutoSize = true;
            this.lbTotalQty.Location = new System.Drawing.Point(77, 20);
            this.lbTotalQty.Name = "lbTotalQty";
            this.lbTotalQty.Size = new System.Drawing.Size(0, 13);
            this.lbTotalQty.TabIndex = 4;
            // 
            // lbTotalCut
            // 
            this.lbTotalCut.AutoSize = true;
            this.lbTotalCut.Location = new System.Drawing.Point(77, 37);
            this.lbTotalCut.Name = "lbTotalCut";
            this.lbTotalCut.Size = new System.Drawing.Size(0, 13);
            this.lbTotalCut.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Total Cut Qty:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Po Qty:";
            // 
            // lbBmachineOrder
            // 
            this.lbBmachineOrder.DataSource = this.DS_BDeviceOrders;
            this.lbBmachineOrder.DisplayMember = "PoNumber";
            this.lbBmachineOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbBmachineOrder.FormattingEnabled = true;
            this.lbBmachineOrder.Location = new System.Drawing.Point(0, 0);
            this.lbBmachineOrder.Name = "lbBmachineOrder";
            this.lbBmachineOrder.Size = new System.Drawing.Size(115, 313);
            this.lbBmachineOrder.TabIndex = 5;
            this.lbBmachineOrder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbBmachineOrder_MouseClick);
            // 
            // DS_BDeviceOrders
            // 
            this.DS_BDeviceOrders.DataSource = typeof(SYS_MODELS.BDeviceOrder);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Po number:";
            // 
            // OrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BMachineLoader);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.lbBmachineOrder);
            this.Name = "OrderDetail";
            this.Size = new System.Drawing.Size(395, 313);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_BDeviceOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BMachineLoader;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbTotalQty;
        private System.Windows.Forms.Label lbTotalCut;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbBmachineOrder;
        private System.Windows.Forms.BindingSource DS_BDeviceOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
