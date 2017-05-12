using System.Drawing;
using System.Windows.Forms;
using AppThemer.Themes;

namespace AppThemer {
    public class ThemedColorTable : ProfessionalColorTable {
        private ColorTheme theme;

        public ThemedColorTable(ColorTheme theme) : base() {
            this.theme = theme;
        }

        // MenuStripGradient
        public override Color MenuStripGradientBegin {
            get { return theme.WindowBackColor; }
        }

        public override Color MenuStripGradientEnd {
            get { return MenuStripGradientBegin; }
        }

        // MenuItemSelected
        public override Color MenuItemSelected {
            get { return theme.MouseEnterBackColor; }
        }

        // MenuItemSelectedGradient
        public override Color MenuItemSelectedGradientBegin {
            get { return theme.MouseEnterBackColor; }
        }

        public override Color MenuItemSelectedGradientEnd {
            get { return theme.MouseEnterBackColor; }
        }

        // MenuItemPressGradient
        public override Color MenuItemPressedGradientBegin {
            get { return theme.MouseDownBackColor; }
        }

        public override Color MenuItemPressedGradientMiddle {
            get { return theme.MouseDownBackColor; }
        }

        public override Color MenuItemPressedGradientEnd {
            get { return theme.MouseDownBackColor; }
        }

        // MenuBorder
        public override Color MenuBorder {
            get { return Color.Transparent; }
        }

        // MenuItemBorder
        public override Color MenuItemBorder {
            get { return Color.Transparent; }
        }

        // ToolStripDropDown
        public override Color ToolStripDropDownBackground {
            get { return theme.WindowBackColor; }
        }

        // ImageMarginGradient
        public override Color ImageMarginGradientBegin {
            get { return ToolStripDropDownBackground; }
        }

        public override Color ImageMarginGradientEnd {
            get { return ToolStripDropDownBackground; }
        }

        public override Color ImageMarginGradientMiddle {
            get { return ToolStripDropDownBackground; }
        }
    }
}
