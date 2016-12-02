using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeetingPlanner.DBModel;
using MeetingPlanner.Control;

namespace MeetingPlanner.View
{
    public partial class DeleteMeetingView : Form
    {
        private Manager managerLoggedIn;

        DeleteController delete = new DeleteController();

        public DeleteMeetingView(Manager managerLoggedIn)
        {
            InitializeComponent();
            this.managerLoggedIn = managerLoggedIn;
            var meetings = delete.GetAllMeetings();
            UserLabelDM.Text = managerLoggedIn.UserName;           
            MeetingsListBox.DataSource = meetings;//fill test box with meetings.
            MeetingsListBox.DisplayMember = "MeetingLocation";
            MeetingsListBox.ValueMember = "Id";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create list object to hold list of meetings to delete
          
            //after closing populate calendar
        }

        private void DeleteSelectedButton_Click(object sender, EventArgs e)
        {
            List<Meeting> meetingsToDelete = new List<Meeting>();
            var meetings = MeetingsListBox.SelectedItems;
            // Meeting meeting = new Meeting { MeetingDate = DateTime.Parse(_meeting) };

            delete.DeleteMeeting(meetings);
            Close();

        }
    }
}
