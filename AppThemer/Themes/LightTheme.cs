using System.Diagnostics;
using System.Drawing;

namespace AppThemer.Themes {
    public class LightTheme : ColorTheme {
        public override Color DarkDarkColor { get { return SystemColors.ControlDarkDark; } }
        public override Color DarkColor { get { return SystemColors.ControlDark; } }
        public override Color LightLightColor { get { return SystemColors.ControlLightLight; } }
        public override Color LightColor { get { return SystemColors.ControlLight; } }

        public override Color WindowBackColor { get { return LightLightColor; } }
        public override Color ControlBackColor { get { return LightColor; } }

        public override Color ForeColor { get { return Color.FromKnownColor(KnownColor.ControlText); } }
    }
}
