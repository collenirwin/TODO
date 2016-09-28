using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace TODO {
    public partial class Form1 : Form {

        #region Vars

        // I would love to simply use pnlToDoList.Controls, but ControlCollections are the bane of my existence
        List<ToDoListItem> lstTODO = new List<ToDoListItem>();

        // path of the currently open TODO list file
        string filePath = "";

        // whether or not the TODOlist has been modified
        bool modified = false;

        #endregion

        #region Constructor & Form Events

        public Form1() {
            InitializeComponent();

            // add initial task
            addTask("your task here");

            modified = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true; // no annoying DING sound

                addTask("");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (modified) {

                // prompt
                DialogResult result = MessageBox.Show("Are you sure you want to close? Your unsaved changes will be lost.", "TODO", MessageBoxButtons.YesNo);

                if (result == DialogResult.No) {
                    e.Cancel = true; // cancel closing
                }
            }
        }

        #endregion

        #region Task Procedures

        // add a ToDoListItem to pnlToDoList with specified task string, done specifies whether or not it's checked
        private bool addTask(string task = "", bool done = false) {
            modified = true;

            if (lstTODO.Count == 999) { // limit 999
                MessageBox.Show("Sorry, you've hit the task limit!", "TODO - Error");
                return false;
            }

            pnlToDoList.SuspendLayout();

            // set up the tdli
            ToDoListItem tdli = new ToDoListItem();
            tdli.setNumber(pnlToDoList.Controls.Count + 1);
            tdli.setTask(task);
            tdli.numberChanged += new EventHandler(tdli_numberChanged);
            tdli.numberKeyDown += new KeyEventHandler(tdli_numberKeyDown);
            tdli.taskKeyDown   += new KeyEventHandler(tdli_taskKeyDown);
            tdli.taskDisposed  += new EventHandler(tdli_taskDisposed);
            if (done) { // done! check the task off
                tdli.chkDone.Checked = true;
            }

            // add tdli to the list
            lstTODO.Add(tdli);
            
            // add tdli to panel
            pnlToDoList.Controls.Add(tdli);
            tdli.Dock = DockStyle.Top;

            // tabs
            tdli.TabStop = true;
            tdli.TabIndex = lstTODO.IndexOf(tdli);
            tdli.txtTask.TabIndex = lstTODO.IndexOf(tdli);

            pnlToDoList.Controls.SetChildIndex(tdli, 0);
            tdli.Focus();

            pnlToDoList.ResumeLayout();
            return true;
        }

        private void renumberTasks() {
            pnlToDoList.SuspendLayout();

            // set the correct numbers for each task, and order them visually
            for (int x = 0; x < lstTODO.Count; x++) {
                lstTODO[x].setNumber(x + 1);
                lstTODO[x].TabIndex = x; // new tabindex too!
                lstTODO[x].txtTask.TabIndex = x;

                // brings the control to front
                pnlToDoList.Controls.SetChildIndex(lstTODO[x], pnlToDoList.Controls.Count - 1 - x); 
            }

            pnlToDoList.ResumeLayout();
        }

        private void insertTDLI(ToDoListItem tdli) {
            lstTODO.Remove(tdli);
            lstTODO.Insert(tdli.number - 1, tdli);

            tdli.txtTask.Focus();
            renumberTasks();
        }

        private void tdli_numberChanged(object sender, EventArgs e) {
            ToDoListItem tdli = sender as ToDoListItem;
            modified = true;

            // set number, don't let it go over the total amount of tasks
            tdli.setNumber((tdli.number > pnlToDoList.Controls.Count) ? pnlToDoList.Controls.Count : tdli.number);

            // insert it into the correct position in the task list
            insertTDLI(tdli);
        }

        private void tdli_numberKeyDown(object sender, KeyEventArgs e) {
            ToDoListItem tdli = sender as ToDoListItem;

            if (e.KeyCode == Keys.Up && tdli.number < lstTODO.Count) { // up
                tdli.setNumber(tdli.number + 1); // increment
            } else if (e.KeyCode == Keys.Down && tdli.number > 1) { // down
                tdli.setNumber(tdli.number - 1); // decrement
            }
        }

        // increment: -1 for looking up, 1 for looking down
        private ToDoListItem findNextUncheckedTask(int start, int increment) {
            int x = start;
            while (true) { // not enabled
                x += increment;
                if (x != start) {
                    if ((x > lstTODO.Count - 1) || (x < 0)) { // not within range
                        x = (x == -1) ? lstTODO.Count - 1 : 0; // reset back to top or bottom
                    }

                    if (lstTODO[x].txtTask.Enabled) { // found it!
                        return lstTODO[x];
                    }

                } else { // we've been all the way around. nothing unchecked
                    return lstTODO[start];
                }
            }
        }

        private void tdli_taskKeyDown(object sender, KeyEventArgs e) {
            ToDoListItem tdli = sender as ToDoListItem;

            // enter on the last task in the list
            if (e.KeyCode == Keys.Enter && lstTODO.IndexOf(tdli) == lstTODO.Count - 1) {
                addTask(""); // add a new task

            // enter on non-last task
            } else if (e.KeyCode == Keys.Enter && (lstTODO.IndexOf(tdli) != lstTODO.Count - 1)) {
                findNextUncheckedTask(lstTODO.IndexOf(tdli), 1).txtTask.Focus();

            // backspace on empty task
            } else if (e.KeyCode == Keys.Back && tdli.task == "") {
                disposeTask(tdli); // get rid of the task

            // up arrow
            } else if (e.KeyCode == Keys.Up) {
                findNextUncheckedTask(lstTODO.IndexOf(tdli), -1).txtTask.Focus();

            // down arrow
            } else if (e.KeyCode == Keys.Down) {
                findNextUncheckedTask(lstTODO.IndexOf(tdli), 1).txtTask.Focus();
            }
        }

        // get rid of a specified task, and handle everything that goes with it if updateUI is true
        private void disposeTask(ToDoListItem tdli, bool updateUI = true) {
            modified = true;

            // get new task index (task below or last task)
            int newIndex = (lstTODO.IndexOf(tdli) == lstTODO.Count - 1) ? lstTODO.Count - 2 : lstTODO.IndexOf(tdli);

            // remove task from all collections
            lstTODO.Remove(tdli);
            pnlToDoList.Controls.Remove(tdli);

            // dispose
            tdli.Dispose();

            if (updateUI) {
                renumberTasks(); // renumber the remaining tasks

                // if we have enough tasks
                if (lstTODO.Count > newIndex && newIndex > -1) {
                    lstTODO[newIndex].txtTask.Focus(); // focus the task below
                }
            }
        }

        // get rid of ALL tasks
        private void clearTasks() {
            int count = lstTODO.Count;
            for (int x = 0; x < count; x++) {
                disposeTask(lstTODO[0], false); // dispose, don't update UI
            }
        }

        private void tdli_taskDisposed(object sender, EventArgs e) {
            disposeTask(sender as ToDoListItem);
        }

        #endregion

        #region msMain Events

        // Add Task
        private void tsiAddTask_Click(object sender, EventArgs e) {
            addTask("");
        }

        // Clear All Tasks
        private void tsiClearAllTasks_Click(object sender, EventArgs e) {

            // prompt (are you sure???????)
            DialogResult result = MessageBox.Show("Are you sure you want to clear this task list?", "TODO", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) {
                clearTasks();
            }
        }

        // New
        private void tsiNew_Click(object sender, EventArgs e) {
            try {
                Process.Start(Application.ExecutablePath); // open another window of this program
            } catch {
                MessageBox.Show("Something strange happened and we can't open a new TODO list", "TODO - Error");
            }
        }

        // Open
        private void tsiOpen_Click(object sender, EventArgs e) {
            if (modified) { // open todo list

                // prompt to remind user of consequences of opening another todo list
                DialogResult result = MessageBox.Show("Open another TODO list? Your current unsaved changes to this one will be lost.", "TODO", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel) {
                    return; // user cancelled open procedure
                }
            }

            ofd.ShowDialog();
        }

        // OpenFileDialog - OK
        private void ofd_FileOk(object sender, System.ComponentModel.CancelEventArgs e) {

            // we have a file
            if (ofd.FileName.Trim() != "") {

                // clear all tasks
                clearTasks();

                try {
                    // read the lines into new tasks
                    using (StreamReader r = File.OpenText(ofd.FileName)) {
                        while (r.Peek() != -1) {
                            string line = r.ReadLine().Trim();
                            if (line != "") { // if the line isn't empty
                                addTask(line.Replace("//done//", ""), (line.StartsWith("//done//"))); // add it as a task!
                            }
                        }
                    }

                    this.filePath = ofd.FileName;
                    modified = false;

                    // update title bar with file path
                    this.Text = filePath + " - TODO";
                } catch {
                    MessageBox.Show("Couldn't open the specified TODO list. It's either corrupt or in a location that TODO can't access.", "TODO - Error");
                }
            }
        }

        // Save
        private void tsiSave_Click(object sender, EventArgs e) {
            if (filePath == "") { // not saved yet
                sfd.ShowDialog();
                return;
            }

            try {
                using (StreamWriter w = File.CreateText(filePath)) {
                    for (int x = 0; x < lstTODO.Count; x++) {
                        lstTODO[x].txtTask.Text.Replace("//done//", ""); // get rid of //done// flag

                        if (lstTODO[x].chkDone.Checked) { // task done
                            w.WriteLine("//done//" + lstTODO[x].task); // note //done// flag - I know I could do this in a better way. sue me
                        } else { // task not done
                            w.WriteLine(lstTODO[x].task);
                        }
                    }
                }

                modified = false;

                // update title bar with file path
                this.Text = filePath + " - TODO";
            } catch {
                modified = true;
                MessageBox.Show("Couldn't save your TODO list. Please make sure that TODO can access the location you wish to save to.", "TODO - Error");
            }
        }

        // Save As...
        private void tsiSaveAs_Click(object sender, EventArgs e) {
            sfd.ShowDialog();
        }

        // SaveFileDialog - OK
        private void sfd_FileOk(object sender, System.ComponentModel.CancelEventArgs e) {

            // we have a filename
            if (sfd.FileName.Trim() != "") {
                filePath = sfd.FileName;
                tsiSave_Click(sender, new EventArgs()); // calling tsiSave's click event (shh..)
            }
        }

        // Exit
        private void tsiExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        // About
        private void tsiAbout_Click(object sender, EventArgs e) {
            frmAbout f = new frmAbout();
            f.ShowDialog();
        }

        #endregion
    }
}
