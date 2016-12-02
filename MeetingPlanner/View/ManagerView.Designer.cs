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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerView));
            this.AddMeetingButton = new System.Windows.Forms.Button();
            this.DeleteMeetingButton = new System.Windows.Forms.Button();
            this.UserLabelM = new System.Windows.Forms.Label();
            this.DayOfWeekBox = new System.Windows.Forms.PictureBox();
            this.LeftArrowButton = new System.Windows.Forms.Button();
            this.rightArrowButton = new System.Windows.Forms.Button();
            this.WeekOfLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MondayListBox = new System.Windows.Forms.ListBox();
            this.MondayLabel = new System.Windows.Forms.Label();
            this.TuesdayLabel = new System.Windows.Forms.Label();
            this.TuesdayListBox = new System.Windows.Forms.ListBox();
            this.WednesdayListBox = new System.Windows.Forms.ListBox();
            this.ThursdayListBox = new System.Windows.Forms.ListBox();
            this.FridayListBox = new System.Windows.Forms.ListBox();
            this.WednesdayLabel = new System.Windows.Forms.Label();
            this.ThurdayLabel = new System.Windows.Forms.Label();
            this.FridayLabel = new System.Windows.Forms.Label();
            this.LogoutEmployeeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DayOfWeekBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddMeetingButton
            // 
            this.AddMeetingButton.Location = new System.Drawing.Point(37, 99);
            this.AddMeetingButton.Name = "AddMeetingButton";
            this.AddMeetingButton.Size = new System.Drawing.Size(20, 23);
            this.AddMeetingButton.TabIndex = 0;
            this.AddMeetingButton.Text = "+";
            this.AddMeetingButton.UseVisualStyleBackColor = true;
            this.AddMeetingButton.UseWaitCursor = true;
            this.AddMeetingButton.Click += new System.EventHandler(this.AddMeetingButton_Click);
            // 
            // DeleteMeetingButton
            // 
            this.DeleteMeetingButton.Location = new System.Drawing.Point(37, 142);
            this.DeleteMeetingButton.Name = "DeleteMeetingButton";
            this.DeleteMeetingButton.Size = new System.Drawing.Size(20, 23);
            this.DeleteMeetingButton.TabIndex = 1;
            this.DeleteMeetingButton.Text = "+";
            this.DeleteMeetingButton.UseVisualStyleBackColor = true;
            this.DeleteMeetingButton.UseWaitCursor = true;
            this.DeleteMeetingButton.Click += new System.EventHandler(this.DeleteMeetingButton_Click);
            // 
            // UserLabelM
            // 
            this.UserLabelM.AutoSize = true;
            this.UserLabelM.Location = new System.Drawing.Point(13, 13);
            this.UserLabelM.Name = "UserLabelM";
            this.UserLabelM.Size = new System.Drawing.Size(0, 13);
            this.UserLabelM.TabIndex = 2;
            this.UserLabelM.UseWaitCursor = true;
            // 
            // DayOfWeekBox
            // 
            this.DayOfWeekBox.BackColor = System.Drawing.Color.LightGray;
            this.DayOfWeekBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DayOfWeekBox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.DayOfWeekBox.Location = new System.Drawing.Point(181, 50);
            this.DayOfWeekBox.Name = "DayOfWeekBox";
            this.DayOfWeekBox.Size = new System.Drawing.Size(652, 57);
            this.DayOfWeekBox.TabIndex = 7;
            this.DayOfWeekBox.TabStop = false;
            this.DayOfWeekBox.UseWaitCursor = true;
            // 
            // LeftArrowButton
            // 
            this.LeftArrowButton.BackColor = System.Drawing.Color.Transparent;
            this.LeftArrowButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftArrowButton.BackgroundImage")));
            this.LeftArrowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftArrowButton.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.LeftArrowButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.LeftArrowButton.Location = new System.Drawing.Point(195, 61);
            this.LeftArrowButton.Name = "LeftArrowButton";
            this.LeftArrowButton.Size = new System.Drawing.Size(75, 36);
            this.LeftArrowButton.TabIndex = 22;
            this.LeftArrowButton.UseVisualStyleBackColor = false;
            this.LeftArrowButton.UseWaitCursor = true;
            this.LeftArrowButton.Click += new System.EventHandler(this.LeftArrowButton_Click);
            // 
            // rightArrowButton
            // 
            this.rightArrowButton.BackColor = System.Drawing.Color.LightGray;
            this.rightArrowButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightArrowButton.BackgroundImage")));
            this.rightArrowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightArrowButton.Location = new System.Drawing.Point(745, 61);
            this.rightArrowButton.Name = "rightArrowButton";
            this.rightArrowButton.Size = new System.Drawing.Size(75, 36);
            this.rightArrowButton.TabIndex = 23;
            this.rightArrowButton.UseVisualStyleBackColor = false;
            this.rightArrowButton.UseWaitCursor = true;
            this.rightArrowButton.Click += new System.EventHandler(this.rightArrowButton_Click);
            // 
            // WeekOfLabel
            // 
            this.WeekOfLabel.AutoSize = true;
            this.WeekOfLabel.BackColor = System.Drawing.Color.LightGray;
            this.WeekOfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekOfLabel.Location = new System.Drawing.Point(333, 61);
            this.WeekOfLabel.Name = "WeekOfLabel";
            this.WeekOfLabel.Size = new System.Drawing.Size(126, 31);
            this.WeekOfLabel.TabIndex = 24;
            this.WeekOfLabel.Text = "Week Of ";
            this.WeekOfLabel.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 146);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Home";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(63, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Add Meeting";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(63, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Delete Meeting";
            // 
            // MondayListBox
            // 
            this.MondayListBox.FormattingEnabled = true;
            this.MondayListBox.Location = new System.Drawing.Point(181, 129);
            this.MondayListBox.Name = "MondayListBox";
            this.MondayListBox.Size = new System.Drawing.Size(131, 186);
            this.MondayListBox.TabIndex = 29;
            // 
            // MondayLabel
            // 
            this.MondayLabel.AutoSize = true;
            this.MondayLabel.Location = new System.Drawing.Point(178, 113);
            this.MondayLabel.Name = "MondayLabel";
            this.MondayLabel.Size = new System.Drawing.Size(45, 13);
            this.MondayLabel.TabIndex = 30;
            this.MondayLabel.Text = "Monday";
            // 
            // TuesdayLabel
            // 
            this.TuesdayLabel.AutoSize = true;
            this.TuesdayLabel.Location = new System.Drawing.Point(305, 113);
            this.TuesdayLabel.Name = "TuesdayLabel";
            this.TuesdayLabel.Size = new System.Drawing.Size(48, 13);
            this.TuesdayLabel.TabIndex = 31;
            this.TuesdayLabel.Text = "Tuesday";
            // 
            // TuesdayListBox
            // 
            this.TuesdayListBox.FormattingEnabled = true;
            this.TuesdayListBox.Location = new System.Drawing.Point(308, 129);
            this.TuesdayListBox.Name = "TuesdayListBox";
            this.TuesdayListBox.Size = new System.Drawing.Size(134, 186);
            this.TuesdayListBox.TabIndex = 32;
            // 
            // WednesdayListBox
            // 
            this.WednesdayListBox.FormattingEnabled = true;
            this.WednesdayListBox.Location = new System.Drawing.Point(439, 129);
            this.WednesdayListBox.Name = "WednesdayListBox";
            this.WednesdayListBox.Size = new System.Drawing.Size(131, 186);
            this.WednesdayListBox.TabIndex = 33;
            // 
            // ThursdayListBox
            // 
            this.ThursdayListBox.FormattingEnabled = true;
            this.ThursdayListBox.Location = new System.Drawing.Point(565, 129);
            this.ThursdayListBox.Name = "ThursdayListBox";
            this.ThursdayListBox.Size = new System.Drawing.Size(143, 186);
            this.ThursdayListBox.TabIndex = 34;
            // 
            // FridayListBox
            // 
            this.FridayListBox.FormattingEnabled = true;
            this.FridayListBox.Location = new System.Drawing.Point(702, 129);
            this.FridayListBox.Name = "FridayListBox";
            this.FridayListBox.Size = new System.Drawing.Size(131, 186);
            this.FridayListBox.TabIndex = 35;
            // 
            // WednesdayLabel
            // 
            this.WednesdayLabel.AutoSize = true;
            this.WednesdayLabel.Location = new System.Drawing.Point(436, 113);
            this.WednesdayLabel.Name = "WednesdayLabel";
            this.WednesdayLabel.Size = new System.Drawing.Size(64, 13);
            this.WednesdayLabel.TabIndex = 36;
            this.WednesdayLabel.Text = "Wednesday";
            // 
            // ThurdayLabel
            // 
            this.ThurdayLabel.AutoSize = true;
            this.ThurdayLabel.Location = new System.Drawing.Point(562, 113);
            this.ThurdayLabel.Name = "ThurdayLabel";
            this.ThurdayLabel.Size = new System.Drawing.Size(51, 13);
            this.ThurdayLabel.TabIndex = 37;
            this.ThurdayLabel.Text = "Thursday";
            // 
            // FridayLabel
            // 
            this.FridayLabel.AutoSize = true;
            this.FridayLabel.Location = new System.Drawing.Point(699, 113);
            this.FridayLabel.Name = "FridayLabel";
            this.FridayLabel.Size = new System.Drawing.Size(35, 13);
            this.FridayLabel.TabIndex = 38;
            this.FridayLabel.Text = "Friday";
            // 
            // LogoutEmployeeButton
            // 
            this.LogoutEmployeeButton.Location = new System.Drawing.Point(758, 360);
            this.LogoutEmployeeButton.Name = "LogoutEmployeeButton";
            this.LogoutEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutEmployeeButton.TabIndex = 39;
            this.LogoutEmployeeButton.Text = "Logout";
            this.LogoutEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // ManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 395);
            this.Controls.Add(this.LogoutEmployeeButton);
            this.Controls.Add(this.FridayLabel);
            this.Controls.Add(this.ThurdayLabel);
            this.Controls.Add(this.WednesdayLabel);
            this.Controls.Add(this.FridayListBox);
            this.Controls.Add(this.ThursdayListBox);
            this.Controls.Add(this.WednesdayListBox);
            this.Controls.Add(this.TuesdayListBox);
            this.Controls.Add(this.TuesdayLabel);
            this.Controls.Add(this.MondayLabel);
            this.Controls.Add(this.MondayListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WeekOfLabel);
            this.Controls.Add(this.rightArrowButton);
            this.Controls.Add(this.LeftArrowButton);
            this.Controls.Add(this.DayOfWeekBox);
            this.Controls.Add(this.UserLabelM);
            this.Controls.Add(this.DeleteMeetingButton);
            this.Controls.Add(this.AddMeetingButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManagerView";
            this.Text = "Manager";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.DayOfWeekBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddMeetingButton;
        private System.Windows.Forms.Button DeleteMeetingButton;
        private System.Windows.Forms.Label UserLabelM;
        private System.Windows.Forms.PictureBox DayOfWeekBox;
        private System.Windows.Forms.Button LeftArrowButton;
        private System.Windows.Forms.Button rightArrowButton;
        private System.Windows.Forms.Label WeekOfLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox MondayListBox;
        private System.Windows.Forms.Label MondayLabel;
        private System.Windows.Forms.Label TuesdayLabel;
        private System.Windows.Forms.ListBox TuesdayListBox;
        private System.Windows.Forms.ListBox WednesdayListBox;
        private System.Windows.Forms.ListBox ThursdayListBox;
        private System.Windows.Forms.ListBox FridayListBox;
        private System.Windows.Forms.Label WednesdayLabel;
        private System.Windows.Forms.Label ThurdayLabel;
        private System.Windows.Forms.Label FridayLabel;
        private System.Windows.Forms.Button LogoutEmployeeButton;
    }
}