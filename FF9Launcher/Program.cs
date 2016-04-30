using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace FF9LauncherPlus
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            SilDev.Log.AllowDebug();
            try
            {
                bool newInstance = true;
                using (Mutex mutex = new Mutex(true, Process.GetCurrentProcess().ProcessName, out newInstance))
                {
                    if (newInstance)
                    {
                        try
                        {
                            if (!File.Exists(FF9LauncherPlus.Main.GameExePath))
                            {
                                MessageBox.Show($"Please move '{Application.ProductName}.exe' to the root directory of\r\n'Final Fantasy IX' before running.\r\n\r\nIMPORTANT: Create a backup of the original file!", "How To Use", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            foreach (Process p in Process.GetProcessesByName("FF9"))
                            {
                                SilDev.MsgBox.Show($"Please close 'Final Fantasy IX' before running this tool.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            if (!SilDev.Elevation.IsAdministrator && (!SilDev.Elevation.WritableLocation() || !SilDev.Elevation.WritableLocation(Path.GetDirectoryName(FF9LauncherPlus.Main.GameExePath))))
                                SilDev.Elevation.RestartAsAdministrator();
                        }
                        catch (Exception ex)
                        {
                            SilDev.Log.Debug(ex);
                        }
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new MainForm());
                    }
                }
            }
            catch (Exception ex)
            {
                SilDev.Log.Debug(ex);
            }
        }
    }
}
