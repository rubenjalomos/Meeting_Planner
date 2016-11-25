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
    public partial class EmployeeView : Form
    {
        private Employee userLoggedIn;// current user 

        public EmployeeView(Employee userLoggedIn)
        {
            InitializeComponent();
            this.userLoggedIn = userLoggedIn;
        }

        private void AddMeetingButtonEmployee_Click(object sender, EventArgs e)
        {
            CreateController createE = new CreateController();
            createE.OpenCreateMeetingView(userLoggedIn);
        }
    }
}
