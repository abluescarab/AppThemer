using System.Windows.Forms;

namespace AppThemer.Controls {
    public class MenuStrip : System.Windows.Forms.MenuStrip, IThemedControl {
        public MenuStrip() {

        }

        public void SetTheme(ColorTheme theme) {
            Renderer = new ThemedToolStripRenderer(theme);

            foreach(ToolStripMenuItem menu in Items) {
                foreach(dynamic item in menu.DropDownItems) {
                    item.ForeColor = theme.ForeColor;
                }

                menu.ForeColor = theme.ForeColor;
            }
        }
    }
}
