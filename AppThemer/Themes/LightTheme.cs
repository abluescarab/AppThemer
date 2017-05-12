using System.Drawing;

namespace AppThemer.Themes {
    public class LightTheme : ColorTheme {
        public override Color DarkDarkColor { get { return Color.FromKnownColor(KnownColor.ControlDarkDark); } }
        public override Color DarkColor { get { return Color.FromKnownColor(KnownColor.Gainsboro); } }
        public override Color LightLightColor { get { return Color.FromArgb(255, 238, 238, 238); } }
        public override Color LightColor { get { return Color.FromKnownColor(KnownColor.Gainsboro); } }

        public override Color BackColor { get { return LightColor; } }

        public override Color ForeColor { get { return Color.FromKnownColor(KnownColor.ControlText); } }
    }
}
