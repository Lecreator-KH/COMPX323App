namespace COMPX323Milestone2
{
    partial class Player
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
            this.textBoxSport = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUpcomingEvent = new System.Windows.Forms.Button();
            this.listBoxTeamMember = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPatEvent = new System.Windows.Forms.Button();
            this.buttonWatchEvent = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonMemShow = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxSport
            // 
            this.textBoxSport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSport.Location = new System.Drawing.Point(123, 62);
            this.textBoxSport.Name = "textBoxSport";
            this.textBoxSport.ReadOnly = true;
            this.textBoxSport.Size = new System.Drawing.Size(163, 22);
            this.textBoxSport.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Sport";
            // 
            // buttonUpcomingEvent
            // 
            this.buttonUpcomingEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpcomingEvent.Location = new System.Drawing.Point(456, 271);
            this.buttonUpcomingEvent.Name = "buttonUpcomingEvent";
            this.buttonUpcomingEvent.Size = new System.Drawing.Size(110, 50);
            this.buttonUpcomingEvent.TabIndex = 17;
            this.buttonUpcomingEvent.Text = "Upcoming Event";
            this.buttonUpcomingEvent.UseVisualStyleBackColor = true;
            this.buttonUpcomingEvent.Click += new System.EventHandler(this.buttonUpcomingEvent_Click);
            // 
            // listBoxTeamMember
            // 
            this.listBoxTeamMember.FormattingEnabled = true;
            this.listBoxTeamMember.Location = new System.Drawing.Point(154, 271);
            this.listBoxTeamMember.Name = "listBoxTeamMember";
            this.listBoxTeamMember.Size = new System.Drawing.Size(296, 264);
            this.listBoxTeamMember.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Members";
            // 
            // txtTeamName
            // 
            this.txtTeamName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeamName.Location = new System.Drawing.Point(123, 14);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.ReadOnly = true;
            this.txtTeamName.Size = new System.Drawing.Size(313, 31);
            this.txtTeamName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Team :";
            // 
            // buttonPatEvent
            // 
            this.buttonPatEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPatEvent.Location = new System.Drawing.Point(456, 327);
            this.buttonPatEvent.Name = "buttonPatEvent";
            this.buttonPatEvent.Size = new System.Drawing.Size(110, 50);
            this.buttonPatEvent.TabIndex = 20;
            this.buttonPatEvent.Text = "Past Event";
            this.buttonPatEvent.UseVisualStyleBackColor = true;
            this.buttonPatEvent.Click += new System.EventHandler(this.buttonPatEvent_Click);
            // 
            // buttonWatchEvent
            // 
            this.buttonWatchEvent.Enabled = false;
            this.buttonWatchEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWatchEvent.Location = new System.Drawing.Point(456, 383);
            this.buttonWatchEvent.Name = "buttonWatchEvent";
            this.buttonWatchEvent.Size = new System.Drawing.Size(110, 50);
            this.buttonWatchEvent.TabIndex = 21;
            this.buttonWatchEvent.Text = "Watch Event";
            this.buttonWatchEvent.UseVisualStyleBackColor = true;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(8, 105);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(153, 24);
            this.labelUserName.TabIndex = 22;
            this.labelUserName.Text = "Welcome User!";
            // 
            // buttonMemShow
            // 
            this.buttonMemShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMemShow.Location = new System.Drawing.Point(12, 271);
            this.buttonMemShow.Name = "buttonMemShow";
            this.buttonMemShow.Size = new System.Drawing.Size(110, 50);
            this.buttonMemShow.TabIndex = 23;
            this.buttonMemShow.Text = "Show members";
            this.buttonMemShow.UseVisualStyleBackColor = true;
            this.buttonMemShow.Click += new System.EventHandler(this.buttonMemShow_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(572, 271);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(311, 264);
            this.listBoxEvents.TabIndex = 24;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 558);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.buttonMemShow);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.buttonWatchEvent);
            this.Controls.Add(this.buttonPatEvent);
            this.Controls.Add(this.textBoxSport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonUpcomingEvent);
            this.Controls.Add(this.listBoxTeamMember);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.label1);
            this.Name = "Player";
            this.Text = "Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUpcomingEvent;
        private System.Windows.Forms.ListBox listBoxTeamMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPatEvent;
        private System.Windows.Forms.Button buttonWatchEvent;
        private System.Windows.Forms.Label labelUserName;
        public System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Button buttonMemShow;
        private System.Windows.Forms.ListBox listBoxEvents;
    }
}