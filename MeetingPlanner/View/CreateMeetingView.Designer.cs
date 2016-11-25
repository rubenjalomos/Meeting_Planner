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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.MeetingDateLabel = new System.Windows.Forms.Label();
            this.GroupTitleLabel = new System.Windows.Forms.Label();
            this.MeetingDurationLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.CancelCreateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(245, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(245, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(245, 182);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(191, 20);
            this.textBox4.TabIndex = 3;
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
            // CreateMeetingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 261);
            this.Controls.Add(this.CancelCreateButton);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.MeetingDurationLabel);
            this.Controls.Add(this.GroupTitleLabel);
            this.Controls.Add(this.MeetingDateLabel);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "CreateMeetingView";
            this.Text = "CreateMeeting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label MeetingDateLabel;
        private System.Windows.Forms.Label GroupTitleLabel;
        private System.Windows.Forms.Label MeetingDurationLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Button CancelCreateButton;
    }
}