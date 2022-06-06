namespace COMPX323Milestone2
{
    partial class Organizer
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonPastEvent = new System.Windows.Forms.Button();
            this.buttonUpcomingEvent = new System.Windows.Forms.Button();
            this.listBoxEvent = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddEvent = new System.Windows.Forms.Button();
            this.txtOrganiserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(221, 108);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(153, 24);
            this.labelUserName.TabIndex = 32;
            this.labelUserName.Text = "Welcome User!";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(150, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 50);
            this.button2.TabIndex = 31;
            this.button2.Text = "Watch Event";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonPastEvent
            // 
            this.buttonPastEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPastEvent.Location = new System.Drawing.Point(9, 333);
            this.buttonPastEvent.Name = "buttonPastEvent";
            this.buttonPastEvent.Size = new System.Drawing.Size(110, 50);
            this.buttonPastEvent.TabIndex = 30;
            this.buttonPastEvent.Text = "Past Event";
            this.buttonPastEvent.UseVisualStyleBackColor = true;
            this.buttonPastEvent.Click += new System.EventHandler(this.buttonPastEvent_Click);
            // 
            // buttonUpcomingEvent
            // 
            this.buttonUpcomingEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpcomingEvent.Location = new System.Drawing.Point(150, 264);
            this.buttonUpcomingEvent.Name = "buttonUpcomingEvent";
            this.buttonUpcomingEvent.Size = new System.Drawing.Size(110, 50);
            this.buttonUpcomingEvent.TabIndex = 27;
            this.buttonUpcomingEvent.Text = "Upcoming Event";
            this.buttonUpcomingEvent.UseVisualStyleBackColor = true;
            this.buttonUpcomingEvent.Click += new System.EventHandler(this.buttonUpcomingEvent_Click);
            // 
            // listBoxEvent
            // 
            this.listBoxEvent.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEvent.FormattingEnabled = true;
            this.listBoxEvent.Location = new System.Drawing.Point(266, 264);
            this.listBoxEvent.Name = "listBoxEvent";
            this.listBoxEvent.Size = new System.Drawing.Size(524, 264);
            this.listBoxEvent.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(534, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Events";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Organisation :";
            // 
            // buttonAddEvent
            // 
            this.buttonAddEvent.Enabled = false;
            this.buttonAddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddEvent.Location = new System.Drawing.Point(9, 264);
            this.buttonAddEvent.Name = "buttonAddEvent";
            this.buttonAddEvent.Size = new System.Drawing.Size(110, 50);
            this.buttonAddEvent.TabIndex = 33;
            this.buttonAddEvent.Text = "Add Event";
            this.buttonAddEvent.UseVisualStyleBackColor = true;
            this.buttonAddEvent.Click += new System.EventHandler(this.buttonAddEvent_Click);
            // 
            // txtOrganiserName
            // 
            this.txtOrganiserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrganiserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrganiserName.Location = new System.Drawing.Point(266, 18);
            this.txtOrganiserName.Name = "txtOrganiserName";
            this.txtOrganiserName.ReadOnly = true;
            this.txtOrganiserName.Size = new System.Drawing.Size(313, 31);
            this.txtOrganiserName.TabIndex = 34;
            // 
            // Organizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 546);
            this.Controls.Add(this.txtOrganiserName);
            this.Controls.Add(this.buttonAddEvent);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonPastEvent);
            this.Controls.Add(this.buttonUpcomingEvent);
            this.Controls.Add(this.listBoxEvent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Organizer";
            this.Text = "Organizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonPastEvent;
        private System.Windows.Forms.Button buttonUpcomingEvent;
        private System.Windows.Forms.ListBox listBoxEvent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddEvent;
        public System.Windows.Forms.TextBox txtOrganiserName;
    }
}