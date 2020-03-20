namespace PRINT_FORM
{
    partial class PRT_FORM
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Print = new System.Windows.Forms.Button();
            this.PrintLoader = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1209, 36);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Print);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1109, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 36);
            this.panel3.TabIndex = 1;
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(13, 6);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 23);
            this.btn_Print.TabIndex = 0;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.Btn_Print_Click);
            // 
            // PrintLoader
            // 
            this.PrintLoader.AutoScroll = true;
            this.PrintLoader.AutoSize = true;
            this.PrintLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrintLoader.Location = new System.Drawing.Point(0, 0);
            this.PrintLoader.Name = "PrintLoader";
            this.PrintLoader.Size = new System.Drawing.Size(1209, 457);
            this.PrintLoader.TabIndex = 2;
            // 
            // PRT_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 493);
            this.Controls.Add(this.PrintLoader);
            this.Controls.Add(this.panel2);
            this.Name = "PRT_FORM";
            this.Text = "Prints";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel PrintLoader;
    }
}

