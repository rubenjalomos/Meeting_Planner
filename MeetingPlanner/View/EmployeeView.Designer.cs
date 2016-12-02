namespace MeetingPlanner.View
{
    partial class EmployeeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeView));
            this.AddMeetingButtonEmployee = new System.Windows.Forms.Button();
            this.LogoutEmployeeButton = new System.Windows.Forms.Button();
            this.UserLabelE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DayOfWeekBox = new System.Windows.Forms.PictureBox();
            this.WeekOfLabel = new System.Windows.Forms.Label();
            this.MondayLabel = new System.Windows.Forms.Label();
            this.TuesdayLabel = new System.Windows.Forms.Label();
            this.WednesdayLabel = new System.Windows.Forms.Label();
            this.ThurdayLabel = new System.Windows.Forms.Label();
            this.FridayLabel = new System.Windows.Forms.Label();
            this.LeftArrowButton = new System.Windows.Forms.Button();
            this.rightArrowButton = new System.Windows.Forms.Button();
            this.MondayListBox = new System.Windows.Forms.ListBox();
            this.TuesdayListBox = new System.Windows.Forms.ListBox();
            this.WednesdayListBox = new System.Windows.Forms.ListBox();
            this.ThursdayListBox = new System.Windows.Forms.ListBox();
            this.FridayListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DayOfWeekBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AddMeetingButtonEmployee
            // 
            this.AddMeetingButtonEmployee.Location = new System.Drawing.Point(46, 113);
            this.AddMeetingButtonEmployee.Name = "AddMeetingButtonEmployee";
            this.AddMeetingButtonEmployee.Size = new System.Drawing.Size(21, 23);
            this.AddMeetingButtonEmployee.TabIndex = 0;
            this.AddMeetingButtonEmployee.Text = "+";
            this.AddMeetingButtonEmployee.UseVisualStyleBackColor = true;
            this.AddMeetingButtonEmployee.Click += new System.EventHandler(this.AddMeetingButtonEmployee_Click);
            // 
            // LogoutEmployeeButton
            // 
            this.LogoutEmployeeButton.Location = new System.Drawing.Point(758, 360);
            this.LogoutEmployeeButton.Name = "LogoutEmployeeButton";
            this.LogoutEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutEmployeeButton.TabIndex = 1;
            this.LogoutEmployeeButton.Text = "Logout";
            this.LogoutEmployeeButton.UseVisualStyleBackColor = true;
            this.LogoutEmployeeButton.Click += new System.EventHandler(this.LogoutEmployeeButton_Click);
            // 
            // UserLabelE
            // 
            this.UserLabelE.AutoSize = true;
            this.UserLabelE.Location = new System.Drawing.Point(25, 13);
            this.UserLabelE.Name = "UserLabelE";
            this.UserLabelE.Size = new System.Drawing.Size(0, 13);
            this.UserLabelE.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(73, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Meeting";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 158);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(32, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Home";
            // 
            // DayOfWeekBox
            // 
            this.DayOfWeekBox.BackColor = System.Drawing.Color.LightGray;
            this.DayOfWeekBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DayOfWeekBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DayOfWeekBox.Location = new System.Drawing.Point(181, 52);
            this.DayOfWeekBox.Name = "DayOfWeekBox";
            this.DayOfWeekBox.Size = new System.Drawing.Size(652, 57);
            this.DayOfWeekBox.TabIndex = 6;
            this.DayOfWeekBox.TabStop = false;
            // 
            // WeekOfLabel
            // 
            this.WeekOfLabel.AutoSize = true;
            this.WeekOfLabel.BackColor = System.Drawing.Color.LightGray;
            this.WeekOfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekOfLabel.Location = new System.Drawing.Point(367, 62);
            this.WeekOfLabel.Name = "WeekOfLabel";
            this.WeekOfLabel.Size = new System.Drawing.Size(126, 31);
            this.WeekOfLabel.TabIndex = 7;
            this.WeekOfLabel.Text = "Week Of ";
            this.WeekOfLabel.Click += new System.EventHandler(this.WeekOfLabel_Click);
            // 
            // MondayLabel
            // 
            this.MondayLabel.AutoSize = true;
            this.MondayLabel.Location = new System.Drawing.Point(181, 112);
            this.MondayLabel.Name = "MondayLabel";
            this.MondayLabel.Size = new System.Drawing.Size(45, 13);
            this.MondayLabel.TabIndex = 16;
            this.MondayLabel.Text = "Monday";
            // 
            // TuesdayLabel
            // 
            this.TuesdayLabel.AutoSize = true;
            this.TuesdayLabel.Location = new System.Drawing.Point(307, 112);
            this.TuesdayLabel.Name = "TuesdayLabel";
            this.TuesdayLabel.Size = new System.Drawing.Size(48, 13);
            this.TuesdayLabel.TabIndex = 17;
            this.TuesdayLabel.Text = "Tuesday";
            // 
            // WednesdayLabel
            // 
            this.WednesdayLabel.AutoSize = true;
            this.WednesdayLabel.Location = new System.Drawing.Point(439, 112);
            this.WednesdayLabel.Name = "WednesdayLabel";
            this.WednesdayLabel.Size = new System.Drawing.Size(64, 13);
            this.WednesdayLabel.TabIndex = 18;
            this.WednesdayLabel.Text = "Wednesday";
            // 
            // ThurdayLabel
            // 
            this.ThurdayLabel.AutoSize = true;
            this.ThurdayLabel.Location = new System.Drawing.Point(568, 112);
            this.ThurdayLabel.Name = "ThurdayLabel";
            this.ThurdayLabel.Size = new System.Drawing.Size(51, 13);
            this.ThurdayLabel.TabIndex = 19;
            this.ThurdayLabel.Text = "Thursday";
            // 
            // FridayLabel
            // 
            this.FridayLabel.AutoSize = true;
            this.FridayLabel.Location = new System.Drawing.Point(699, 112);
            this.FridayLabel.Name = "FridayLabel";
            this.FridayLabel.Size = new System.Drawing.Size(35, 13);
            this.FridayLabel.TabIndex = 20;
            this.FridayLabel.Text = "Friday";
            // 
            // LeftArrowButton
            // 
            this.LeftArrowButton.BackColor = System.Drawing.Color.Transparent;
            this.LeftArrowButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftArrowButton.BackgroundImage")));
            this.LeftArrowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftArrowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LeftArrowButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.LeftArrowButton.Location = new System.Drawing.Point(200, 62);
            this.LeftArrowButton.Name = "LeftArrowButton";
            this.LeftArrowButton.Size = new System.Drawing.Size(75, 36);
            this.LeftArrowButton.TabIndex = 21;
            this.LeftArrowButton.UseVisualStyleBackColor = false;
            this.LeftArrowButton.Click += new System.EventHandler(this.LeftArrowButton_Click);
            // 
            // rightArrowButton
            // 
            this.rightArrowButton.BackColor = System.Drawing.Color.LightGray;
            this.rightArrowButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightArrowButton.BackgroundImage")));
            this.rightArrowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightArrowButton.Location = new System.Drawing.Point(747, 62);
            this.rightArrowButton.Name = "rightArrowButton";
            this.rightArrowButton.Size = new System.Drawing.Size(75, 36);
            this.rightArrowButton.TabIndex = 22;
            this.rightArrowButton.UseVisualStyleBackColor = false;
            this.rightArrowButton.Click += new System.EventHandler(this.rightArrowButton_Click);
            // 
            // MondayListBox
            // 
            this.MondayListBox.FormattingEnabled = true;
            this.MondayListBox.Location = new System.Drawing.Point(181, 128);
            this.MondayListBox.Name = "MondayListBox";
            this.MondayListBox.Size = new System.Drawing.Size(131, 186);
            this.MondayListBox.TabIndex = 23;
            // 
            // TuesdayListBox
            // 
            this.TuesdayListBox.FormattingEnabled = true;
            this.TuesdayListBox.Location = new System.Drawing.Point(310, 128);
            this.TuesdayListBox.Name = "TuesdayListBox";
            this.TuesdayListBox.Size = new System.Drawing.Size(134, 186);
            this.TuesdayListBox.TabIndex = 24;
            // 
            // WednesdayListBox
            // 
            this.WednesdayListBox.FormattingEnabled = true;
            this.WednesdayListBox.Location = new System.Drawing.Point(442, 128);
            this.WednesdayListBox.Name = "WednesdayListBox";
            this.WednesdayListBox.Size = new System.Drawing.Size(131, 186);
            this.WednesdayListBox.TabIndex = 25;
            // 
            // ThursdayListBox
            // 
            this.ThursdayListBox.FormattingEnabled = true;
            this.ThursdayListBox.Location = new System.Drawing.Point(571, 128);
            this.ThursdayListBox.Name = "ThursdayListBox";
            this.ThursdayListBox.Size = new System.Drawing.Size(131, 186);
            this.ThursdayListBox.TabIndex = 26;
            // 
            // FridayListBox
            // 
            this.FridayListBox.FormattingEnabled = true;
            this.FridayListBox.Location = new System.Drawing.Point(702, 128);
            this.FridayListBox.Name = "FridayListBox";
            this.FridayListBox.Size = new System.Drawing.Size(131, 186);
            this.FridayListBox.TabIndex = 27;
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 395);
            this.Controls.Add(this.FridayListBox);
            this.Controls.Add(this.ThursdayListBox);
            this.Controls.Add(this.WednesdayListBox);
            this.Controls.Add(this.TuesdayListBox);
            this.Controls.Add(this.MondayListBox);
            this.Controls.Add(this.rightArrowButton);
            this.Controls.Add(this.LeftArrowButton);
            this.Controls.Add(this.FridayLabel);
            this.Controls.Add(this.ThurdayLabel);
            this.Controls.Add(this.WednesdayLabel);
            this.Controls.Add(this.TuesdayLabel);
            this.Controls.Add(this.MondayLabel);
            this.Controls.Add(this.WeekOfLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserLabelE);
            this.Controls.Add(this.LogoutEmployeeButton);
            this.Controls.Add(this.AddMeetingButtonEmployee);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DayOfWeekBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "EmployeeView";
            this.Text = "EmployeeView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DayOfWeekBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddMeetingButtonEmployee;
        private System.Windows.Forms.Button LogoutEmployeeButton;
        private System.Windows.Forms.Label UserLabelE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox DayOfWeekBox;
        private System.Windows.Forms.Label WeekOfLabel;
        private System.Windows.Forms.Label MondayLabel;
        private System.Windows.Forms.Label TuesdayLabel;
        private System.Windows.Forms.Label WednesdayLabel;
        private System.Windows.Forms.Label ThurdayLabel;
        private System.Windows.Forms.Label FridayLabel;
        private System.Windows.Forms.Button LeftArrowButton;
        private System.Windows.Forms.Button rightArrowButton;
        private System.Windows.Forms.ListBox MondayListBox;
        private System.Windows.Forms.ListBox TuesdayListBox;
        private System.Windows.Forms.ListBox WednesdayListBox;
        private System.Windows.Forms.ListBox ThursdayListBox;
        private System.Windows.Forms.ListBox FridayListBox;
    }
}