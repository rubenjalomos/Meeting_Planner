using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetingPlanner.DBModel;
using MeetingPlanner.Control;
using MeetingPlanner.Entity;
using MeetingPlanner.View;


// control object use to facilite interactions between user and database when creating and deleting meetings. queries the Meetings table in Database
// when creating or deleting, send in arguement as MeetingViewModel object.
//keep as much logic outside of view .cs file.
namespace MeetingPlanner.Control    
{
    public class CreateController
    {
        DBConnector db = new DBConnector();
        public void OpenCreateMeetingView(Manager MUser)
        {
            CreateMeetingView CreateView = new CreateMeetingView(MUser);
            CreateView.Show();
        }

        public void OpenCreateMeetingView(Employee EUser)
        {
            CreateMeetingView CreateView = new CreateMeetingView(EUser);
            CreateView.Show();
        }

        public void createMeeting(Meeting newMeeting)
        {            
            db.InsertMeeting(newMeeting);
        }

        public List<Meeting> fillCalendar(User user)
        {
            return db.GetSingleUserCalendar(user);            
        }
        


    }
}