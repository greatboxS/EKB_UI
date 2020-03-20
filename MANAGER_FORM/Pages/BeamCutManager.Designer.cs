namespace MANAGER_FORM.Pages
{
    partial class BeamCutManager
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tab1 = new System.Windows.Forms.TabPage();
            this.Tab2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tab1);
            this.tabControl1.Controls.Add(this.Tab2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(962, 529);
            this.tabControl1.TabIndex = 0;
            // 
            // Tab1
            // 
            this.Tab1.Location = new System.Drawing.Point(4, 22);
            this.Tab1.Name = "Tab1";
            this.Tab1.Padding = new System.Windows.Forms.Padding(3);
            this.Tab1.Size = new System.Drawing.Size(954, 503);
            this.Tab1.TabIndex = 0;
            this.Tab1.Text = "Statistic";
            this.Tab1.UseVisualStyleBackColor = true;
            // 
            // Tab2
            // 
            this.Tab2.Location = new System.Drawing.Point(4, 22);
            this.Tab2.Name = "Tab2";
            this.Tab2.Padding = new System.Windows.Forms.Padding(3);
            this.Tab2.Size = new System.Drawing.Size(954, 503);
            this.Tab2.TabIndex = 1;
            this.Tab2.Text = "Order";
            this.Tab2.UseVisualStyleBackColor = true;
            // 
            // BeamCutManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "BeamCutManager";
            this.Size = new System.Drawing.Size(962, 529);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tab1;
        private System.Windows.Forms.TabPage Tab2;
    }
}
