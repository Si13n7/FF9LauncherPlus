using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace FF9LauncherPlus
{
    public sealed class Main
    {
        public static string GameExePath { get; } = Path.Combine(Application.StartupPath, $"{(Environment.Is64BitOperatingSystem ? "x64" : "x86")}\\FF9.exe");

        public static string AssetsDir { get; } = Path.Combine(Application.StartupPath, Application.ProductName);

        public static string ShaderDll { get; } = $"{(Environment.Is64BitOperatingSystem ? "ReShade64" : "ReShade32")}.dll";

        public static void InstallShaders()
        {
            try
            {
                string gameDir = Path.GetDirectoryName(GameExePath);
                SilDev.Data.DirLink(Path.Combine(gameDir, "ReShade"), Path.Combine(AssetsDir, "ReShade"));
                string dllPath = Path.Combine(gameDir, "d3d9.dll");
                File.Copy(Path.Combine(AssetsDir, ShaderDll), dllPath);
                SilDev.Data.SetAttributes(dllPath, FileAttributes.Hidden);
                string fxPath = Path.Combine(gameDir, "ReShade.fx");
                File.Copy(Path.Combine(AssetsDir, "ReShade.fx"), fxPath);
                SilDev.Data.SetAttributes(fxPath, FileAttributes.Hidden);
                foreach (SettingsKey key in Enum.GetValues(typeof(SettingsKey)))
                    GetConfigValue(key);
            }
            catch (Exception ex)
            {
                SilDev.Log.Debug(ex);
            }
        }

        public static void UninstallShaders()
        {
            try
            {
                string gameDir = Path.GetDirectoryName(GameExePath);
                SilDev.Data.DirUnLink(Path.Combine(gameDir, "ReShade"));
                foreach (string file in new string[]
                {
                    Path.Combine(gameDir, "d3d9.dll"),
                    Path.Combine(gameDir, "d3d9.log"),
                    Path.Combine(gameDir, "ReShade.fx")
                })
                {
                    try
                    {
                        if (File.Exists(file))
                            File.Delete(file);
                    }
                    catch (Exception ex)
                    {
                        SilDev.Log.Debug(ex);
                    }
                }
            }
            catch (Exception ex)
            {
                SilDev.Log.Debug(ex);
            }
        }

        public enum SettingsKey
        {
            RESHADE_SCREENSHOT_DIRECTORY,
            RESHADE_SHOW_FPS,
            RESHADE_SHOW_CLOCK,
            RESHADE_SHOW_STATISTICS,
            USE_CA,
            Chromatic_shift,
            Chromatic_strength,
            USE_LUMASHARPEN,
            USE_PIXELART_CRT,
            USE_SMAA,
            USE_Magnify,
            magnifyStartPixelWidth,
            magnifyEndPixelWidth,
            magnifyEndPixelHeight
        }

        private static readonly string ClobalPath = Path.Combine(AssetsDir, "ReShade\\Global.cfg");

        private static readonly string CeeJayPath = Path.Combine(AssetsDir, "ReShade\\Presets\\Shaders_by_CeeJay.cfg");

        private static readonly string GanossaPath = Path.Combine(AssetsDir, "ReShade\\Presets\\Shaders_by_Ganossa.cfg");

        private static Dictionary<SettingsKey, string> Settings = new Dictionary<SettingsKey, string>();

        public static string GetConfigValue(SettingsKey key)
        {
            try
            {
                string configPath = string.Empty;
                switch (key)
                {
                    case SettingsKey.RESHADE_SCREENSHOT_DIRECTORY:
                    case SettingsKey.RESHADE_SHOW_FPS:
                    case SettingsKey.RESHADE_SHOW_CLOCK:
                    case SettingsKey.RESHADE_SHOW_STATISTICS:
                        configPath = ClobalPath;
                        break;
                    case SettingsKey.USE_Magnify:
                    case SettingsKey.magnifyStartPixelWidth:
                    case SettingsKey.magnifyEndPixelWidth:
                    case SettingsKey.magnifyEndPixelHeight:
                        configPath = GanossaPath;
                        break;
                    default:
                        configPath = CeeJayPath;
                        break;
                }
                string keyName = Enum.GetName(typeof(SettingsKey), key);
                foreach (string line in File.ReadAllLines(configPath))
                {
                    if (!line.StartsWith($"#define {keyName}", StringComparison.OrdinalIgnoreCase))
                        continue;
                    bool match = false;
                    bool first = false;
                    foreach (string value in line.Split(' '))
                    {
                        if (!match && value.ToUpper() == keyName.ToUpper())
                        {
                            match = true;
                            continue;
                        }
                        if (match)
                        {
                            if (!first)
                            {
                                first = true;
                                Settings[key] = value.Replace("\"", string.Empty);
                                continue;
                            }
                            Settings[key] += $" {value.Replace("\"", string.Empty)}";
                        }
                    }
                    break;
                }
                return Settings[key];
            }
            catch (Exception ex)
            {
                SilDev.Log.Debug(ex);
                return null;
            }
        }

        public static bool SetConfigValue(SettingsKey key, string value)
        {
            try
            {
                Settings[key] = value;
                return true;
            }
            catch (Exception ex)
            {
                SilDev.Log.Debug(ex);
                return false;
            }
        }

        public static void WriteSettings()
        {
            try
            {
                string[][] configs = new string[][]
                {
                    File.ReadAllLines(ClobalPath),
                    File.ReadAllLines(CeeJayPath),
                    File.ReadAllLines(GanossaPath)
                };
                string[][] oldCfgs = configs;
                foreach (SettingsKey key in Enum.GetValues(typeof(SettingsKey)))
                {
                    string keyName = Enum.GetName(typeof(SettingsKey), key);
                    int index = 0;
                    switch (key)
                    {
                        case SettingsKey.RESHADE_SCREENSHOT_DIRECTORY:
                        case SettingsKey.RESHADE_SHOW_FPS:
                        case SettingsKey.RESHADE_SHOW_CLOCK:
                        case SettingsKey.RESHADE_SHOW_STATISTICS:
                            index = 0;
                            break;
                        case SettingsKey.USE_Magnify:
                        case SettingsKey.magnifyStartPixelWidth:
                        case SettingsKey.magnifyEndPixelWidth:
                        case SettingsKey.magnifyEndPixelHeight:
                            index = 2;
                            break;
                        default:
                            index = 1;
                            break;
                    }
                    for (int i = 0; i < configs[index].Length; i++)
                    {
                        if (!configs[index][i].StartsWith($"#define {keyName}", StringComparison.OrdinalIgnoreCase))
                            continue;
                        string newValue = $"#define {keyName} {Settings[key]}";
                        if (configs[index][i] != newValue)
                            configs[index][i] = newValue;
                        break;
                    }
                }
                for (int i = 0; i < configs.Length; i++)
                    File.WriteAllLines(i == 0 ? ClobalPath : i == 1 ? CeeJayPath : GanossaPath, configs[i]);
                string fxPath = Path.Combine(Path.GetDirectoryName(GameExePath), "ReShade.fx");
                if (File.Exists(fxPath))
                    File.SetLastWriteTime(fxPath, DateTime.Now);
            }
            catch (Exception ex)
            {
                SilDev.Log.Debug(ex);
            }
        }

        public static Size ScreenSize { get; private set; } = Screen.PrimaryScreen.Bounds.Size;

        private static Size renderSize = new Size(640, 400);
        public static Size RenderSize
        {
            get
            {
                if (renderSize == new Size(640, 400))
                {
                    try
                    {
                        decimal ratio = (decimal)Math.Round((100f / renderSize.Height) * ScreenSize.Height) / 100m;
                        renderSize.Width = (int)Math.Round(renderSize.Width * ratio);
                        renderSize.Height = (int)Math.Round(renderSize.Height * ratio);
                    }
                    catch (Exception ex)
                    {
                        SilDev.Log.Debug(ex);
                        renderSize = ScreenSize;
                    }
                }
                return renderSize;
            }
        }

        public static int RenderPixelStart
        {
            get
            {
                return ScreenSize.Width - RenderSize.Width;
            }
        }

        private static PrivateFontCollection pfc = new PrivateFontCollection();

        private static FontFamily fontFamily = null;

        public static FontFamily FontFamily
        {
            get
            {
                if (fontFamily == null)
                {
                    try
                    {
                        string fontPath = Path.Combine(AssetsDir, "BankGothic Bold.ttf");
                        if (!File.Exists(fontPath))
                            File.WriteAllBytes(fontPath, Properties.Resources.BankGothic_Bold);
                        if (File.Exists(fontPath))
                            pfc.AddFontFile(fontPath);
                        if (pfc.Families.Length >= 1)
                            fontFamily = pfc.Families[0];
                    }
                    catch (Exception ex)
                    {
                        SilDev.Log.Debug(ex);
                    }
                }
                return fontFamily;
            }
        }
    }
}
