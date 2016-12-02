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
        int weekcounter = 0;
        CreateController createE = new CreateController();

        public EmployeeView(Employee userLoggedIn)
        {
            InitializeComponent();
            this.userLoggedIn = userLoggedIn;
            User nUser = new User() { UserName = userLoggedIn.UserName };
            UserLabelE.Text = userLoggedIn.UserName;
            WeekOfLabel.Text = "Week Of " + DateTime.Now.ToShortDateString();
            fillCalendarLabels(DateTime.Today);
            var UsersMeetings = createE.fillCalendar(nUser);
            fillCalendarMeetings(nUser, UsersMeetings);
           
        }

        private void AddMeetingButtonEmployee_Click(object sender, EventArgs e)
        {            
            createE.OpenCreateMeetingView(userLoggedIn);           
        }

        private void LogoutEmployeeButton_Click(object sender, EventArgs e)
        {
            login loginView = new login();
            loginView.Show();
            this.Close();
        }

             
        private void WeekOfLabel_Click(object sender, EventArgs e)
        {}

        private void fillCalendarLabels(DateTime today)
        {
            switch (today.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    MondayLabel.Text = "Monday" + today.ToShortDateString();
                    TuesdayLabel.Text = "Tuesday" + today.AddDays(1).ToShortDateString();
                    WednesdayLabel.Text = "Wednesday" + today.AddDays(2).ToShortDateString();
                    ThurdayLabel.Text = "Thursday" + today.AddDays(3).ToShortDateString();
                    FridayLabel.Text = "Friday" + today.AddDays(4).ToShortDateString();
                    break;
                case DayOfWeek.Tuesday:
                    MondayLabel.Text = "Monday" + today.Subtract(TimeSpan.FromDays(1)).ToShortDateString();
                    TuesdayLabel.Text = "Tuesday" + today.ToShortDateString();
                    WednesdayLabel.Text = "Wednesday" + today.AddDays(1).ToShortDateString();
                    ThurdayLabel.Text = "Thursday" + today.AddDays(2).ToShortDateString();
                    FridayLabel.Text = "Friday" + today.AddDays(3).ToShortDateString();
                    break;
                case DayOfWeek.Wednesday:
                    MondayLabel.Text = "Monday" + today.Subtract(TimeSpan.FromDays(2)).ToShortDateString();
                    TuesdayLabel.Text = "Tuesday" + today.Subtract(TimeSpan.FromDays(1)).ToShortDateString();
                    WednesdayLabel.Text = "Wednesday" + today.ToShortDateString();
                    ThurdayLabel.Text = "Thursday" + today.AddDays(1).ToShortDateString();
                    FridayLabel.Text = "Friday" + today.AddDays(2).ToShortDateString();
                    break;
                case DayOfWeek.Thursday:
                    MondayLabel.Text = "Monday" + today.Subtract(TimeSpan.FromDays(3)).ToShortDateString();
                    TuesdayLabel.Text = "Tuesday" + today.Subtract(TimeSpan.FromDays(2)).ToShortDateString();
                    WednesdayLabel.Text = "Wednesday" + today.Subtract(TimeSpan.FromDays(1)).ToShortDateString();
                    ThurdayLabel.Text = "Thursday" + today.ToShortDateString();
                    FridayLabel.Text = "Friday" + today.AddDays(1).ToShortDateString();
                    break;
                case DayOfWeek.Friday:
                    MondayLabel.Text = "Monday" + today.Subtract(TimeSpan.FromDays(4)).ToShortDateString();
                    TuesdayLabel.Text = "Tuesday" + today.Subtract(TimeSpan.FromDays(3)).ToShortDateString();
                    WednesdayLabel.Text = "Wednesday" + today.Subtract(TimeSpan.FromDays(2)).ToShortDateString();
                    ThurdayLabel.Text = "Thursday" + today.Subtract(TimeSpan.FromDays(1)).ToShortDateString();
                    FridayLabel.Text = "Friday" + today.ToShortDateString();
                    break;
                default:
                    break;
            }
            
        }

        private void fillCalendarMeetings(User user, List<Meeting> usersMeetings)
        {
            foreach (Meeting m in usersMeetings)
            {
                if (m.MeetingDate.ToShortDateString() == DateTime.Parse(MondayLabel.Text).ToShortDateString())
                {
                    MondayListBox.Items.Add(m.MeetingLocation + " " + m.GroupTitle);
                }
                else if (m.MeetingDate.ToShortDateString() == DateTime.Parse(TuesdayLabel.Text).ToShortDateString())
                {
                    TuesdayListBox.Items.Add(m.MeetingLocation + " " + m.GroupTitle);
                }
                else if (m.MeetingDate.ToShortDateString() == DateTime.Parse(WednesdayLabel.Text).ToShortDateString())
                {
                    WednesdayListBox.Items.Add(m.MeetingLocation + " " + m.GroupTitle);
                }
                else if (m.MeetingDate.ToShortDateString() == DateTime.Parse(ThurdayLabel.Text).ToShortDateString())
                {
                    ThursdayListBox.Items.Add(m.MeetingLocation + " " + m.GroupTitle);
                }
                else if (m.MeetingDate.ToShortDateString() == DateTime.Parse(FridayLabel.Text).ToShortDateString())
                {
                    FridayListBox.Items.Add(m.MeetingLocation + " " + m.GroupTitle);
                }

                
            }
        }

        private void LeftArrowButton_Click(object sender, EventArgs e)
        {
            if (weekcounter == 0)
            {
                weekcounter -= 1;
                fillCalendarLabels(DateTime.Today.Subtract(TimeSpan.FromDays(7)));
                WeekOfLabel.Text = "Week of " + DateTime.Today.Subtract(TimeSpan.FromDays(7)).ToShortDateString();
            }
            else if (weekcounter == -1)
            {
                weekcounter -= 1;
                fillCalendarLabels(DateTime.Today.Subtract(TimeSpan.FromDays(14)));
                WeekOfLabel.Text = "Week of " + DateTime.Today.Subtract(TimeSpan.FromDays(14)).ToShortDateString();
            }
            else if (weekcounter == 1)
            {
                weekcounter -= 1;
                fillCalendarLabels(DateTime.Today);
                WeekOfLabel.Text = "Week of " + DateTime.Today.ToShortDateString();
            }
            else if (weekcounter == 2)
            {
                weekcounter -= 1;
                fillCalendarLabels(DateTime.Today.AddDays(7));
                WeekOfLabel.Text = "Week of " + DateTime.Today.AddDays(7).ToShortDateString();
            }

            User nUser = new User() { UserName = userLoggedIn.UserName };
            var meetings = createE.fillCalendar(nUser);
            MondayListBox.Items.Clear();
            TuesdayListBox.Items.Clear();
            WednesdayListBox.Items.Clear();
            ThursdayListBox.Items.Clear();
            FridayListBox.Items.Clear();
            fillCalendarMeetings(nUser, meetings);
        }

        private void rightArrowButton_Click(object sender, EventArgs e)
        {
            if (weekcounter == 0)
            {
                weekcounter += 1;
                fillCalendarLabels(DateTime.Today.AddDays(7));
                WeekOfLabel.Text = "Week of " + DateTime.Today.AddDays(7).ToShortDateString();
            }
            else if (weekcounter == 1)
            {
                weekcounter += 1;
                fillCalendarLabels(DateTime.Today.AddDays(14));
                WeekOfLabel.Text = "Week of " + DateTime.Today.AddDays(14).ToShortDateString();
            }
            else if (weekcounter == -1)
            {
                weekcounter += 1;
                fillCalendarLabels(DateTime.Today);
                WeekOfLabel.Text = "Week of " + DateTime.Today.ToShortDateString();
            }
            else if (weekcounter == -2)
            {
                weekcounter += 1;
                fillCalendarLabels(DateTime.Today.Subtract(TimeSpan.FromDays(7)));
                WeekOfLabel.Text = "Week of " + DateTime.Today.Subtract(TimeSpan.FromDays(7)).ToShortDateString();
            }

            User nUser = new User() { UserName = userLoggedIn.UserName };
            var meetings = createE.fillCalendar(nUser);
            MondayListBox.Items.Clear();
            TuesdayListBox.Items.Clear();
            WednesdayListBox.Items.Clear();
            ThursdayListBox.Items.Clear();
            FridayListBox.Items.Clear();
            fillCalendarMeetings(nUser, meetings);
        }

        
    }
}
