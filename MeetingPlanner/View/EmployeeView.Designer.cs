﻿namespace MeetingPlanner.View
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
            this.AddMeetingButtonEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddMeetingButtonEmployee
            // 
            this.AddMeetingButtonEmployee.Location = new System.Drawing.Point(60, 71);
            this.AddMeetingButtonEmployee.Name = "AddMeetingButtonEmployee";
            this.AddMeetingButtonEmployee.Size = new System.Drawing.Size(75, 23);
            this.AddMeetingButtonEmployee.TabIndex = 0;
            this.AddMeetingButtonEmployee.Text = "Add Meeting";
            this.AddMeetingButtonEmployee.UseVisualStyleBackColor = true;
            this.AddMeetingButtonEmployee.Click += new System.EventHandler(this.AddMeetingButtonEmployee_Click);
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 395);
            this.Controls.Add(this.AddMeetingButtonEmployee);
            this.Name = "EmployeeView";
            this.Text = "EmployeeView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddMeetingButtonEmployee;
    }
}