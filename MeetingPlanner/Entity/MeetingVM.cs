using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using MeetingPlanner.DBModel;
using MeetingPlanner.Entity;

namespace MeetingPlanner.Entity
{

    /// <summary>
    /// May not use, can use the DB model and avoid converting from ViewModel to DBModel. but may need if unable to implictly convert from list obtained from view
    /// to IColletion list needed for Database Model 
    /// </summary>
    public class Calendar // meeting object that is created
    {
        public DateTime MeetingDate { get; set; }
        public string GroupTitle { get; set; }
        public string MeetingLocation { get; set; }
        public int MeetingDuration { get; set; }
        public string ID { get; set; }
        public List<User> Users { get; set; }

        public Calendar()
        {
            Users = new List<User>();
        }
    }


    public static class MeetingVMExtensions
    {
        // extention used when saving a new meeting to the database, converts the meeting model created from the view to the database model to be stored.
        // use example: newMeeting.ToMeetingDBModel();
        public static Meeting ToMeetingDBModel(this Calendar Mvm)  
        {
            return new Meeting() { Id = Guid.NewGuid(), MeetingLocation = Mvm.MeetingLocation, MeetingDate = Mvm.MeetingDate, GroupTitle = Mvm.GroupTitle, MeetingDuration = Mvm.MeetingDuration };
        }


        //if a meeting is being saved into the database and already exists in the database, duplicate with no be created, the meeting with 
        //corresponding key with be updated with new information. mostly likely used during testing dummy data, should not likely be called during ops.
        public static Meeting Update(this Meeting M, Calendar MVM)
        {
            M.MeetingDate = MVM.MeetingDate;
            M.MeetingDuration = MVM.MeetingDuration;
            M.MeetingLocation = MVM.MeetingLocation;
            M.Users = MVM.Users;
            M.GroupTitle = MVM.GroupTitle;
            return M;
        }

    }
}




      



//using (var db = new DBConnector())
//{
//   Meetings = db.Meetings.Select(x => new MeetingVM() { ID = x.Id.ToString(), GroupTitle = x.GroupTitle, MeetingDate = x.MeetingDate, MeetingDuration = x.MeetingDuration, MeetingLocation = x.MeetingLocation, Users = Users }).ToList();
//}        

//        //hard coding meetings for now, later change to pull from db of meetings
//        //meetings.Add(new Meeting { MeetingDate = DateTime.Parse("9/15/2016"), GroupTitle = "GroupTitle 1", MeetingLocation = "location 1", MeetingDuration = 1 });
//        //meetings.Add(new Meeting { MeetingDate = DateTime.Parse("9/16/2016"), GroupTitle = "GroupTitle 2", MeetingLocation = "location 2", MeetingDuration = 2 });
//        //meetings.Add(new Meeting { MeetingDate = DateTime.Parse("9/25/2016"), GroupTitle = "GroupTitle 3", MeetingLocation = "location 3", MeetingDuration = 1 });




