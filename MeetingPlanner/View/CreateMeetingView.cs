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
        }

        public CreateMeetingView(Employee employeeLoggedIn)
        {
            InitializeComponent();
            this.employeeLoggedIn = employeeLoggedIn;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            //Create the meeting then close the window.
            this.Close();
            //then update the caledar on home screen with meeting
        }

        private void CancelCreateButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
