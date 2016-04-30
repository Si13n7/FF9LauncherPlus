namespace FF9LauncherPlus
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.creditsBtn = new System.Windows.Forms.Panel();
            this.playBtnPan = new System.Windows.Forms.Panel();
            this.playBtnTx = new System.Windows.Forms.Label();
            this.cfgBtnPan = new System.Windows.Forms.Panel();
            this.cfgBtnTx = new System.Windows.Forms.Label();
            this.closeBtnPan = new System.Windows.Forms.Panel();
            this.minBtnPan = new System.Windows.Forms.Panel();
            this.cfgPanel = new System.Windows.Forms.Panel();
            this.CfgFormCloseCheck = new System.Windows.Forms.Timer(this.components);
            this.PlayBw = new System.ComponentModel.BackgroundWorker();
            this.ProfileName = new System.Windows.Forms.Label();
            this.playBtnPan.SuspendLayout();
            this.cfgBtnPan.SuspendLayout();
            this.SuspendLayout();
            // 
            // creditsBtn
            // 
            this.creditsBtn.BackColor = System.Drawing.Color.Transparent;
            this.creditsBtn.Location = new System.Drawing.Point(423, 467);
            this.creditsBtn.Name = "creditsBtn";
            this.creditsBtn.Size = new System.Drawing.Size(85, 22);
            this.creditsBtn.TabIndex = 4;
            this.creditsBtn.Click += new System.EventHandler(this.creditsBtn_Click);
            // 
            // playBtnPan
            // 
            this.playBtnPan.BackgroundImage = global::FF9LauncherPlus.Properties.Resources.btn_big;
            this.playBtnPan.Controls.Add(this.playBtnTx);
            this.playBtnPan.Location = new System.Drawing.Point(329, 270);
            this.playBtnPan.Name = "playBtnPan";
            this.playBtnPan.Size = new System.Drawing.Size(274, 70);
            this.playBtnPan.TabIndex = 5;
            this.playBtnPan.Click += new System.EventHandler(this.playBtnPan_Click);
            this.playBtnPan.MouseEnter += new System.EventHandler(this.playBtnPan_MouseEnter);
            this.playBtnPan.MouseLeave += new System.EventHandler(this.playBtnPan_MouseLeave);
            // 
            // playBtnTx
            // 
            this.playBtnTx.BackColor = System.Drawing.Color.Transparent;
            this.playBtnTx.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.playBtnTx.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.playBtnTx.ForeColor = System.Drawing.Color.Gainsboro;
            this.playBtnTx.Location = new System.Drawing.Point(0, 15);
            this.playBtnTx.Name = "playBtnTx";
            this.playBtnTx.Size = new System.Drawing.Size(274, 55);
            this.playBtnTx.TabIndex = 0;
            this.playBtnTx.Text = "Play";
            this.playBtnTx.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.playBtnTx.Click += new System.EventHandler(this.playBtnPan_Click);
            this.playBtnTx.MouseEnter += new System.EventHandler(this.playBtnPan_MouseEnter);
            this.playBtnTx.MouseLeave += new System.EventHandler(this.playBtnPan_MouseLeave);
            // 
            // cfgBtnPan
            // 
            this.cfgBtnPan.BackgroundImage = global::FF9LauncherPlus.Properties.Resources.btn_small;
            this.cfgBtnPan.Controls.Add(this.cfgBtnTx);
            this.cfgBtnPan.Location = new System.Drawing.Point(329, 342);
            this.cfgBtnPan.Name = "cfgBtnPan";
            this.cfgBtnPan.Size = new System.Drawing.Size(274, 50);
            this.cfgBtnPan.TabIndex = 6;
            this.cfgBtnPan.Click += new System.EventHandler(this.cfgBtnPan_Click);
            this.cfgBtnPan.MouseEnter += new System.EventHandler(this.cfgBtnPan_MouseEnter);
            this.cfgBtnPan.MouseLeave += new System.EventHandler(this.cfgBtnPan_MouseLeave);
            // 
            // cfgBtnTx
            // 
            this.cfgBtnTx.BackColor = System.Drawing.Color.Transparent;
            this.cfgBtnTx.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cfgBtnTx.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.cfgBtnTx.ForeColor = System.Drawing.Color.Gainsboro;
            this.cfgBtnTx.Location = new System.Drawing.Point(0, 10);
            this.cfgBtnTx.Name = "cfgBtnTx";
            this.cfgBtnTx.Size = new System.Drawing.Size(274, 40);
            this.cfgBtnTx.TabIndex = 0;
            this.cfgBtnTx.Text = "Settings";
            this.cfgBtnTx.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cfgBtnTx.Click += new System.EventHandler(this.cfgBtnPan_Click);
            this.cfgBtnTx.MouseEnter += new System.EventHandler(this.cfgBtnPan_MouseEnter);
            this.cfgBtnTx.MouseLeave += new System.EventHandler(this.cfgBtnPan_MouseLeave);
            // 
            // closeBtnPan
            // 
            this.closeBtnPan.BackgroundImage = global::FF9LauncherPlus.Properties.Resources.btn_close;
            this.closeBtnPan.Location = new System.Drawing.Point(631, 0);
            this.closeBtnPan.Name = "closeBtnPan";
            this.closeBtnPan.Size = new System.Drawing.Size(19, 24);
            this.closeBtnPan.TabIndex = 7;
            this.closeBtnPan.Click += new System.EventHandler(this.closeBtnPan_Click);
            this.closeBtnPan.MouseEnter += new System.EventHandler(this.closeBtnPan_MouseEnter);
            this.closeBtnPan.MouseLeave += new System.EventHandler(this.closeBtnPan_MouseLeave);
            // 
            // minBtnPan
            // 
            this.minBtnPan.BackgroundImage = global::FF9LauncherPlus.Properties.Resources.btn_min;
            this.minBtnPan.Location = new System.Drawing.Point(612, 0);
            this.minBtnPan.Name = "minBtnPan";
            this.minBtnPan.Size = new System.Drawing.Size(19, 24);
            this.minBtnPan.TabIndex = 8;
            this.minBtnPan.Click += new System.EventHandler(this.minBtnPan_Click);
            this.minBtnPan.MouseEnter += new System.EventHandler(this.minBtnPan_MouseEnter);
            this.minBtnPan.MouseLeave += new System.EventHandler(this.minBtnPan_MouseLeave);
            // 
            // cfgPanel
            // 
            this.cfgPanel.BackColor = System.Drawing.Color.Black;
            this.cfgPanel.Location = new System.Drawing.Point(1, 467);
            this.cfgPanel.Name = "cfgPanel";
            this.cfgPanel.Size = new System.Drawing.Size(30, 33);
            this.cfgPanel.TabIndex = 9;
            this.cfgPanel.Visible = false;
            // 
            // CfgFormCloseCheck
            // 
            this.CfgFormCloseCheck.Enabled = true;
            this.CfgFormCloseCheck.Interval = 10;
            this.CfgFormCloseCheck.Tick += new System.EventHandler(this.CfgFormCloseCheck_Tick);
            // 
            // PlayBw
            // 
            this.PlayBw.WorkerSupportsCancellation = true;
            this.PlayBw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PlayBw_DoWork);
            this.PlayBw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.PlayBw_RunWorkerCompleted);
            // 
            // ProfileName
            // 
            this.ProfileName.BackColor = System.Drawing.Color.Transparent;
            this.ProfileName.ForeColor = System.Drawing.Color.White;
            this.ProfileName.Location = new System.Drawing.Point(398, 29);
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.Size = new System.Drawing.Size(216, 23);
            this.ProfileName.TabIndex = 10;
            this.ProfileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ProfileName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::FF9LauncherPlus.Properties.Resources.ff9_launcher_back;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.ProfileName);
            this.Controls.Add(this.cfgPanel);
            this.Controls.Add(this.minBtnPan);
            this.Controls.Add(this.closeBtnPan);
            this.Controls.Add(this.cfgBtnPan);
            this.Controls.Add(this.playBtnPan);
            this.Controls.Add(this.creditsBtn);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FF9 Launcher Plus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.Move += new System.EventHandler(this.MainForm_Move);
            this.playBtnPan.ResumeLayout(false);
            this.cfgBtnPan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel creditsBtn;
        private System.Windows.Forms.Panel playBtnPan;
        private System.Windows.Forms.Label playBtnTx;
        private System.Windows.Forms.Panel cfgBtnPan;
        private System.Windows.Forms.Label cfgBtnTx;
        private System.Windows.Forms.Panel closeBtnPan;
        private System.Windows.Forms.Panel minBtnPan;
        private System.Windows.Forms.Panel cfgPanel;
        private System.Windows.Forms.Timer CfgFormCloseCheck;
        private System.ComponentModel.BackgroundWorker PlayBw;
        private System.Windows.Forms.Label ProfileName;
    }
}