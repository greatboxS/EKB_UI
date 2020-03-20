namespace MANAGER_FORM.Controls
{
    partial class EkanbanItem
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
            this.lbName = new System.Windows.Forms.Label();
            this.Online = new System.Windows.Forms.Label();
            this.ScreenOff = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Blue;
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(76, 24);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Online
            // 
            this.Online.BackColor = System.Drawing.Color.Red;
            this.Online.Location = new System.Drawing.Point(72, 4);
            this.Online.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Online.Name = "Online";
            this.Online.Size = new System.Drawing.Size(19, 16);
            this.Online.TabIndex = 1;
            // 
            // ScreenOff
            // 
            this.ScreenOff.AutoSize = true;
            this.ScreenOff.Dock = System.Windows.Forms.DockStyle.Right;
            this.ScreenOff.Location = new System.Drawing.Point(99, 0);
            this.ScreenOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ScreenOff.Name = "ScreenOff";
            this.ScreenOff.Size = new System.Drawing.Size(87, 24);
            this.ScreenOff.TabIndex = 2;
            this.ScreenOff.Text = "Screen off";
            this.ScreenOff.UseVisualStyleBackColor = true;
            this.ScreenOff.CheckStateChanged += new System.EventHandler(this.ScreenOff_CheckStateChanged);
            // 
            // EkanbanItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ScreenOff);
            this.Controls.Add(this.Online);
            this.Controls.Add(this.lbName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EkanbanItem";
            this.Size = new System.Drawing.Size(186, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label Online;
        private System.Windows.Forms.CheckBox ScreenOff;
    }
}
