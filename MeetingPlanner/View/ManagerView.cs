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
using MeetingPlanner.Entity;

namespace MeetingPlanner.View
{
    public partial class ManagerView : Form
    {
        private Manager userLoggedIn; // user object that is held onto when logged in
        
        public ManagerView(Manager userLoggedIn)
        {
            InitializeComponent();
            this.userLoggedIn = userLoggedIn;
        }

        private void AddMeetingButton_Click(object sender, EventArgs e)
        {
            CreateController createM = new CreateController();
            createM.OpenCreateMeetingView(userLoggedIn);
        }

        private void DeleteMeetingButton_Click(object sender, EventArgs e)
        {
            DeleteController deleteM = new DeleteController();
            deleteM.OpenDeleteMeetingView(userLoggedIn); // opens the deleteViewForm
            deleteM.GetCalendar(); // fills the textbox with meeting to select from to be deleted
        }
    }
}
