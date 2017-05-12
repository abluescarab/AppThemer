using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppThemer {
    public static class Themer {
        private static Dictionary<Type, ColorTheme> themes = new Dictionary<Type, ColorTheme>();

        public static ColorTheme CurrentTheme { get; private set; }

        public static void ChangeTheme<T>(this Controls.Form form) where T : ColorTheme, new() {
            Type type = typeof(T);

            if(!themes.ContainsKey(type)) {
                AddTheme(new T());
            }

            ColorTheme theme = themes[type];

            foreach(Control control in form.Controls) {
                SetControlTheme(control, theme);
            }

            form.SetTheme(theme);
            CurrentTheme = theme;
        }

        private static void SetControlTheme(Control control, ColorTheme theme) {
            IThemedControl ctrl = control as IThemedControl;

            if(ctrl != null) {
                ctrl.SetTheme(theme);
            }

            foreach(Control child in control.Controls) {
                SetControlTheme(child, theme);
            }
        }

        public static void AddTheme(ColorTheme theme) {
            themes.Add(theme.GetType(), theme);
        }

        public static void RemoveTheme<T>() where T : ColorTheme {
            themes.Remove(typeof(T));
        }
    }
}
