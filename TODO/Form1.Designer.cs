namespace TODO {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAddTask = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiClearAllTasks = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlToDoList = new System.Windows.Forms.Panel();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.Color.White;
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiFile,
            this.tsiAddTask,
            this.tsiClearAllTasks,
            this.tsiAbout});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(584, 24);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // tsiFile
            // 
            this.tsiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiNew,
            this.tsiOpen,
            this.tsiSave,
            this.tsiSaveAs,
            this.tsiExit});
            this.tsiFile.Name = "tsiFile";
            this.tsiFile.Size = new System.Drawing.Size(37, 20);
            this.tsiFile.Text = "File";
            // 
            // tsiNew
            // 
            this.tsiNew.Name = "tsiNew";
            this.tsiNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsiNew.Size = new System.Drawing.Size(195, 22);
            this.tsiNew.Text = "New";
            this.tsiNew.Click += new System.EventHandler(this.tsiNew_Click);
            // 
            // tsiOpen
            // 
            this.tsiOpen.Name = "tsiOpen";
            this.tsiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsiOpen.Size = new System.Drawing.Size(195, 22);
            this.tsiOpen.Text = "Open";
            this.tsiOpen.Click += new System.EventHandler(this.tsiOpen_Click);
            // 
            // tsiSave
            // 
            this.tsiSave.Name = "tsiSave";
            this.tsiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsiSave.Size = new System.Drawing.Size(195, 22);
            this.tsiSave.Text = "Save";
            this.tsiSave.Click += new System.EventHandler(this.tsiSave_Click);
            // 
            // tsiSaveAs
            // 
            this.tsiSaveAs.Name = "tsiSaveAs";
            this.tsiSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsiSaveAs.Size = new System.Drawing.Size(195, 22);
            this.tsiSaveAs.Text = "Save As...";
            this.tsiSaveAs.Click += new System.EventHandler(this.tsiSaveAs_Click);
            // 
            // tsiExit
            // 
            this.tsiExit.Name = "tsiExit";
            this.tsiExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsiExit.Size = new System.Drawing.Size(195, 22);
            this.tsiExit.Text = "Exit";
            this.tsiExit.Click += new System.EventHandler(this.tsiExit_Click);
            // 
            // tsiAddTask
            // 
            this.tsiAddTask.Name = "tsiAddTask";
            this.tsiAddTask.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.tsiAddTask.Size = new System.Drawing.Size(68, 20);
            this.tsiAddTask.Text = "Add Task";
            this.tsiAddTask.Click += new System.EventHandler(this.tsiAddTask_Click);
            // 
            // tsiClearAllTasks
            // 
            this.tsiClearAllTasks.Name = "tsiClearAllTasks";
            this.tsiClearAllTasks.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.tsiClearAllTasks.Size = new System.Drawing.Size(95, 20);
            this.tsiClearAllTasks.Text = "Clear All Tasks";
            this.tsiClearAllTasks.Click += new System.EventHandler(this.tsiClearAllTasks_Click);
            // 
            // tsiAbout
            // 
            this.tsiAbout.Name = "tsiAbout";
            this.tsiAbout.Size = new System.Drawing.Size(52, 20);
            this.tsiAbout.Text = "About";
            this.tsiAbout.Click += new System.EventHandler(this.tsiAbout_Click);
            // 
            // pnlToDoList
            // 
            this.pnlToDoList.AutoScroll = true;
            this.pnlToDoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlToDoList.Location = new System.Drawing.Point(0, 24);
            this.pnlToDoList.Name = "pnlToDoList";
            this.pnlToDoList.Size = new System.Drawing.Size(584, 337);
            this.pnlToDoList.TabIndex = 0;
            this.pnlToDoList.TabStop = true;
            // 
            // ofd
            // 
            this.ofd.Title = "Open TODO List - TODO";
            this.ofd.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_FileOk);
            // 
            // sfd
            // 
            this.sfd.Title = "Save TODO List - TODO";
            this.sfd.FileOk += new System.ComponentModel.CancelEventHandler(this.sfd_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pnlToDoList);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.MinimumSize = new System.Drawing.Size(280, 200);
            this.Name = "Form1";
            this.Text = "No List Open - TODO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsiFile;
        private System.Windows.Forms.ToolStripMenuItem tsiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsiSave;
        private System.Windows.Forms.ToolStripMenuItem tsiExit;
        private System.Windows.Forms.Panel pnlToDoList;
        private System.Windows.Forms.ToolStripMenuItem tsiAddTask;
        private System.Windows.Forms.ToolStripMenuItem tsiNew;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.ToolStripMenuItem tsiClearAllTasks;
        private System.Windows.Forms.ToolStripMenuItem tsiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsiSaveAs;
    }
}

