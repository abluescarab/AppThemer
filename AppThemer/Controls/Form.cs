using AppThemer.Themes;

namespace AppThemer.Controls {
    public class Form : System.Windows.Forms.Form, IThemedControl {
        public Form() {

        }

        public void SetTheme(ColorTheme theme) {
            if(theme.GetType() == typeof(DarkTheme)) {
                BackColor = theme.DarkDarkColor;
            }
            else if(theme.GetType() == typeof(LightTheme)) {
                BackColor = theme.LightLightColor;
            }
            else {
                BackColor = theme.BackColor;
            }

            ForeColor = theme.ForeColor;
        }
    }
}
