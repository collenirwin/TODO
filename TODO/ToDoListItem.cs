using System;
using System.Drawing;
using System.Windows.Forms;

namespace TODO {
    public partial class ToDoListItem : UserControl {

        #region Public

        public event EventHandler numberChanged;
        public event KeyEventHandler numberKeyDown;
        public event KeyEventHandler taskKeyDown;
        public event EventHandler taskDisposed;

        public int number {
            get { return Convert.ToInt32(this.txtNumber.Text); }
        }

        public string task {
            get { return txtTask.Text; }
        }

        #endregion

        #region Private

        int _numberBeforeUpdate = 1;

        #endregion

        #region Constructor & Misc

        public ToDoListItem() {
            InitializeComponent();
        }

        public void setFont(Font font) {
            txtNumber.Font = font;
            txtTask.Font = font;
        }

        #endregion

        #region txtNumber

        public void setNumber(int number) {
            txtNumber.Text = number.ToString();
            _numberBeforeUpdate = number;
        }

        private bool validateNumber() {
            int x; // just a placeholder
            if (int.TryParse(txtNumber.Text, out x)) { // is a valid int
                if (x < 1) {
                    x = 1; // don't go below 1
                }

                _numberBeforeUpdate = x; // keep it

                // trigger numberChanged event
                if (numberChanged != null) {
                    numberChanged(this, new EventArgs());
                }

                return true;
            } else { // invalid
                txtNumber.Text = _numberBeforeUpdate.ToString(); // replace it with the previous good int
                return false;
            }
        }


        private void txtNumber_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true; // no annoying DING sound
                txtTask.Focus(); // focus task box (causes validation)
            }

            // trigger numberKeyDown event
            if (numberKeyDown != null) {
                numberKeyDown(this, e);
            }
        }

        private void txtNumber_Leave(object sender, EventArgs e) {
            if (!validateNumber()) { // validate
                txtNumber.Focus(); // bad input, try again please (redirect the user back to the number box)
            }
        }

        #endregion

        #region txtTask

        public void setTask(string task) {
            txtTask.Text = task;
        }

        private void txtTask_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true; // no annoying DING sound
            }

            if (taskKeyDown != null) {
                taskKeyDown(this, new KeyEventArgs(e.KeyCode));
            }
        }

        #endregion

        #region btnDone

        private void btnDone_Click(object sender, EventArgs e) {
            if (txtTask.Text.Trim().Length > 0) { // if there's text entered
                // prompt - are you sure?
                if (MessageBox.Show("Remove task " + number + "?", "TODO", MessageBoxButtons.YesNo) == DialogResult.No) {
                    return; // cancel
                }
            }

            if (taskDisposed != null) { // trigger event
                taskDisposed(this, new EventArgs());
            }
        }

        #endregion

        #region chkDone

        private void chkDone_CheckedChanged(object sender, EventArgs e) {
            // enable/disable the textboxes based on the checkbox
            txtNumber.Enabled = !chkDone.Checked;
            txtTask.Enabled   = !chkDone.Checked;
        }

        #endregion
    }
}
