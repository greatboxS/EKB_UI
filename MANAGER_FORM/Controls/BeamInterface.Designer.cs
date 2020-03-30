namespace MANAGER_FORM.Controls
{
    partial class BeamInterface
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
            this.lbStartTime = new System.Windows.Forms.Label();
            this.DS_Interface = new System.Windows.Forms.BindingSource(this.components);
            this.lbStopTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPoNumber = new System.Windows.Forms.Label();
            this.DS_Po = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lbPoQty = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbLine = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbStartQty = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbStopQty = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTotalQty = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbCutQty = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPlace = new System.Windows.Forms.Label();
            this.lbComponent = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbTotalPoCutQty = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Interface)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Po)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(42, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start time:";
            // 
            // lbStartTime
            // 
            this.lbStartTime.AutoSize = true;
            this.lbStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_Interface, "StartCutTime", true));
            this.lbStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartTime.Location = new System.Drawing.Point(94, 2);
            this.lbStartTime.Name = "lbStartTime";
            this.lbStartTime.Size = new System.Drawing.Size(71, 13);
            this.lbStartTime.TabIndex = 1;
            this.lbStartTime.Text = "lbStartTime";
            // 
            // DS_Interface
            // 
            this.DS_Interface.DataSource = typeof(SYS_MODELS.BeamCutInterface);
            // 
            // lbStopTime
            // 
            this.lbStopTime.AutoSize = true;
            this.lbStopTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_Interface, "StopCutTime", true));
            this.lbStopTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStopTime.Location = new System.Drawing.Point(94, 15);
            this.lbStopTime.Name = "lbStopTime";
            this.lbStopTime.Size = new System.Drawing.Size(70, 13);
            this.lbStopTime.TabIndex = 3;
            this.lbStopTime.Text = "lbStopTime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(42, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Stop time:";
            // 
            // lbPoNumber
            // 
            this.lbPoNumber.AutoSize = true;
            this.lbPoNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_Po, "PoNumber", true));
            this.lbPoNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoNumber.Location = new System.Drawing.Point(102, 36);
            this.lbPoNumber.Name = "lbPoNumber";
            this.lbPoNumber.Size = new System.Drawing.Size(75, 13);
            this.lbPoNumber.TabIndex = 5;
            this.lbPoNumber.Text = "lbPoNumber";
            // 
            // DS_Po
            // 
            this.DS_Po.DataSource = typeof(SYS_MODELS.Schedule);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(42, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Po Number:";
            // 
            // lbPoQty
            // 
            this.lbPoQty.AutoSize = true;
            this.lbPoQty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_Po, "Quantity", true));
            this.lbPoQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoQty.Location = new System.Drawing.Point(236, 36);
            this.lbPoQty.Name = "lbPoQty";
            this.lbPoQty.Size = new System.Drawing.Size(51, 13);
            this.lbPoQty.TabIndex = 7;
            this.lbPoQty.Text = "lbPoQty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(197, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Po Qty:";
            // 
            // lbLine
            // 
            this.lbLine.AutoSize = true;
            this.lbLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLine.Location = new System.Drawing.Point(314, 36);
            this.lbLine.Name = "lbLine";
            this.lbLine.Size = new System.Drawing.Size(41, 13);
            this.lbLine.TabIndex = 9;
            this.lbLine.Text = "lbLine";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(287, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Line:";
            // 
            // lbStartQty
            // 
            this.lbStartQty.AutoSize = true;
            this.lbStartQty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_Interface, "StartSeqNo", true));
            this.lbStartQty.Location = new System.Drawing.Point(94, 69);
            this.lbStartQty.Name = "lbStartQty";
            this.lbStartQty.Size = new System.Drawing.Size(53, 13);
            this.lbStartQty.TabIndex = 11;
            this.lbStartQty.Text = "lbStartQty";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Start Seq:";
            // 
            // lbStopQty
            // 
            this.lbStopQty.AutoSize = true;
            this.lbStopQty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_Interface, "StopSeqNo", true));
            this.lbStopQty.Location = new System.Drawing.Point(187, 69);
            this.lbStopQty.Name = "lbStopQty";
            this.lbStopQty.Size = new System.Drawing.Size(53, 13);
            this.lbStopQty.TabIndex = 13;
            this.lbStopQty.Text = "lbStopQty";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(135, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Stop Seq:";
            // 
            // lbTotalQty
            // 
            this.lbTotalQty.AutoSize = true;
            this.lbTotalQty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_Interface, "TotalSelectedQty", true));
            this.lbTotalQty.Location = new System.Drawing.Point(298, 69);
            this.lbTotalQty.Name = "lbTotalQty";
            this.lbTotalQty.Size = new System.Drawing.Size(55, 13);
            this.lbTotalQty.TabIndex = 15;
            this.lbTotalQty.Text = "lbTotalQty";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(228, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Total quantity:";
            // 
            // lbCutQty
            // 
            this.lbCutQty.AutoSize = true;
            this.lbCutQty.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_Interface, "CuttingQty", true));
            this.lbCutQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCutQty.ForeColor = System.Drawing.Color.Navy;
            this.lbCutQty.Location = new System.Drawing.Point(102, 88);
            this.lbCutQty.Name = "lbCutQty";
            this.lbCutQty.Size = new System.Drawing.Size(55, 13);
            this.lbCutQty.TabIndex = 17;
            this.lbCutQty.Text = "lbCutQty";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(42, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Current Qty:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(42, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Finish:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DS_Interface, "Finish", true));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(81, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lbPlace);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(41, 113);
            this.panel1.TabIndex = 22;
            // 
            // lbPlace
            // 
            this.lbPlace.AutoSize = true;
            this.lbPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlace.ForeColor = System.Drawing.Color.Navy;
            this.lbPlace.Location = new System.Drawing.Point(7, 26);
            this.lbPlace.Name = "lbPlace";
            this.lbPlace.Size = new System.Drawing.Size(16, 16);
            this.lbPlace.TabIndex = 1;
            this.lbPlace.Text = "1";
            // 
            // lbComponent
            // 
            this.lbComponent.AutoSize = true;
            this.lbComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComponent.Location = new System.Drawing.Point(109, 51);
            this.lbComponent.Name = "lbComponent";
            this.lbComponent.Size = new System.Drawing.Size(0, 13);
            this.lbComponent.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(42, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Component:";
            // 
            // lbTotalPoCutQty
            // 
            this.lbTotalPoCutQty.AutoSize = true;
            this.lbTotalPoCutQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPoCutQty.ForeColor = System.Drawing.Color.Navy;
            this.lbTotalPoCutQty.Location = new System.Drawing.Point(308, 51);
            this.lbTotalPoCutQty.Name = "lbTotalPoCutQty";
            this.lbTotalPoCutQty.Size = new System.Drawing.Size(48, 13);
            this.lbTotalPoCutQty.TabIndex = 26;
            this.lbTotalPoCutQty.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(239, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Total cut qty:";
            // 
            // BeamInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbTotalPoCutQty);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbComponent);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbCutQty);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbTotalQty);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbStopQty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbStartQty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbLine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbPoQty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbPoNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbStopTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbStartTime);
            this.Controls.Add(this.label1);
            this.Name = "BeamInterface";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(369, 115);
            ((System.ComponentModel.ISupportInitialize)(this.DS_Interface)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Po)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbStartTime;
        private System.Windows.Forms.Label lbStopTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPoNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPoQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbLine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbStartQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbStopQty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTotalQty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbCutQty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource DS_Interface;
        private System.Windows.Forms.BindingSource DS_Po;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbPlace;
        private System.Windows.Forms.Label lbComponent;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbTotalPoCutQty;
        private System.Windows.Forms.Label label13;
    }
}
