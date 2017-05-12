using System.Drawing;

namespace AppThemer {
    public abstract class ColorTheme {
        public static Color Transparent = Color.FromArgb(0, 255, 255, 255);

        public abstract Color DarkColor { get; }
        public abstract Color DarkDarkColor { get; }
        public abstract Color LightColor { get; }
        public abstract Color LightLightColor { get; }

        // Accent
        public virtual Color LightAccentColor { get { return Color.FromArgb(21, 180, 252); } }
        public virtual Color AccentColor { get { return Color.FromArgb(33, 150, 243); } }
        public virtual Color DarkAccentColor { get { return Color.FromArgb(2, 117, 169); } }

        // Default
        public abstract Color BackColor { get; }
        public abstract Color ForeColor { get; }

        // MouseEnter
        public virtual Color MouseEnterBackColor { get { return AccentColor; } }
        public virtual Color MouseEnterForeColor { get { return ForeColor; } }

        // MouseLeave
        public virtual Color MouseLeaveBackColor { get { return BackColor; } }
        public virtual Color MouseLeaveForeColor { get { return ForeColor; } }

        // MouseDown
        public virtual Color MouseDownBackColor { get { return LightAccentColor; } }
        public virtual Color MouseDownForeColor { get { return ForeColor; } }

        // MouseUp
        public virtual Color MouseUpBackColor { get { return AccentColor; } }
        public virtual Color MouseUpForeColor { get { return ForeColor; } }
    }
}
