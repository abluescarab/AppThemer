namespace AppThemer.Controls {
    public class Button : System.Windows.Forms.Button, IThemedControl {
        public Button() {
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.BorderColor = ColorTheme.Transparent;
        }

        public void SetTheme(ColorTheme theme) {
            BackColor = theme.LightColor;
            ForeColor = theme.ForeColor;
            FlatAppearance.MouseDownBackColor = theme.MouseDownBackColor;
            FlatAppearance.MouseOverBackColor = theme.MouseEnterBackColor;
        }
    }
}
