using System.Windows.Forms;

namespace AppThemer {
    class ThemedToolStripRenderer : ToolStripProfessionalRenderer {
        public ThemedToolStripRenderer(ColorTheme theme) : base(new ThemedColorTable(theme)) { }
    }
}
