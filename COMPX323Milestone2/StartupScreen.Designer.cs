﻿namespace COMPX323Milestone2
{
    partial class StartupScreen
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
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonLoginViewer = new System.Windows.Forms.Button();
            this.buttonLoginOrganiser = new System.Windows.Forms.Button();
            this.buttonLoginTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(541, 130);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(200, 58);
            this.buttonRegister.TabIndex = 0;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonLoginTeam_Click);
            // 
            // buttonLoginViewer
            // 
            this.buttonLoginViewer.Location = new System.Drawing.Point(541, 284);
            this.buttonLoginViewer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLoginViewer.Name = "buttonLoginViewer";
            this.buttonLoginViewer.Size = new System.Drawing.Size(200, 58);
            this.buttonLoginViewer.TabIndex = 1;
            this.buttonLoginViewer.Text = "login as a viewer";
            this.buttonLoginViewer.UseVisualStyleBackColor = true;
            this.buttonLoginViewer.Click += new System.EventHandler(this.buttonLoginViewer_Click);
            // 
            // buttonLoginOrganiser
            // 
            this.buttonLoginOrganiser.Location = new System.Drawing.Point(541, 367);
            this.buttonLoginOrganiser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLoginOrganiser.Name = "buttonLoginOrganiser";
            this.buttonLoginOrganiser.Size = new System.Drawing.Size(200, 58);
            this.buttonLoginOrganiser.TabIndex = 2;
            this.buttonLoginOrganiser.Text = "login as a organiser";
            this.buttonLoginOrganiser.UseVisualStyleBackColor = true;
            this.buttonLoginOrganiser.Click += new System.EventHandler(this.buttonLoginOrganiser_Click);
            // 
            // buttonLoginTeam
            // 
            this.buttonLoginTeam.Location = new System.Drawing.Point(541, 205);
            this.buttonLoginTeam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLoginTeam.Name = "buttonLoginTeam";
            this.buttonLoginTeam.Size = new System.Drawing.Size(200, 58);
            this.buttonLoginTeam.TabIndex = 3;
            this.buttonLoginTeam.Text = "login as a team";
            this.buttonLoginTeam.UseVisualStyleBackColor = true;
            this.buttonLoginTeam.Click += new System.EventHandler(this.buttonTeam_Click);
            // 
            // StartupScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 519);
            this.Controls.Add(this.buttonLoginTeam);
            this.Controls.Add(this.buttonLoginOrganiser);
            this.Controls.Add(this.buttonLoginViewer);
            this.Controls.Add(this.buttonRegister);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "StartupScreen";
            this.Text = "StartupScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonLoginViewer;
        private System.Windows.Forms.Button buttonLoginOrganiser;
        private System.Windows.Forms.Button buttonLoginTeam;
    }
}

