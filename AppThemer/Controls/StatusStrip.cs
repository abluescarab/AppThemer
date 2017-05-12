namespace AppThemer.Controls {
    public class StatusStrip : System.Windows.Forms.StatusStrip, IThemedControl {
        public StatusStrip() {

        }

        public void SetTheme(ColorTheme theme) {
            BackColor = theme.ControlBackColor;
            ForeColor = theme.ForeColor;
        }
    }
}
