using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeetingPlanner.Entity;
using MeetingPlanner.DBModel;
using MeetingPlanner.Control;

namespace MeetingPlanner.View
{
    public partial class CreateMeetingView : Form
    {
        private Manager managerLoggedIn;
        private Employee employeeLoggedIn;

        public CreateMeetingView(Manager managerLoggedIn)
        {

            InitializeComponent();
            this.managerLoggedIn = managerLoggedIn;
            UserLabel.Text = managerLoggedIn.UserName;
        }

        public CreateMeetingView(Employee employeeLoggedIn)
        {     
            
            InitializeComponent();
            this.employeeLoggedIn = employeeLoggedIn;
            UserLabel.Text = employeeLoggedIn.UserName;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var username = UserLabel.Text;
            var g = Guid.NewGuid();          
            var date = dateTimePicker.Value;
            string GT = GroupTitleTextBox.Text;
            int duration = Convert.ToInt32(meetingDurationtextBox.Text);
            string loc = locaitonTextBox.Text;
            Meeting newMeeting = new Meeting() { Id = g, GroupTitle = GT, MeetingDate = date, MeetingDuration = duration, MeetingLocation = loc, UserN = username };
            
            CreateController create = new CreateController();
            create.createMeeting(newMeeting);
            this.Close();
            //then update the caledar on home screen with meeting
        }

        private void CancelCreateButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateMeetingView_Load(object sender, EventArgs e)
        {

        }
    }
}
