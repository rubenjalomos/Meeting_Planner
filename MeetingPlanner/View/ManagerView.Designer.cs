namespace MeetingPlanner.View
{
    partial class ManagerView
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
            this.AddMeetingButton = new System.Windows.Forms.Button();
            this.DeleteMeetingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddMeetingButton
            // 
            this.AddMeetingButton.Location = new System.Drawing.Point(37, 116);
            this.AddMeetingButton.Name = "AddMeetingButton";
            this.AddMeetingButton.Size = new System.Drawing.Size(87, 23);
            this.AddMeetingButton.TabIndex = 0;
            this.AddMeetingButton.Text = "Add Meeting";
            this.AddMeetingButton.UseVisualStyleBackColor = true;
            this.AddMeetingButton.UseWaitCursor = true;
            this.AddMeetingButton.Click += new System.EventHandler(this.AddMeetingButton_Click);
            // 
            // DeleteMeetingButton
            // 
            this.DeleteMeetingButton.Location = new System.Drawing.Point(37, 169);
            this.DeleteMeetingButton.Name = "DeleteMeetingButton";
            this.DeleteMeetingButton.Size = new System.Drawing.Size(87, 23);
            this.DeleteMeetingButton.TabIndex = 1;
            this.DeleteMeetingButton.Text = "Delete Meeting";
            this.DeleteMeetingButton.UseVisualStyleBackColor = true;
            this.DeleteMeetingButton.Click += new System.EventHandler(this.DeleteMeetingButton_Click);
            // 
            // ManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 363);
            this.Controls.Add(this.DeleteMeetingButton);
            this.Controls.Add(this.AddMeetingButton);
            this.Name = "ManagerView";
            this.Text = "Manager";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddMeetingButton;
        private System.Windows.Forms.Button DeleteMeetingButton;
    }
}