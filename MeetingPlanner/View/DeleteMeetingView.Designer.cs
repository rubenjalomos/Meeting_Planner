namespace MeetingPlanner.View
{
    partial class DeleteMeetingView
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
            this.MeetingsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // MeetingsListBox
            // 
            this.MeetingsListBox.FormattingEnabled = true;
            this.MeetingsListBox.HorizontalScrollbar = true;
            this.MeetingsListBox.Location = new System.Drawing.Point(55, 30);
            this.MeetingsListBox.Name = "MeetingsListBox";
            this.MeetingsListBox.ScrollAlwaysVisible = true;
            this.MeetingsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.MeetingsListBox.Size = new System.Drawing.Size(201, 186);
            this.MeetingsListBox.Sorted = true;
            this.MeetingsListBox.TabIndex = 0;
            // 
            // DeleteMeetingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.MeetingsListBox);
            this.Name = "DeleteMeetingView";
            this.Text = "DeleteMeeting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox MeetingsListBox;
    }
}