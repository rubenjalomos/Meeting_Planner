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
using MeetingPlanner.Control;


namespace MeetingPlanner.View
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var userName = textUserName.Text;
            var typedPW = textPassword.Text;

            try
            {
                User UserLoggingIn = LoginHelper.Login(userName, typedPW);// login to system and return accesslevel to view appropriate screen

                switch (UserLoggingIn.AccessLevel)
                {
                    case ((int)AccessLevel.Employee):
                        Hide(); //hides the current form before opening the new view
                        EmployeeView empV = new EmployeeView(UserLoggingIn); // passes user object into next view to be used when needed.
                        empV.Show();
                        //poplate view with users meetings already stored from object UserLoggedIn
                        break;

                    case ((int)AccessLevel.Manager):
                        Hide(); //hides the current form before opening the new view
                        ManagerView mngV = new ManagerView(UserLoggingIn);// passes user object into next view to be used when needed.
                        mngV.Show();
                        //poplate view with users meetings already stored from object UserLoggedIn
                        break;

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Incorrect Username or Password"); // if user is not found in database, message shows
                textUserName.Text = string.Empty;
                textPassword.Text = string.Empty;
            }



        }



        

    }
}

