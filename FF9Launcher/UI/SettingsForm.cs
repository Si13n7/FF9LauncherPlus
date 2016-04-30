using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace FF9LauncherPlus
{
    public partial class SettingsForm : Form
    {
        /*------------------------------.
        | ::     Main Functions      :: |
        '------------------------------*/

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in new Control[] { screenGroup, graphicsGroup, saveBtn, cancelBtn })
                {
                    if (Main.FontFamily != null)
                        c.Font = new Font(Main.FontFamily, c.Font.Size);
                }
            }
            catch (Exception ex)
            {
                SilDev.Log.Debug(ex);
            }
            scrWnd.Checked = SilDev.Ini.ReadBoolean("Settings", "Windowed");
            caCheck.Checked = Main.GetConfigValue(Main.SettingsKey.USE_CA) == "1";
            try
            {
                string s = Main.GetConfigValue(Main.SettingsKey.Chromatic_shift);
                string[] sa = s.Split(',');
                decimal m = 0m;
                if (sa.Length >= 2)
                {
                    sa[0] = sa[0].Replace("float2(", string.Empty).Replace(".", ",").Trim();
                    if (decimal.TryParse(sa[0], out m))
                        caShiftX.Value = m;
                    sa[1] = sa[1].Replace(")", string.Empty).Replace(".", ",").Trim();
                    m = 0m;
                    if (decimal.TryParse(sa[1], out m))
                        caShiftY.Value = m;
                }
                s = Main.GetConfigValue(Main.SettingsKey.Chromatic_strength).Replace(".", ",");
                m = 0m;
                if (decimal.TryParse(s, out m))
                    caStrength.Value = m;
            }
            catch (Exception ex)
            {
                SilDev.Log.Debug(ex);
            }
            if (!caCheck.Checked)
            {
                caShiftX.Enabled = caCheck.Checked;
                caShiftY.Enabled = caCheck.Checked;
                caStrength.Enabled = caCheck.Checked;
            }
            lsCheck.Checked = Main.GetConfigValue(Main.SettingsKey.USE_LUMASHARPEN) == "1";
            paCheck.Checked = Main.GetConfigValue(Main.SettingsKey.USE_PIXELART_CRT) == "1";
            smaaCheck.Checked = Main.GetConfigValue(Main.SettingsKey.USE_SMAA) == "1";

            scrDir.Text = Main.GetConfigValue(Main.SettingsKey.RESHADE_SCREENSHOT_DIRECTORY).Replace("\"", string.Empty);
            if (string.IsNullOrEmpty(scrDir.Text))
                scrDir.Text = Path.Combine(Application.StartupPath, Environment.Is64BitOperatingSystem ? "x64" : "x86").Replace("\\", "/");
            showFPS.Checked = Main.GetConfigValue(Main.SettingsKey.RESHADE_SHOW_FPS) == "1";
            showClock.Checked = Main.GetConfigValue(Main.SettingsKey.RESHADE_SHOW_CLOCK) == "1";
            showStats.Checked = Main.GetConfigValue(Main.SettingsKey.RESHADE_SHOW_STATISTICS) == "1";
        }

        private void caCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            caShiftX.Enabled = cb.Checked;
            caShiftY.Enabled = cb.Checked;
            caStrength.Enabled = cb.Checked;
        }

        private void setScrDir_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog dialog = new FolderBrowserDialog())
                {
                    dialog.ShowDialog();
                    if (string.IsNullOrWhiteSpace(dialog.SelectedPath))
                        scrDir.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                    else
                        scrDir.Text = dialog.SelectedPath;
                }
                scrDir.Text = scrDir.Text.Replace("\\", "/");
            }
            catch (Exception ex)
            {
                SilDev.Log.Debug(ex);
            }
        }


        /*------------------------------.
        | ::       Save Button       :: |
        '------------------------------*/

        private void saveBtn_MouseEnter(object sender, EventArgs e) => saveBtn.BackgroundImage = Properties.Resources.btn_small_mo_13;

        private void saveBtn_MouseLeave(object sender, EventArgs e) => saveBtn.BackgroundImage = Properties.Resources.btn_small;

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process[] game = Process.GetProcessesByName("ff9");

                if (SilDev.Ini.ReadBoolean("Settings", "Windowed") != scrWnd.Checked)
                {
                    SilDev.Ini.Write("Settings", "Windowed", scrWnd.Checked);
                    if (game.Length > 0)
                        SilDev.MsgBox.Show(this, "NOTE: Changed screen setting does not take effect until the next launch.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                Main.SetConfigValue(Main.SettingsKey.USE_CA, caCheck.Checked ? "1" : "0");
                if (caCheck.Checked)
                {
                    string x = caShiftX.Value.ToString().Replace(",", ".");
                    string y = caShiftY.Value.ToString().Replace(",", ".");
                    Main.SetConfigValue(Main.SettingsKey.Chromatic_shift, $"float2({x},{y})");
                    Main.SetConfigValue(Main.SettingsKey.Chromatic_strength, caStrength.Value.ToString().Replace(",", "."));
                }
                Main.SetConfigValue(Main.SettingsKey.USE_LUMASHARPEN, lsCheck.Checked ? "1" : "0");
                Main.SetConfigValue(Main.SettingsKey.USE_PIXELART_CRT, paCheck.Checked ? "1" : "0");
                Main.SetConfigValue(Main.SettingsKey.USE_SMAA, smaaCheck.Checked ? "1" : "0");

                Main.SetConfigValue(Main.SettingsKey.RESHADE_SCREENSHOT_DIRECTORY, $"\"{scrDir.Text}\"");
                Main.SetConfigValue(Main.SettingsKey.RESHADE_SHOW_FPS, showFPS.Checked ? "1" : "0");
                Main.SetConfigValue(Main.SettingsKey.RESHADE_SHOW_CLOCK, showClock.Checked ? "1" : "0");
                Main.SetConfigValue(Main.SettingsKey.RESHADE_SHOW_STATISTICS, showStats.Checked ? "1" : "0");

                Main.WriteSettings();
                if (game.Length > 0)
                {
                    foreach (Process p in game)
                    {
                        if (p.MainWindowHandle != IntPtr.Zero)
                        {
                            SystemSounds.Asterisk.Play();
                            ParentForm.WindowState = FormWindowState.Minimized;
                            SilDev.WinAPI.ShowWindow(p.MainWindowHandle);
                            SilDev.WinAPI.SafeNativeMethods.SetForegroundWindow(p.MainWindowHandle);
                            break;
                        }
                    }
                }
                else
                    SilDev.MsgBox.Show(this, "Settings successfuly saved.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                SilDev.Log.Debug(ex);
            }
        }


        /*------------------------------.
        | ::      Cancel Button      :: |
        '------------------------------*/

        private void cancelBtn_MouseEnter(object sender, EventArgs e) => cancelBtn.BackgroundImage = Properties.Resources.btn_small_mo_13;

        private void cancelBtn_MouseLeave(object sender, EventArgs e) => cancelBtn.BackgroundImage = Properties.Resources.btn_small;

        private void cancelBtn_MouseClick(object sender, MouseEventArgs e) => Close();
    }
}
