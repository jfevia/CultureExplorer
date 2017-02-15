using System;
using System.Drawing;
using System.Windows.Forms;

namespace CultureExplorer
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public class ProgramSettings
    {
        public enum ClassColor
        {
            None,
            ApplyCultureInfo,
            ApplyRegionInfo,
            ApplyNumberFormatInfo,
            ApplyDateTimeFormatInfo,
            ApplyTextInfo,
            ApplyCalendar,
            ClearCultureInfo,
            ClearRegionInfo,
            ClearNumberFormatInfo,
            ClearDateTimeFormatInfo,
            ClearTextInfo,
            ClearCalendar
        }

        public static Color ColorNone = Color.FromKnownColor(KnownColor.Info);
        public static Color ColorCultureInfo = Color.FromKnownColor(KnownColor.LightSteelBlue);
        public static Color ColorRegionInfo = Color.FromKnownColor(KnownColor.Tomato);
        public static Color ColorNumberFormatInfo = Color.FromKnownColor(KnownColor.Chartreuse);
        public static Color ColorDateTimeFormatInfo = Color.FromKnownColor(KnownColor.Khaki);
        public static Color ColorTextInfo = Color.FromKnownColor(KnownColor.Thistle);
        public static Color ColorCalendar = Color.FromKnownColor(KnownColor.Tan);
    }

    public enum CultureIcons
    {
        // defined in the same order as icons in the TreeViewIcons.png file
        Framework = 0,
        Invariant = 1,
        Neutral = 2,
        Specific = 3,
        Custom = 4,
        Replacement = 5,
        WinOnly = 6,
        Installed = 7,
        All = 8
    }

    public enum CultureType
    {
        NotACulture,
        Invariant,
        Neutral,
        Specific
    }
}