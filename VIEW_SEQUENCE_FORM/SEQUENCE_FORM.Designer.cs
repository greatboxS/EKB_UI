namespace VIEW_SEQUENCE_FORM
{
    partial class SEQUENCE_FORM
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Prints = new System.Windows.Forms.ToolStripMenuItem();
            this.SequenceLoader = new System.Windows.Forms.FlowLayoutPanel();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.Menu.Size = new System.Drawing.Size(1218, 24);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Prints});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // Prints
            // 
            this.Prints.Name = "Prints";
            this.Prints.Size = new System.Drawing.Size(104, 22);
            this.Prints.Text = "Prints";
            this.Prints.Click += new System.EventHandler(this.Prints_Click);
            // 
            // SequenceLoader
            // 
            this.SequenceLoader.AutoScroll = true;
            this.SequenceLoader.AutoSize = true;
            this.SequenceLoader.BackColor = System.Drawing.Color.White;
            this.SequenceLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SequenceLoader.Location = new System.Drawing.Point(0, 24);
            this.SequenceLoader.Name = "SequenceLoader";
            this.SequenceLoader.Size = new System.Drawing.Size(1218, 575);
            this.SequenceLoader.TabIndex = 2;
            this.SequenceLoader.Paint += new System.Windows.Forms.PaintEventHandler(this.SequenceLoader_Paint);
            // 
            // SEQUENCE_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 599);
            this.Controls.Add(this.SequenceLoader);
            this.Controls.Add(this.Menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SEQUENCE_FORM";
            this.Text = "Sequences";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private new System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Prints;
        private System.Windows.Forms.FlowLayoutPanel SequenceLoader;
    }
}

