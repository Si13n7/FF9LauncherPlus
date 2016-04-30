using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace FF9LauncherPlus
{
    public partial class MainForm : Form
    {
        /*------------------------------.
        | ::     Main Functions      :: |
        '------------------------------*/

        public MainForm()
        {
            InitializeComponent();
            Icon = Properties.Resources.ff9_logo;
            cfgPanel.Visible = false;
            cfgPanel.Location = new Point(1, 56);
            cfgPanel.Size = new Size(650, 444);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SilDev.Ini.File(Application.StartupPath, "Settings.ini");
            if (string.IsNullOrWhiteSpace(ProfileName.Text))
            {
                try
                {
                    string SteamPath = string.Empty;
                    if (SilDev.Reg.SubKeyExist("HKLM\\SOFTWARE\\Valve\\Steam"))
                        SteamPath = SilDev.Reg.ReadValue("HKLM\\SOFTWARE\\Valve\\Steam", "InstallPath");
                    if (Directory.Exists(SteamPath))
                    {
                        string SteamProfile = Path.Combine(SteamPath, "config\\loginusers.vdf");
                        if (File.Exists(SteamProfile))
                        {
                            foreach (string line in File.ReadLines(SteamProfile))
                            {
                                bool found = false;
                                foreach (string split in line.Split('\"'))
                                {
                                    if (!string.IsNullOrWhiteSpace(split))
                                    {
                                        if (split.ToLower() == "personaname")
                                        {
                                            found = true;
                                            continue;
                                        }
                                        if (found)
                                        {
                                            ProfileName.Text = split.Trim();
                                            break;
                                        }
                                    }
                                }
                                if (found)
                                    break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    SilDev.Log.Debug(ex);
                }
            }
            if (string.IsNullOrWhiteSpace(ProfileName.Text))
                ProfileName.Text = "Zidane";
            try
            {
                if (!Directory.Exists(Main.AssetsDir) || Directory.Exists(Main.AssetsDir) && Directory.GetFiles(Main.AssetsDir, "*", SearchOption.AllDirectories).Length < 21)
                {
                    string shaderTmp = $"{Main.AssetsDir}.tmp";
                    if (File.Exists(shaderTmp))
                        File.Delete(shaderTmp);
                    SilDev.Resource.ExtractConvert(Properties.Resources._FF9_Launcher_Plus, shaderTmp);
                    if (Directory.Exists(Main.AssetsDir))
                    {
                        SilDev.Data.SetAttributes(Main.AssetsDir, FileAttributes.Normal);
                        Directory.Delete(Main.AssetsDir, true);
                    }
                    SilDev.Packer.UnzipFile(shaderTmp, Main.AssetsDir);
                    SilDev.Data.SetAttributes(Main.AssetsDir, FileAttributes.Hidden);
                }
                Main.InstallShaders();
            }
            catch (Exception ex)
            {
                SilDev.Log.Debug(ex);
            }
            try
            {
                foreach (Control c in new Control[] { playBtnTx, cfgBtnTx })
                {
                    if (Main.FontFamily != null)
                        c.Font = new Font(Main.FontFamily, c.Font.Size);
                }
            }
            catch (Exception ex)
            {
                SilDev.Log.Debug(ex);
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.SizeAll;
            SilDev.WinAPI.MoveWindowAtMouseButtonLeft(this, e);
            Cursor = Cursors.Default;
        }

        private void MainForm_Move(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
                if (f.Name != Name)
                    f.Location = new Point(1, 0);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PlayBw.IsBusy)
            {
                SilDev.MsgBox.Show($"Please close the game before exiting '{Text}'.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => Main.UninstallShaders();


        /*------------------------------.
        | ::     Play Functions      :: |
        '------------------------------*/

        private void playBtnPan_MouseEnter(object sender, EventArgs e) => playBtnPan.BackgroundImage = Properties.Resources.btn_big_mo_13;

        private void playBtnPan_MouseLeave(object sender, EventArgs e) => playBtnPan.BackgroundImage = Properties.Resources.btn_big;

        private void playBtnPan_Click(object sender, EventArgs e)
        {
            Size size = Main.RenderSize;
            Main.SetConfigValue(Main.SettingsKey.magnifyEndPixelWidth, size.Width.ToString());
            Main.SetConfigValue(Main.SettingsKey.magnifyEndPixelHeight, size.Height.ToString());
            int start = Main.RenderPixelStart;
            Main.SetConfigValue(Main.SettingsKey.magnifyStartPixelWidth, start.ToString());
            Main.WriteSettings();
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name != Name)
                    f.Close();
            }
            WindowState = FormWindowState.Minimized;
            PlayBw.RunWorkerAsync();
        }

        private void PlayBw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                int pid = SilDev.Run.App(new ProcessStartInfo()
                {
                    Arguments = $"-runbylauncher -single-instance -screen-width {Main.ScreenSize.Width} -screen-height {Main.ScreenSize.Height} -screen-fullscreen {(SilDev.Ini.ReadBoolean("Settings", "Windowed") ? 0 : 1)}",
                    FileName = Main.GameExePath,
                    WorkingDirectory = Application.StartupPath
                }, 0);
            }
            catch (Exception ex)
            {
                SilDev.Log.Debug(ex);
                e.Cancel = true;
            }
        }

        private void PlayBw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) => Application.Exit();


        /*------------------------------.
        | ::      Settings Form      :: |
        '------------------------------*/

        private Form cfgForm = new SettingsForm();

        private void cfgBtnPan_MouseEnter(object sender, EventArgs e) => cfgBtnPan.BackgroundImage = Properties.Resources.btn_small_mo_13;

        private void cfgBtnPan_MouseLeave(object sender, EventArgs e) => cfgBtnPan.BackgroundImage = Properties.Resources.btn_small;

        private void cfgBtnPan_Click(object sender, EventArgs e)
        {
            try
            {
                cfgForm = new SettingsForm();
                cfgForm.Location = new Point(1, 0);
                cfgForm.TopLevel = false;
                cfgForm.TopMost = true;
                cfgForm.Show();

                playBtnPan.Visible = false;
                playBtnTx.Visible = false;
                cfgBtnPan.Visible = false;
                cfgBtnTx.Visible = false;
                creditsBtn.Visible = false;

                cfgPanel.Controls.Add(cfgForm);
                cfgPanel.Visible = true;

                CfgFormCloseCheck.Enabled = true;
            }
            catch (Exception ex)
            {
                SilDev.Log.Debug(ex);
            }
        }

        private void CfgFormCloseCheck_Tick(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                IsOpen = (f.Name == cfgForm.Name);
                if (IsOpen)
                    break;
            }
            if (!IsOpen)
            {
                cfgPanel.Visible = false;

                playBtnPan.Visible = true;
                playBtnTx.Visible = true;
                cfgBtnPan.Visible = true;
                cfgBtnTx.Visible = true;
                creditsBtn.Visible = true;

                CfgFormCloseCheck.Enabled = false;
            }
        }


        /*------------------------------.
        | ::     Minimize Button     :: |
        '------------------------------*/

        private void minBtnPan_MouseEnter(object sender, EventArgs e) => minBtnPan.BackgroundImage = Properties.Resources.btn_min_mo_13;

        private void minBtnPan_MouseLeave(object sender, EventArgs e) => minBtnPan.BackgroundImage = Properties.Resources.btn_min;

        private void minBtnPan_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;


        /*------------------------------.
        | ::      Close Button       :: |
        '------------------------------*/

        private void closeBtnPan_MouseEnter(object sender, EventArgs e) => closeBtnPan.BackgroundImage = Properties.Resources.btn_close_mo_13;

        private void closeBtnPan_MouseLeave(object sender, EventArgs e) => closeBtnPan.BackgroundImage = Properties.Resources.btn_close;

        private void closeBtnPan_Click(object sender, EventArgs e) => Application.Exit();


        /*------------------------------.
        | ::     Credits Button      :: |
        '------------------------------*/

        private void creditsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"{Text} [Version: {Application.ProductVersion}]\r\nCopyright (C) 2016 Si13n7 Developments (R), Roy Schroedel\r\n\r\nWould you like to visit 'www.si13n7.com'?", "About", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    Process.Start("http://www.si13n7.com/");
            }
            catch (Exception ex)
            {
                SilDev.Log.Debug(ex);
            }
        }
    }
}
