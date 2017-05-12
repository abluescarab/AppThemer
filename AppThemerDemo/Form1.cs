using System;
using System.Windows.Forms;
using AppThemer;

namespace AppThemerDemo {
    public partial class Form1 : AppThemer.Controls.Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.ChangeTheme<AppThemer.Themes.LightTheme>();
        }

        private void darkToolStripMenuItem_CheckedChanged(object sender, EventArgs e) {
            RadioCheck(sender, e);
        }

        private void RadioCheck(object sender, EventArgs e) {
            foreach(ToolStripMenuItem item in ((ToolStripMenuItem)sender).GetCurrentParent().Items) {
                if(item == sender) {
                    item.Checked = true;
                }
                else {
                    item.Checked = false;
                }
            }
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e) {
            RadioCheck(sender, e);

            if(Themer.CurrentTheme.GetType() != typeof(AppThemer.Themes.LightTheme)) {
                this.ChangeTheme<AppThemer.Themes.LightTheme>();
            }
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e) {
            RadioCheck(sender, e);
            
            if(Themer.CurrentTheme.GetType() != typeof(AppThemer.Themes.DarkTheme)) {
                this.ChangeTheme<AppThemer.Themes.DarkTheme>();
            }
        }
    }
}
