using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TODO {
    public partial class frmAbout : Form {
        public frmAbout() {
            InitializeComponent();

            txtVersion.Text = Program.VERSION;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void launchSite(string url) {
            try {
                Process.Start(url);
            } catch {
                MessageBox.Show("Couldn't open the site for some reason. Feel free to type \"" + url + "\" into your browser manually.", "TODO");
            }
        }

        private void btnIcons8_Click(object sender, EventArgs e) {
            launchSite("https://icons8.com/");
        }

        private void btnGitHub_Click(object sender, EventArgs e) {
            launchSite("https://github.com/collenirwin/TODO");
        }
    }
}
