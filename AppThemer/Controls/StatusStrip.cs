using System;

namespace AppThemer.Controls {
    public class StatusStrip : System.Windows.Forms.StatusStrip, IThemedControl {
        public StatusStrip() {

        }

        public void SetTheme(ColorTheme theme) {
            Type type = theme.GetType();

            if(type == typeof(Themes.DarkTheme)) {
                BackColor = theme.DarkDarkColor;
            }
            else if(type == typeof(Themes.LightTheme)) {
                BackColor = theme.LightLightColor;
            }
            else {
                BackColor = theme.BackColor;
            }
        }
    }
}
