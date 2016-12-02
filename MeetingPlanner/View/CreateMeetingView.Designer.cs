namespace MeetingPlanner.View
{
    partial class CreateMeetingView
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
            this.GroupTitleTextBox = new System.Windows.Forms.TextBox();
            this.meetingDurationtextBox = new System.Windows.Forms.TextBox();
            this.locaitonTextBox = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.MeetingDateLabel = new System.Windows.Forms.Label();
            this.GroupTitleLabel = new System.Windows.Forms.Label();
            this.MeetingDurationLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.CancelCreateButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UserLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GroupTitleTextBox
            // 
            this.GroupTitleTextBox.Location = new System.Drawing.Point(245, 91);
            this.GroupTitleTextBox.Name = "GroupTitleTextBox";
            this.GroupTitleTextBox.Size = new System.Drawing.Size(191, 20);
            this.GroupTitleTextBox.TabIndex = 1;
            // 
            // meetingDurationtextBox
            // 
            this.meetingDurationtextBox.Location = new System.Drawing.Point(245, 135);
            this.meetingDurationtextBox.Name = "meetingDurationtextBox";
            this.meetingDurationtextBox.Size = new System.Drawing.Size(191, 20);
            this.meetingDurationtextBox.TabIndex = 2;
            // 
            // locaitonTextBox
            // 
            this.locaitonTextBox.Location = new System.Drawing.Point(245, 182);
            this.locaitonTextBox.Name = "locaitonTextBox";
            this.locaitonTextBox.Size = new System.Drawing.Size(191, 20);
            this.locaitonTextBox.TabIndex = 3;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(361, 226);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 4;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // MeetingDateLabel
            // 
            this.MeetingDateLabel.AutoSize = true;
            this.MeetingDateLabel.Location = new System.Drawing.Point(78, 60);
            this.MeetingDateLabel.Name = "MeetingDateLabel";
            this.MeetingDateLabel.Size = new System.Drawing.Size(71, 13);
            this.MeetingDateLabel.TabIndex = 5;
            this.MeetingDateLabel.Text = "Meeting Date";
            // 
            // GroupTitleLabel
            // 
            this.GroupTitleLabel.AutoSize = true;
            this.GroupTitleLabel.Location = new System.Drawing.Point(78, 94);
            this.GroupTitleLabel.Name = "GroupTitleLabel";
            this.GroupTitleLabel.Size = new System.Drawing.Size(80, 13);
            this.GroupTitleLabel.TabIndex = 6;
            this.GroupTitleLabel.Text = "Group and Title";
            // 
            // MeetingDurationLabel
            // 
            this.MeetingDurationLabel.AutoSize = true;
            this.MeetingDurationLabel.Location = new System.Drawing.Point(78, 140);
            this.MeetingDurationLabel.Name = "MeetingDurationLabel";
            this.MeetingDurationLabel.Size = new System.Drawing.Size(88, 13);
            this.MeetingDurationLabel.TabIndex = 7;
            this.MeetingDurationLabel.Text = "Meeting Duration";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Location = new System.Drawing.Point(78, 189);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(48, 13);
            this.LocationLabel.TabIndex = 8;
            this.LocationLabel.Text = "Location";
            // 
            // CancelCreateButton
            // 
            this.CancelCreateButton.Location = new System.Drawing.Point(264, 226);
            this.CancelCreateButton.Name = "CancelCreateButton";
            this.CancelCreateButton.Size = new System.Drawing.Size(75, 23);
            this.CancelCreateButton.TabIndex = 9;
            this.CancelCreateButton.Text = "Cancel";
            this.CancelCreateButton.UseVisualStyleBackColor = true;
            this.CancelCreateButton.Click += new System.EventHandler(this.CancelCreateButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(245, 54);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker.TabIndex = 10;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(29, 13);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(0, 13);
            this.UserLabel.TabIndex = 11;
            // 
            // CreateMeetingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 261);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.CancelCreateButton);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.MeetingDurationLabel);
            this.Controls.Add(this.GroupTitleLabel);
            this.Controls.Add(this.MeetingDateLabel);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.locaitonTextBox);
            this.Controls.Add(this.meetingDurationtextBox);
            this.Controls.Add(this.GroupTitleTextBox);
            this.Name = "CreateMeetingView";
            this.Text = "CreateMeeting";
            this.Load += new System.EventHandler(this.CreateMeetingView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox GroupTitleTextBox;
        private System.Windows.Forms.TextBox meetingDurationtextBox;
        private System.Windows.Forms.TextBox locaitonTextBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label MeetingDateLabel;
        private System.Windows.Forms.Label GroupTitleLabel;
        private System.Windows.Forms.Label MeetingDurationLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Button CancelCreateButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label UserLabel;
    }
}