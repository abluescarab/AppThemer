namespace AppThemer.Controls {
    public class Form : System.Windows.Forms.Form, IThemedControl {
        public Form() {

        }

        public void SetTheme(ColorTheme theme) {
            BackColor = theme.WindowBackColor;
            ForeColor = theme.ForeColor;
        }
    }
}
