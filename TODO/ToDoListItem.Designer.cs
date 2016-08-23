namespace TODO {
    partial class ToDoListItem {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtTask = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.chkDone = new System.Windows.Forms.CheckBox();
            this.btnDone = new BoinBoxNS.BoinBox();
            this.SuspendLayout();
            // 
            // txtTask
            // 
            this.txtTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTask.BackColor = System.Drawing.SystemColors.Control;
            this.txtTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTask.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTask.ForeColor = System.Drawing.Color.Black;
            this.txtTask.Location = new System.Drawing.Point(60, 3);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(222, 24);
            this.txtTask.TabIndex = 0;
            this.txtTask.Text = "your task here";
            this.txtTask.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTask_KeyDown);
            // 
            // txtNumber
            // 
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumber.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtNumber.Location = new System.Drawing.Point(24, 3);
            this.txtNumber.MaxLength = 3;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(30, 24);
            this.txtNumber.TabIndex = 0;
            this.txtNumber.TabStop = false;
            this.txtNumber.Text = "1";
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumber_KeyDown);
            this.txtNumber.Leave += new System.EventHandler(this.txtNumber_Leave);
            // 
            // chkDone
            // 
            this.chkDone.AutoSize = true;
            this.chkDone.Location = new System.Drawing.Point(3, 8);
            this.chkDone.Name = "chkDone";
            this.chkDone.Size = new System.Drawing.Size(15, 14);
            this.chkDone.TabIndex = 2;
            this.chkDone.TabStop = false;
            this.chkDone.UseVisualStyleBackColor = true;
            this.chkDone.CheckedChanged += new System.EventHandler(this.chkDone_CheckedChanged);
            // 
            // btnDone
            // 
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDone.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDone.BorderColor = System.Drawing.Color.Empty;
            this.btnDone.BorderSize = 0;
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnDone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnDone.Location = new System.Drawing.Point(288, 3);
            this.btnDone.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnDone.MouseOverBackColor = System.Drawing.Color.Empty;
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(20, 23);
            this.btnDone.TabIndex = 1;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "x";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // ToDoListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.chkDone);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.txtNumber);
            this.MinimumSize = new System.Drawing.Size(30, 0);
            this.Name = "ToDoListItem";
            this.Size = new System.Drawing.Size(312, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BoinBoxNS.BoinBox btnDone;
        public System.Windows.Forms.TextBox txtTask;
        public System.Windows.Forms.CheckBox chkDone;
        public System.Windows.Forms.TextBox txtNumber;
    }
}
