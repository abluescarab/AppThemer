using System.Drawing;

namespace AppThemer.Themes {
    public class DarkTheme : ColorTheme {
        public override Color DarkDarkColor { get { return Color.FromArgb(34, 34, 34); } }
        public override Color DarkColor { get { return Color.FromArgb(50, 50, 50); } }
        public override Color LightLightColor { get { return Color.FromArgb(74, 74, 74); } }
        public override Color LightColor { get { return Color.FromArgb(60, 60, 60); } }

        public override Color BackColor { get { return DarkColor; } }

        public override Color ForeColor { get { return Color.White; } }
    }
}
