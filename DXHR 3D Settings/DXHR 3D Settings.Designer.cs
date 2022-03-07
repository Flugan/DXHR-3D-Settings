namespace DXHR_3D_Settings
{
    partial class DXHR3D
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.strengthTracker = new System.Windows.Forms.TrackBar();
            this.planeTracker = new System.Windows.Forms.TrackBar();
            this.l_strength = new System.Windows.Forms.Label();
            this.l_plane = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l_monSize = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.l_nvDepth = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.l_dxDepth = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_monSize = new System.Windows.Forms.TextBox();
            this.monButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.strengthTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeTracker)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "3D Strength:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "3D Plane:";
            // 
            // strengthTracker
            // 
            this.strengthTracker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.strengthTracker.Location = new System.Drawing.Point(16, 29);
            this.strengthTracker.Maximum = 200;
            this.strengthTracker.Name = "strengthTracker";
            this.strengthTracker.Size = new System.Drawing.Size(710, 45);
            this.strengthTracker.TabIndex = 2;
            this.strengthTracker.TickFrequency = 25;
            this.strengthTracker.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.strengthTracker.Value = 25;
            this.strengthTracker.Scroll += new System.EventHandler(this.strengthTracker_Scroll);
            // 
            // planeTracker
            // 
            this.planeTracker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.planeTracker.Location = new System.Drawing.Point(16, 93);
            this.planeTracker.Maximum = 125;
            this.planeTracker.Name = "planeTracker";
            this.planeTracker.Size = new System.Drawing.Size(710, 45);
            this.planeTracker.TabIndex = 3;
            this.planeTracker.TickFrequency = 25;
            this.planeTracker.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.planeTracker.Value = 25;
            this.planeTracker.Scroll += new System.EventHandler(this.planeTracker_Scroll);
            // 
            // l_strength
            // 
            this.l_strength.AutoSize = true;
            this.l_strength.Location = new System.Drawing.Point(89, 12);
            this.l_strength.Name = "l_strength";
            this.l_strength.Size = new System.Drawing.Size(0, 13);
            this.l_strength.TabIndex = 4;
            // 
            // l_plane
            // 
            this.l_plane.AutoSize = true;
            this.l_plane.Location = new System.Drawing.Point(76, 77);
            this.l_plane.Name = "l_plane";
            this.l_plane.Size = new System.Drawing.Size(0, 13);
            this.l_plane.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(563, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Monitor Size:";
            // 
            // l_monSize
            // 
            this.l_monSize.AutoSize = true;
            this.l_monSize.Location = new System.Drawing.Point(644, 12);
            this.l_monSize.Name = "l_monSize";
            this.l_monSize.Size = new System.Drawing.Size(0, 13);
            this.l_monSize.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nvidia Depth:";
            // 
            // l_nvDepth
            // 
            this.l_nvDepth.AutoSize = true;
            this.l_nvDepth.Location = new System.Drawing.Point(243, 12);
            this.l_nvDepth.Name = "l_nvDepth";
            this.l_nvDepth.Size = new System.Drawing.Size(0, 13);
            this.l_nvDepth.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(327, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "DXHR Depth:";
            // 
            // l_dxDepth
            // 
            this.l_dxDepth.AutoSize = true;
            this.l_dxDepth.Location = new System.Drawing.Point(411, 12);
            this.l_dxDepth.Name = "l_dxDepth";
            this.l_dxDepth.Size = new System.Drawing.Size(0, 13);
            this.l_dxDepth.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Actual monitor size:";
            // 
            // tb_monSize
            // 
            this.tb_monSize.Location = new System.Drawing.Point(138, 133);
            this.tb_monSize.Name = "tb_monSize";
            this.tb_monSize.Size = new System.Drawing.Size(62, 20);
            this.tb_monSize.TabIndex = 13;
            // 
            // monButton
            // 
            this.monButton.Location = new System.Drawing.Point(207, 133);
            this.monButton.Name = "monButton";
            this.monButton.Size = new System.Drawing.Size(55, 23);
            this.monButton.TabIndex = 14;
            this.monButton.Text = "Apply";
            this.monButton.UseVisualStyleBackColor = true;
            this.monButton.Click += new System.EventHandler(this.monButton_Click);
            // 
            // DXHR3D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 173);
            this.Controls.Add(this.monButton);
            this.Controls.Add(this.tb_monSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.l_dxDepth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.l_nvDepth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.l_monSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l_plane);
            this.Controls.Add(this.l_strength);
            this.Controls.Add(this.planeTracker);
            this.Controls.Add(this.strengthTracker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DXHR3D";
            this.Text = "DXHR 3D Settings";
            this.Load += new System.EventHandler(this.DXHR3D_Load);
            ((System.ComponentModel.ISupportInitialize)(this.strengthTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeTracker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar strengthTracker;
        private System.Windows.Forms.TrackBar planeTracker;
        private System.Windows.Forms.Label l_strength;
        private System.Windows.Forms.Label l_plane;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_monSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l_nvDepth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label l_dxDepth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_monSize;
        private System.Windows.Forms.Button monButton;
    }
}

