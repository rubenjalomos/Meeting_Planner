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

        public void CreateMeeting_(Meeting NewMeeting)
        {
            using (var db = new DBConnector()) // creates an instance of the database 
            {
                if (NewMeeting.Id == null) //User does not create ID
                {
                    db.Meetings.Add(NewMeeting); // adds the new meeting to the Meetings table in the database
                }

                else // just a protection incase for whatever reason the meeting already exists in the database, will not duplicate, will update the existing meeting with new information
                {
                    //Guid id = Guid.Parse(NewMeeting.ID); //parses(string -> GUID) so that == operation can be performed next line. 
                    db.Meetings.First(x => x.Id == NewMeeting.Id);
                }
                db.SaveChanges();
            }

        }

    }
}