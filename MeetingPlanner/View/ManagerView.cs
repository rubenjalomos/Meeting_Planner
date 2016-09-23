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
using MeetingPlanner.ViewModel;

namespace MeetingPlanner.View
{
    public partial class ManagerView : Form
    {
        private User userLoggedIn; // user object that is held onto when logged in
        public ManagerView()
        {
            InitializeComponent();
        }

        public ManagerView(User userLoggedIn)
        {
            InitializeComponent();
            this.userLoggedIn = userLoggedIn;
        }

        
    }
}
