namespace COMPX323Milestone2
{
    partial class Form1
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
            this.buttonLoginTeam = new System.Windows.Forms.Button();
            this.buttonLoginViewer = new System.Windows.Forms.Button();
            this.buttonLoginOrganiser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoginTeam
            // 
            this.buttonLoginTeam.Location = new System.Drawing.Point(406, 122);
            this.buttonLoginTeam.Name = "buttonLoginTeam";
            this.buttonLoginTeam.Size = new System.Drawing.Size(150, 50);
            this.buttonLoginTeam.TabIndex = 0;
            this.buttonLoginTeam.Text = "login as a team";
            this.buttonLoginTeam.UseVisualStyleBackColor = true;
            this.buttonLoginTeam.Click += new System.EventHandler(this.buttonLoginTeam_Click);
            // 
            // buttonLoginViewer
            // 
            this.buttonLoginViewer.Location = new System.Drawing.Point(406, 199);
            this.buttonLoginViewer.Name = "buttonLoginViewer";
            this.buttonLoginViewer.Size = new System.Drawing.Size(150, 50);
            this.buttonLoginViewer.TabIndex = 1;
            this.buttonLoginViewer.Text = "login as a viewer";
            this.buttonLoginViewer.UseVisualStyleBackColor = true;
            this.buttonLoginViewer.Click += new System.EventHandler(this.buttonLoginViewer_Click);
            // 
            // buttonLoginOrganiser
            // 
            this.buttonLoginOrganiser.Location = new System.Drawing.Point(406, 271);
            this.buttonLoginOrganiser.Name = "buttonLoginOrganiser";
            this.buttonLoginOrganiser.Size = new System.Drawing.Size(150, 50);
            this.buttonLoginOrganiser.TabIndex = 2;
            this.buttonLoginOrganiser.Text = "login as a organiser";
            this.buttonLoginOrganiser.UseVisualStyleBackColor = true;
            this.buttonLoginOrganiser.Click += new System.EventHandler(this.buttonLoginOrganiser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLoginOrganiser);
            this.Controls.Add(this.buttonLoginViewer);
            this.Controls.Add(this.buttonLoginTeam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoginTeam;
        private System.Windows.Forms.Button buttonLoginViewer;
        private System.Windows.Forms.Button buttonLoginOrganiser;
    }
}

