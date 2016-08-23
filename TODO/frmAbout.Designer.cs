namespace TODO {
    partial class frmAbout {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.lblIconSite = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGitHub = new BoinBoxNS.BoinBox();
            this.btnIcons8 = new BoinBoxNS.BoinBox();
            this.btnClose = new BoinBoxNS.BoinBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(373, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TODO  - super cool task list";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(16, 39);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(56, 19);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(11, 58);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(61, 19);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version:";
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorName.Location = new System.Drawing.Point(74, 39);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(86, 19);
            this.lblAuthorName.TabIndex = 3;
            this.lblAuthorName.Text = "Collen Irwin";
            // 
            // txtVersion
            // 
            this.txtVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVersion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVersion.Location = new System.Drawing.Point(78, 58);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.ReadOnly = true;
            this.txtVersion.Size = new System.Drawing.Size(100, 20);
            this.txtVersion.TabIndex = 4;
            this.txtVersion.TabStop = false;
            this.txtVersion.Text = "1.0.0";
            // 
            // lblIconSite
            // 
            this.lblIconSite.AutoSize = true;
            this.lblIconSite.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconSite.Location = new System.Drawing.Point(4, 106);
            this.lblIconSite.Name = "lblIconSite";
            this.lblIconSite.Size = new System.Drawing.Size(68, 19);
            this.lblIconSite.TabIndex = 6;
            this.lblIconSite.Text = "Icon Site:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "GitHub:";
            // 
            // btnGitHub
            // 
            this.btnGitHub.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGitHub.BorderColor = System.Drawing.Color.Empty;
            this.btnGitHub.BorderSize = 0;
            this.btnGitHub.FlatAppearance.BorderSize = 0;
            this.btnGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGitHub.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnGitHub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnGitHub.Location = new System.Drawing.Point(78, 77);
            this.btnGitHub.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnGitHub.MouseOverBackColor = System.Drawing.Color.Empty;
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Size = new System.Drawing.Size(122, 23);
            this.btnGitHub.TabIndex = 10;
            this.btnGitHub.TabStop = false;
            this.btnGitHub.Text = "/collenirwin/TODO";
            this.btnGitHub.UseVisualStyleBackColor = false;
            this.btnGitHub.Click += new System.EventHandler(this.btnGitHub_Click);
            // 
            // btnIcons8
            // 
            this.btnIcons8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnIcons8.BorderColor = System.Drawing.Color.Empty;
            this.btnIcons8.BorderSize = 0;
            this.btnIcons8.FlatAppearance.BorderSize = 0;
            this.btnIcons8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcons8.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnIcons8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnIcons8.Location = new System.Drawing.Point(78, 106);
            this.btnIcons8.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnIcons8.MouseOverBackColor = System.Drawing.Color.Empty;
            this.btnIcons8.Name = "btnIcons8";
            this.btnIcons8.Size = new System.Drawing.Size(82, 23);
            this.btnIcons8.TabIndex = 8;
            this.btnIcons8.TabStop = false;
            this.btnIcons8.Text = "icons8.com";
            this.btnIcons8.UseVisualStyleBackColor = false;
            this.btnIcons8.Click += new System.EventHandler(this.btnIcons8_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClose.BorderColor = System.Drawing.Color.Empty;
            this.btnClose.BorderSize = 0;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnClose.Location = new System.Drawing.Point(285, 131);
            this.btnClose.MouseDownBackColor = System.Drawing.Color.Empty;
            this.btnClose.MouseOverBackColor = System.Drawing.Color.Empty;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 166);
            this.Controls.Add(this.btnGitHub);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIcons8);
            this.Controls.Add(this.lblIconSite);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.lblAuthorName);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About - TODO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.TextBox txtVersion;
        private BoinBoxNS.BoinBox btnClose;
        private System.Windows.Forms.Label lblIconSite;
        private BoinBoxNS.BoinBox btnIcons8;
        private BoinBoxNS.BoinBox btnGitHub;
        private System.Windows.Forms.Label label1;
    }
}