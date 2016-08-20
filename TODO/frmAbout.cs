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

        private void btnOpen_Click(object sender, EventArgs e) {
            try {
                Process.Start("https://icons8.com/");
            } catch {
                MessageBox.Show("Couldn't open the site for some reason. Feel free to type the link into your browser manually.", "TODO");
            }
        }
    }
}
