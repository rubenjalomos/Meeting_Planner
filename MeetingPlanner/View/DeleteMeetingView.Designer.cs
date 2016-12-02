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
            this.DeleteSelectedButton = new System.Windows.Forms.Button();
            this.UserLabelDM = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
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
            this.MeetingsListBox.Size = new System.Drawing.Size(287, 186);
            this.MeetingsListBox.Sorted = true;
            this.MeetingsListBox.TabIndex = 0;
            // 
            // DeleteSelectedButton
            // 
            this.DeleteSelectedButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.DeleteSelectedButton.Location = new System.Drawing.Point(267, 226);
            this.DeleteSelectedButton.Name = "DeleteSelectedButton";
            this.DeleteSelectedButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteSelectedButton.TabIndex = 1;
            this.DeleteSelectedButton.Text = "Delete";
            this.DeleteSelectedButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedButton.Click += new System.EventHandler(this.DeleteSelectedButton_Click);
            // 
            // UserLabelDM
            // 
            this.UserLabelDM.AutoSize = true;
            this.UserLabelDM.Location = new System.Drawing.Point(13, 13);
            this.UserLabelDM.Name = "UserLabelDM";
            this.UserLabelDM.Size = new System.Drawing.Size(0, 13);
            this.UserLabelDM.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.cancelButton.Location = new System.Drawing.Point(55, 226);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // DeleteMeetingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 261);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.UserLabelDM);
            this.Controls.Add(this.DeleteSelectedButton);
            this.Controls.Add(this.MeetingsListBox);
            this.Name = "DeleteMeetingView";
            this.Text = "DeleteMeeting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MeetingsListBox;
        private System.Windows.Forms.Button DeleteSelectedButton;
        private System.Windows.Forms.Label UserLabelDM;
        private System.Windows.Forms.Button cancelButton;
    }
}