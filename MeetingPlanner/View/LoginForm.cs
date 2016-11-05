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
using MeetingPlanner.Entity;
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

            LoginController Login = new LoginController();


            try
            {
                User LoggedIn = Login.Login(userName, typedPW);// login to system as user
                bool isManagerUser = Login.CheckIfManager(LoggedIn);//check if user is manager
                bool isEmployeeUser = Login.CheckIfEmployee(LoggedIn);//chech if user is employee



                if (isEmployeeUser == true)
                {
                    Employee EmployeeLoggedIn = Login.GetEmployee(LoggedIn);
                    Hide(); //hides the current form before opening the new view
                    EmployeeView empV = new EmployeeView(EmployeeLoggedIn); // passes user object into next view to be used when needed.
                    empV.Show();
                    //poplate view with users meetings already stored from object UserLoggedIn
                }

                else if(isManagerUser == true)
                {
                    Manager ManagerLoggedIn = Login.GetManager(LoggedIn);
                    Hide(); //hides the current form before opening the new view
                    ManagerView mngV = new ManagerView(ManagerLoggedIn);// passes user object into next view to be used when needed.
                    mngV.Show();
                    //poplate view with users meetings already stored from object UserLoggedIn
                        
                }

                else
                    throw new Exception();
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

