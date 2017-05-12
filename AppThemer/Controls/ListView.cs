using System.Drawing;

namespace AppThemer.Controls {
    public class ListView : System.Windows.Forms.ListView, IThemedControl {
        private Color selectedItemBackColor;

        public ListView() {
            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            OwnerDraw = true;
            DrawItem += ListView_DrawItem;
        }

        public void SetTheme(ColorTheme theme) {
            BackColor = theme.BackColor;
            ForeColor = theme.ForeColor;
            selectedItemBackColor = theme.MouseEnterBackColor;
        }

        private void ListView_DrawItem(object sender, System.Windows.Forms.DrawListViewItemEventArgs e) {
            SizeF size = e.Graphics.MeasureString(e.Item.Text, Font);
            Brush foreColor = new SolidBrush(ForeColor);
            Brush backColor = Brushes.Transparent;
            int checkBoxSize = 15;
            int textX = 0;

            if(CheckBoxes) {
                System.Windows.Forms.ButtonState state;

                if(e.Item.Checked)
                    state = System.Windows.Forms.ButtonState.Flat | System.Windows.Forms.ButtonState.Checked;
                else
                    state = System.Windows.Forms.ButtonState.Flat;

                System.Windows.Forms.ControlPaint.DrawCheckBox(e.Graphics, 0, e.Bounds.Top, checkBoxSize, checkBoxSize, state);
                textX = checkBoxSize;
            }

            if(e.Item.Selected) {
                backColor = new SolidBrush(selectedItemBackColor);
            }

            e.Graphics.FillRectangle(backColor, new RectangleF(e.Bounds.X + textX, e.Bounds.Y, size.Width, size.Height));
            e.Graphics.DrawString(e.Item.Text, Font, foreColor, e.Bounds.X + textX, e.Bounds.Top + 1);
        }
    }
}
