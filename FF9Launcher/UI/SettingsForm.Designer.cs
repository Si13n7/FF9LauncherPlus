namespace FF9LauncherPlus
{
    partial class SettingsForm
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
            this.FormPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.graphicsGroup = new System.Windows.Forms.GroupBox();
            this.caCheck = new System.Windows.Forms.CheckBox();
            this.caShiftTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.caStrength = new System.Windows.Forms.NumericUpDown();
            this.caStrengthLabel = new System.Windows.Forms.Label();
            this.caShiftXLabel = new System.Windows.Forms.Label();
            this.caShiftY = new System.Windows.Forms.NumericUpDown();
            this.caShiftYLabel = new System.Windows.Forms.Label();
            this.caShiftX = new System.Windows.Forms.NumericUpDown();
            this.smaaCheck = new System.Windows.Forms.CheckBox();
            this.lsCheck = new System.Windows.Forms.CheckBox();
            this.paCheck = new System.Windows.Forms.CheckBox();
            this.screenGroup = new System.Windows.Forms.GroupBox();
            this.screenTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.scrFull = new System.Windows.Forms.RadioButton();
            this.scrWnd = new System.Windows.Forms.RadioButton();
            this.setScrDir = new System.Windows.Forms.Button();
            this.globalTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.showFPS = new System.Windows.Forms.CheckBox();
            this.showStats = new System.Windows.Forms.CheckBox();
            this.showClock = new System.Windows.Forms.CheckBox();
            this.scrDir = new System.Windows.Forms.TextBox();
            this.scrDirLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.FormPanelBorder = new System.Windows.Forms.Label();
            this.FormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.graphicsGroup.SuspendLayout();
            this.caShiftTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caShiftY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caShiftX)).BeginInit();
            this.screenGroup.SuspendLayout();
            this.screenTableLayoutPanel.SuspendLayout();
            this.globalTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormPanel
            // 
            this.FormPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.FormPanel.BackgroundImage = global::FF9LauncherPlus.Properties.Resources.diagonal_pattern;
            this.FormPanel.Controls.Add(this.pictureBox1);
            this.FormPanel.Controls.Add(this.graphicsGroup);
            this.FormPanel.Controls.Add(this.screenGroup);
            this.FormPanel.Controls.Add(this.setScrDir);
            this.FormPanel.Controls.Add(this.globalTableLayoutPanel);
            this.FormPanel.Controls.Add(this.scrDir);
            this.FormPanel.Controls.Add(this.scrDirLabel);
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormPanel.Location = new System.Drawing.Point(0, 0);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(646, 350);
            this.FormPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FF9LauncherPlus.Properties.Resources.ff9_lili_render;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(443, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 338);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // graphicsGroup
            // 
            this.graphicsGroup.BackColor = System.Drawing.Color.Transparent;
            this.graphicsGroup.Controls.Add(this.caCheck);
            this.graphicsGroup.Controls.Add(this.caShiftTableLayoutPanel);
            this.graphicsGroup.Controls.Add(this.smaaCheck);
            this.graphicsGroup.Controls.Add(this.lsCheck);
            this.graphicsGroup.Controls.Add(this.paCheck);
            this.graphicsGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphicsGroup.ForeColor = System.Drawing.Color.Goldenrod;
            this.graphicsGroup.Location = new System.Drawing.Point(45, 80);
            this.graphicsGroup.Name = "graphicsGroup";
            this.graphicsGroup.Size = new System.Drawing.Size(393, 155);
            this.graphicsGroup.TabIndex = 1;
            this.graphicsGroup.TabStop = false;
            this.graphicsGroup.Text = "Graphics";
            // 
            // caCheck
            // 
            this.caCheck.AutoSize = true;
            this.caCheck.BackColor = System.Drawing.Color.Transparent;
            this.caCheck.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caCheck.ForeColor = System.Drawing.Color.Snow;
            this.caCheck.Location = new System.Drawing.Point(14, 23);
            this.caCheck.Name = "caCheck";
            this.caCheck.Size = new System.Drawing.Size(141, 18);
            this.caCheck.TabIndex = 0;
            this.caCheck.Text = "Chromatic Aberration";
            this.caCheck.UseVisualStyleBackColor = false;
            this.caCheck.CheckedChanged += new System.EventHandler(this.caCheck_CheckedChanged);
            // 
            // caShiftTableLayoutPanel
            // 
            this.caShiftTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.caShiftTableLayoutPanel.ColumnCount = 6;
            this.caShiftTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66583F));
            this.caShiftTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.6675F));
            this.caShiftTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.6675F));
            this.caShiftTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66583F));
            this.caShiftTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.caShiftTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.caShiftTableLayoutPanel.Controls.Add(this.caStrength, 5, 0);
            this.caShiftTableLayoutPanel.Controls.Add(this.caStrengthLabel, 4, 0);
            this.caShiftTableLayoutPanel.Controls.Add(this.caShiftXLabel, 0, 0);
            this.caShiftTableLayoutPanel.Controls.Add(this.caShiftY, 3, 0);
            this.caShiftTableLayoutPanel.Controls.Add(this.caShiftYLabel, 2, 0);
            this.caShiftTableLayoutPanel.Controls.Add(this.caShiftX, 1, 0);
            this.caShiftTableLayoutPanel.Location = new System.Drawing.Point(17, 41);
            this.caShiftTableLayoutPanel.Name = "caShiftTableLayoutPanel";
            this.caShiftTableLayoutPanel.RowCount = 1;
            this.caShiftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.caShiftTableLayoutPanel.Size = new System.Drawing.Size(360, 31);
            this.caShiftTableLayoutPanel.TabIndex = 1;
            // 
            // caStrength
            // 
            this.caStrength.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.caStrength.DecimalPlaces = 1;
            this.caStrength.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caStrength.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.caStrength.Location = new System.Drawing.Point(301, 5);
            this.caStrength.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.caStrength.Name = "caStrength";
            this.caStrength.Size = new System.Drawing.Size(55, 21);
            this.caStrength.TabIndex = 2;
            this.caStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.caStrength.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // caStrengthLabel
            // 
            this.caStrengthLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.caStrengthLabel.AutoSize = true;
            this.caStrengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.caStrengthLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caStrengthLabel.ForeColor = System.Drawing.Color.Snow;
            this.caStrengthLabel.Location = new System.Drawing.Point(242, 9);
            this.caStrengthLabel.Name = "caStrengthLabel";
            this.caStrengthLabel.Size = new System.Drawing.Size(53, 13);
            this.caStrengthLabel.TabIndex = 0;
            this.caStrengthLabel.Text = "Strength:";
            // 
            // caShiftXLabel
            // 
            this.caShiftXLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.caShiftXLabel.AutoSize = true;
            this.caShiftXLabel.BackColor = System.Drawing.Color.Transparent;
            this.caShiftXLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caShiftXLabel.ForeColor = System.Drawing.Color.Snow;
            this.caShiftXLabel.Location = new System.Drawing.Point(14, 9);
            this.caShiftXLabel.Name = "caShiftXLabel";
            this.caShiftXLabel.Size = new System.Drawing.Size(42, 13);
            this.caShiftXLabel.TabIndex = 0;
            this.caShiftXLabel.Text = "Shift X:";
            // 
            // caShiftY
            // 
            this.caShiftY.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.caShiftY.DecimalPlaces = 1;
            this.caShiftY.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caShiftY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.caShiftY.Location = new System.Drawing.Point(182, 5);
            this.caShiftY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.caShiftY.Name = "caShiftY";
            this.caShiftY.Size = new System.Drawing.Size(53, 21);
            this.caShiftY.TabIndex = 1;
            this.caShiftY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.caShiftY.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // caShiftYLabel
            // 
            this.caShiftYLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.caShiftYLabel.AutoSize = true;
            this.caShiftYLabel.BackColor = System.Drawing.Color.Transparent;
            this.caShiftYLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caShiftYLabel.ForeColor = System.Drawing.Color.Snow;
            this.caShiftYLabel.Location = new System.Drawing.Point(134, 9);
            this.caShiftYLabel.Name = "caShiftYLabel";
            this.caShiftYLabel.Size = new System.Drawing.Size(42, 13);
            this.caShiftYLabel.TabIndex = 0;
            this.caShiftYLabel.Text = "Shift Y:";
            // 
            // caShiftX
            // 
            this.caShiftX.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.caShiftX.DecimalPlaces = 1;
            this.caShiftX.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caShiftX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.caShiftX.Location = new System.Drawing.Point(62, 5);
            this.caShiftX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.caShiftX.Name = "caShiftX";
            this.caShiftX.Size = new System.Drawing.Size(54, 21);
            this.caShiftX.TabIndex = 0;
            this.caShiftX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.caShiftX.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            // 
            // smaaCheck
            // 
            this.smaaCheck.AutoSize = true;
            this.smaaCheck.BackColor = System.Drawing.Color.Transparent;
            this.smaaCheck.Checked = true;
            this.smaaCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.smaaCheck.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smaaCheck.ForeColor = System.Drawing.Color.Snow;
            this.smaaCheck.Location = new System.Drawing.Point(14, 122);
            this.smaaCheck.Name = "smaaCheck";
            this.smaaCheck.Size = new System.Drawing.Size(269, 18);
            this.smaaCheck.TabIndex = 4;
            this.smaaCheck.Text = "Enhanced Subpixel Morphological Antialiasing";
            this.smaaCheck.UseVisualStyleBackColor = false;
            // 
            // lsCheck
            // 
            this.lsCheck.AutoSize = true;
            this.lsCheck.BackColor = System.Drawing.Color.Transparent;
            this.lsCheck.Checked = true;
            this.lsCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lsCheck.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsCheck.ForeColor = System.Drawing.Color.Snow;
            this.lsCheck.Location = new System.Drawing.Point(14, 82);
            this.lsCheck.Name = "lsCheck";
            this.lsCheck.Size = new System.Drawing.Size(87, 18);
            this.lsCheck.TabIndex = 2;
            this.lsCheck.Text = "Sharpening";
            this.lsCheck.UseVisualStyleBackColor = false;
            // 
            // paCheck
            // 
            this.paCheck.AutoSize = true;
            this.paCheck.BackColor = System.Drawing.Color.Transparent;
            this.paCheck.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paCheck.ForeColor = System.Drawing.Color.Snow;
            this.paCheck.Location = new System.Drawing.Point(14, 102);
            this.paCheck.Name = "paCheck";
            this.paCheck.Size = new System.Drawing.Size(194, 18);
            this.paCheck.TabIndex = 3;
            this.paCheck.Text = "PlayStation Graphics Simulation";
            this.paCheck.UseVisualStyleBackColor = false;
            // 
            // screenGroup
            // 
            this.screenGroup.BackColor = System.Drawing.Color.Transparent;
            this.screenGroup.Controls.Add(this.screenTableLayoutPanel);
            this.screenGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenGroup.ForeColor = System.Drawing.Color.Goldenrod;
            this.screenGroup.Location = new System.Drawing.Point(45, 21);
            this.screenGroup.Name = "screenGroup";
            this.screenGroup.Size = new System.Drawing.Size(208, 53);
            this.screenGroup.TabIndex = 0;
            this.screenGroup.TabStop = false;
            this.screenGroup.Text = "Screen";
            // 
            // screenTableLayoutPanel
            // 
            this.screenTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.screenTableLayoutPanel.ColumnCount = 2;
            this.screenTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.screenTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.screenTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.screenTableLayoutPanel.Controls.Add(this.scrFull, 0, 0);
            this.screenTableLayoutPanel.Controls.Add(this.scrWnd, 1, 0);
            this.screenTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenTableLayoutPanel.Location = new System.Drawing.Point(3, 19);
            this.screenTableLayoutPanel.Name = "screenTableLayoutPanel";
            this.screenTableLayoutPanel.RowCount = 1;
            this.screenTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.screenTableLayoutPanel.Size = new System.Drawing.Size(202, 31);
            this.screenTableLayoutPanel.TabIndex = 0;
            // 
            // scrFull
            // 
            this.scrFull.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scrFull.AutoSize = true;
            this.scrFull.BackColor = System.Drawing.Color.Transparent;
            this.scrFull.Checked = true;
            this.scrFull.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrFull.ForeColor = System.Drawing.Color.Snow;
            this.scrFull.Location = new System.Drawing.Point(11, 6);
            this.scrFull.Name = "scrFull";
            this.scrFull.Size = new System.Drawing.Size(78, 18);
            this.scrFull.TabIndex = 0;
            this.scrFull.TabStop = true;
            this.scrFull.Text = "Fullscreen";
            this.scrFull.UseVisualStyleBackColor = false;
            // 
            // scrWnd
            // 
            this.scrWnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scrWnd.AutoSize = true;
            this.scrWnd.BackColor = System.Drawing.Color.Transparent;
            this.scrWnd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrWnd.ForeColor = System.Drawing.Color.Snow;
            this.scrWnd.Location = new System.Drawing.Point(116, 6);
            this.scrWnd.Name = "scrWnd";
            this.scrWnd.Size = new System.Drawing.Size(70, 18);
            this.scrWnd.TabIndex = 1;
            this.scrWnd.TabStop = true;
            this.scrWnd.Text = "Window";
            this.scrWnd.UseVisualStyleBackColor = false;
            // 
            // setScrDir
            // 
            this.setScrDir.BackColor = System.Drawing.SystemColors.Control;
            this.setScrDir.BackgroundImage = global::FF9LauncherPlus.Properties.Resources.folder_a_24;
            this.setScrDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.setScrDir.Location = new System.Drawing.Point(410, 256);
            this.setScrDir.Name = "setScrDir";
            this.setScrDir.Size = new System.Drawing.Size(23, 23);
            this.setScrDir.TabIndex = 4;
            this.setScrDir.UseVisualStyleBackColor = false;
            this.setScrDir.Click += new System.EventHandler(this.setScrDir_Click);
            // 
            // globalTableLayoutPanel
            // 
            this.globalTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.globalTableLayoutPanel.ColumnCount = 3;
            this.globalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.globalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.globalTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.globalTableLayoutPanel.Controls.Add(this.showFPS, 0, 0);
            this.globalTableLayoutPanel.Controls.Add(this.showStats, 2, 0);
            this.globalTableLayoutPanel.Controls.Add(this.showClock, 1, 0);
            this.globalTableLayoutPanel.Location = new System.Drawing.Point(40, 289);
            this.globalTableLayoutPanel.Name = "globalTableLayoutPanel";
            this.globalTableLayoutPanel.RowCount = 1;
            this.globalTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.globalTableLayoutPanel.Size = new System.Drawing.Size(404, 31);
            this.globalTableLayoutPanel.TabIndex = 5;
            // 
            // showFPS
            // 
            this.showFPS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showFPS.AutoSize = true;
            this.showFPS.BackColor = System.Drawing.Color.Transparent;
            this.showFPS.ForeColor = System.Drawing.Color.Snow;
            this.showFPS.Location = new System.Drawing.Point(30, 7);
            this.showFPS.Name = "showFPS";
            this.showFPS.Size = new System.Drawing.Size(73, 17);
            this.showFPS.TabIndex = 0;
            this.showFPS.Text = "Show FPS";
            this.showFPS.UseVisualStyleBackColor = false;
            // 
            // showStats
            // 
            this.showStats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showStats.AutoSize = true;
            this.showStats.BackColor = System.Drawing.Color.Transparent;
            this.showStats.ForeColor = System.Drawing.Color.Snow;
            this.showStats.Location = new System.Drawing.Point(287, 7);
            this.showStats.Name = "showStats";
            this.showStats.Size = new System.Drawing.Size(98, 17);
            this.showStats.TabIndex = 2;
            this.showStats.Text = "Show Statistics";
            this.showStats.UseVisualStyleBackColor = false;
            // 
            // showClock
            // 
            this.showClock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showClock.AutoSize = true;
            this.showClock.BackColor = System.Drawing.Color.Transparent;
            this.showClock.ForeColor = System.Drawing.Color.Snow;
            this.showClock.Location = new System.Drawing.Point(161, 7);
            this.showClock.Name = "showClock";
            this.showClock.Size = new System.Drawing.Size(80, 17);
            this.showClock.TabIndex = 1;
            this.showClock.Text = "Show Clock";
            this.showClock.UseVisualStyleBackColor = false;
            // 
            // scrDir
            // 
            this.scrDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scrDir.Location = new System.Drawing.Point(172, 257);
            this.scrDir.MaxLength = 255;
            this.scrDir.Name = "scrDir";
            this.scrDir.Size = new System.Drawing.Size(233, 21);
            this.scrDir.TabIndex = 3;
            this.scrDir.WordWrap = false;
            // 
            // scrDirLabel
            // 
            this.scrDirLabel.AutoSize = true;
            this.scrDirLabel.BackColor = System.Drawing.Color.Transparent;
            this.scrDirLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrDirLabel.ForeColor = System.Drawing.Color.Snow;
            this.scrDirLabel.Location = new System.Drawing.Point(45, 260);
            this.scrDirLabel.Name = "scrDirLabel";
            this.scrDirLabel.Size = new System.Drawing.Size(126, 14);
            this.scrDirLabel.TabIndex = 2;
            this.scrDirLabel.Text = "Screenshot Directory:";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveBtn.BackgroundImage = global::FF9LauncherPlus.Properties.Resources.btn_small;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.saveBtn.Location = new System.Drawing.Point(26, 371);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(274, 50);
            this.saveBtn.TabIndex = 100;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            this.saveBtn.MouseEnter += new System.EventHandler(this.saveBtn_MouseEnter);
            this.saveBtn.MouseLeave += new System.EventHandler(this.saveBtn_MouseLeave);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelBtn.BackgroundImage = global::FF9LauncherPlus.Properties.Resources.btn_small;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.cancelBtn.Location = new System.Drawing.Point(347, 371);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(274, 50);
            this.cancelBtn.TabIndex = 101;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseClick);
            this.cancelBtn.MouseEnter += new System.EventHandler(this.cancelBtn_MouseEnter);
            this.cancelBtn.MouseLeave += new System.EventHandler(this.cancelBtn_MouseLeave);
            // 
            // FormPanelBorder
            // 
            this.FormPanelBorder.BackColor = System.Drawing.Color.Black;
            this.FormPanelBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormPanelBorder.Location = new System.Drawing.Point(0, 350);
            this.FormPanelBorder.Name = "FormPanelBorder";
            this.FormPanelBorder.Size = new System.Drawing.Size(646, 3);
            this.FormPanelBorder.TabIndex = 3;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::FF9LauncherPlus.Properties.Resources.diagonal_pattern;
            this.ClientSize = new System.Drawing.Size(646, 442);
            this.Controls.Add(this.FormPanelBorder);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.FormPanel);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Final Fantasy XIII Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.FormPanel.ResumeLayout(false);
            this.FormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.graphicsGroup.ResumeLayout(false);
            this.graphicsGroup.PerformLayout();
            this.caShiftTableLayoutPanel.ResumeLayout(false);
            this.caShiftTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caShiftY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caShiftX)).EndInit();
            this.screenGroup.ResumeLayout(false);
            this.screenTableLayoutPanel.ResumeLayout(false);
            this.screenTableLayoutPanel.PerformLayout();
            this.globalTableLayoutPanel.ResumeLayout(false);
            this.globalTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormPanel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label FormPanelBorder;
        private System.Windows.Forms.Label scrDirLabel;
        private System.Windows.Forms.Button setScrDir;
        private System.Windows.Forms.TextBox scrDir;
        private System.Windows.Forms.CheckBox showClock;
        private System.Windows.Forms.CheckBox showFPS;
        private System.Windows.Forms.CheckBox showStats;
        private System.Windows.Forms.TableLayoutPanel globalTableLayoutPanel;
        private System.Windows.Forms.CheckBox caCheck;
        private System.Windows.Forms.NumericUpDown caShiftX;
        private System.Windows.Forms.Label caShiftXLabel;
        private System.Windows.Forms.TableLayoutPanel caShiftTableLayoutPanel;
        private System.Windows.Forms.NumericUpDown caShiftY;
        private System.Windows.Forms.Label caShiftYLabel;
        private System.Windows.Forms.CheckBox lsCheck;
        private System.Windows.Forms.Label caStrengthLabel;
        private System.Windows.Forms.NumericUpDown caStrength;
        private System.Windows.Forms.CheckBox smaaCheck;
        private System.Windows.Forms.CheckBox paCheck;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox graphicsGroup;
        private System.Windows.Forms.GroupBox screenGroup;
        private System.Windows.Forms.TableLayoutPanel screenTableLayoutPanel;
        private System.Windows.Forms.RadioButton scrWnd;
        private System.Windows.Forms.RadioButton scrFull;
    }
}