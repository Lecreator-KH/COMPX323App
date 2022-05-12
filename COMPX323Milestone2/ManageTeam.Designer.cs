namespace COMPX323Milestone2
{
    partial class ManageTeam
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxTeamMember = new System.Windows.Forms.ListBox();
            this.buttonAddMember = new System.Windows.Forms.Button();
            this.buttonRemoveMember = new System.Windows.Forms.Button();
            this.buttonViewMember = new System.Windows.Forms.Button();
            this.buttonViewEvent = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSport = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team :";
            // 
            // txtTeamName
            // 
            this.txtTeamName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeamName.Location = new System.Drawing.Point(288, 31);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.ReadOnly = true;
            this.txtTeamName.Size = new System.Drawing.Size(313, 31);
            this.txtTeamName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(545, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Members";
            // 
            // listBoxTeamMember
            // 
            this.listBoxTeamMember.FormattingEnabled = true;
            this.listBoxTeamMember.Location = new System.Drawing.Point(478, 168);
            this.listBoxTeamMember.Name = "listBoxTeamMember";
            this.listBoxTeamMember.Size = new System.Drawing.Size(296, 264);
            this.listBoxTeamMember.TabIndex = 3;
            // 
            // buttonAddMember
            // 
            this.buttonAddMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMember.Location = new System.Drawing.Point(172, 168);
            this.buttonAddMember.Name = "buttonAddMember";
            this.buttonAddMember.Size = new System.Drawing.Size(110, 50);
            this.buttonAddMember.TabIndex = 4;
            this.buttonAddMember.Text = "Add Member";
            this.buttonAddMember.UseVisualStyleBackColor = true;
            this.buttonAddMember.Click += new System.EventHandler(this.buttonAddMember_Click);
            // 
            // buttonRemoveMember
            // 
            this.buttonRemoveMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveMember.Location = new System.Drawing.Point(172, 224);
            this.buttonRemoveMember.Name = "buttonRemoveMember";
            this.buttonRemoveMember.Size = new System.Drawing.Size(110, 50);
            this.buttonRemoveMember.TabIndex = 5;
            this.buttonRemoveMember.Text = "Remove Member";
            this.buttonRemoveMember.UseVisualStyleBackColor = true;
            // 
            // buttonViewMember
            // 
            this.buttonViewMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewMember.Location = new System.Drawing.Point(172, 280);
            this.buttonViewMember.Name = "buttonViewMember";
            this.buttonViewMember.Size = new System.Drawing.Size(110, 50);
            this.buttonViewMember.TabIndex = 6;
            this.buttonViewMember.Text = "View Member";
            this.buttonViewMember.UseVisualStyleBackColor = true;
            // 
            // buttonViewEvent
            // 
            this.buttonViewEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewEvent.Location = new System.Drawing.Point(172, 336);
            this.buttonViewEvent.Name = "buttonViewEvent";
            this.buttonViewEvent.Size = new System.Drawing.Size(110, 50);
            this.buttonViewEvent.TabIndex = 7;
            this.buttonViewEvent.Text = "View Event";
            this.buttonViewEvent.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sport";
            // 
            // textBoxSport
            // 
            this.textBoxSport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSport.Location = new System.Drawing.Point(288, 79);
            this.textBoxSport.Name = "textBoxSport";
            this.textBoxSport.ReadOnly = true;
            this.textBoxSport.Size = new System.Drawing.Size(163, 22);
            this.textBoxSport.TabIndex = 9;
            // 
            // Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonViewEvent);
            this.Controls.Add(this.buttonViewMember);
            this.Controls.Add(this.buttonRemoveMember);
            this.Controls.Add(this.buttonAddMember);
            this.Controls.Add(this.listBoxTeamMember);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.label1);
            this.Name = "Team";
            this.Text = "Team";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxTeamMember;
        private System.Windows.Forms.Button buttonAddMember;
        private System.Windows.Forms.Button buttonRemoveMember;
        private System.Windows.Forms.Button buttonViewMember;
        private System.Windows.Forms.Button buttonViewEvent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSport;
    }
}