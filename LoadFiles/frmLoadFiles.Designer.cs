﻿namespace LoadFiles
{
    partial class frmLoadFiles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxFiles = new System.Windows.Forms.ListBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxFiles
            // 
            this.lbxFiles.FormattingEnabled = true;
            this.lbxFiles.Location = new System.Drawing.Point(13, 13);
            this.lbxFiles.Name = "lbxFiles";
            this.lbxFiles.Size = new System.Drawing.Size(120, 407);
            this.lbxFiles.TabIndex = 0;
            this.lbxFiles.SelectedIndexChanged += new System.EventHandler(this.lbxFiles_SelectedIndexChanged);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(140, 13);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(329, 407);
            this.txtContent.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(13, 426);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(120, 40);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(139, 426);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Bewaren";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.Filter = "tekstbestanden|*.txt";
            this.ofd.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_FileOk);
            // 
            // sfd
            // 
            this.sfd.Filter = "tekstbestanden|*.txt";
            this.sfd.FileOk += new System.ComponentModel.CancelEventHandler(this.sfd_FileOk);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(305, 426);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(164, 40);
            this.btnSaveAs.TabIndex = 4;
            this.btnSaveAs.Text = "Bewaar als";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // frmLoadFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 478);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lbxFiles);
            this.Name = "frmLoadFiles";
            this.Text = "LoadFiles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxFiles;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button btnSaveAs;
    }
}

