namespace FFTicker
{
    partial class FrmControls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControls));
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnlSpace1 = new System.Windows.Forms.Panel();
            this.pnlSpaceControls = new System.Windows.Forms.Panel();
            this.btnSnapshotsStart = new System.Windows.Forms.Button();
            this.btnSnapshotsStop = new System.Windows.Forms.Button();
            this.pnlControls.SuspendLayout();
            this.pnlSpaceControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.pnlSpaceControls);
            this.pnlControls.Controls.Add(this.pnlSpace1);
            this.pnlControls.Controls.Add(this.btnSettings);
            this.pnlControls.Location = new System.Drawing.Point(10, 1);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(54, 24);
            this.pnlControls.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(0, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(24, 24);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pnlSpace1
            // 
            this.pnlSpace1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSpace1.Location = new System.Drawing.Point(24, 0);
            this.pnlSpace1.Name = "pnlSpace1";
            this.pnlSpace1.Size = new System.Drawing.Size(5, 24);
            this.pnlSpace1.TabIndex = 3;
            // 
            // pnlSpaceControls
            // 
            this.pnlSpaceControls.Controls.Add(this.btnSnapshotsStop);
            this.pnlSpaceControls.Controls.Add(this.btnSnapshotsStart);
            this.pnlSpaceControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSpaceControls.Location = new System.Drawing.Point(29, 0);
            this.pnlSpaceControls.Name = "pnlSpaceControls";
            this.pnlSpaceControls.Size = new System.Drawing.Size(25, 24);
            this.pnlSpaceControls.TabIndex = 4;
            // 
            // btnSnapshotsStart
            // 
            this.btnSnapshotsStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSnapshotsStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSnapshotsStart.FlatAppearance.BorderSize = 0;
            this.btnSnapshotsStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnapshotsStart.Image = ((System.Drawing.Image)(resources.GetObject("btnSnapshotsStart.Image")));
            this.btnSnapshotsStart.Location = new System.Drawing.Point(0, 0);
            this.btnSnapshotsStart.Name = "btnSnapshotsStart";
            this.btnSnapshotsStart.Size = new System.Drawing.Size(24, 24);
            this.btnSnapshotsStart.TabIndex = 2;
            this.btnSnapshotsStart.UseVisualStyleBackColor = true;
            this.btnSnapshotsStart.Click += new System.EventHandler(this.btnSnapshotsStart_Click);
            // 
            // btnSnapshotsStop
            // 
            this.btnSnapshotsStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSnapshotsStop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSnapshotsStop.FlatAppearance.BorderSize = 0;
            this.btnSnapshotsStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnapshotsStop.Image = ((System.Drawing.Image)(resources.GetObject("btnSnapshotsStop.Image")));
            this.btnSnapshotsStop.Location = new System.Drawing.Point(24, 0);
            this.btnSnapshotsStop.Name = "btnSnapshotsStop";
            this.btnSnapshotsStop.Size = new System.Drawing.Size(24, 24);
            this.btnSnapshotsStop.TabIndex = 3;
            this.btnSnapshotsStop.UseVisualStyleBackColor = true;
            this.btnSnapshotsStop.Click += new System.EventHandler(this.btnSnapshotsStop_Click);
            // 
            // FrmControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::FFTicker.Properties.Resources.handle_10_17;
            this.ClientSize = new System.Drawing.Size(233, 226);
            this.Controls.Add(this.pnlControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmControls";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrontFabric - Ticker";
            this.TopMost = true;
            this.pnlControls.ResumeLayout(false);
            this.pnlSpaceControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel pnlSpaceControls;
        private System.Windows.Forms.Button btnSnapshotsStop;
        private System.Windows.Forms.Button btnSnapshotsStart;
        private System.Windows.Forms.Panel pnlSpace1;
    }
}