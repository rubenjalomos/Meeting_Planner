using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetingPlanner.DBModel;
using MeetingPlanner.Control;
using MeetingPlanner.Entity;
using MeetingPlanner.View;

namespace MeetingPlanner.Control
{
    public class DeleteController
    {
        public void OpenDeleteMeetingView (Manager MUser)
        {
            DeleteMeetingView DeleteView = new DeleteMeetingView(MUser);
            DeleteView.Show();
            var meetings = GetCalendar(); //create list of all meetings to select delete.
            
        }

        public List<Meeting> GetCalendar()
        {
            using (var db = new DBConnector())
            {
                var meetings = db.Meetings.Select(x => x).ToList();
                return meetings;
            }
        }
        public void DeleteMeeting_(Meeting MeetingToDelete)
        {
            using (var db = new DBConnector())
            {
                //Guid id = Guid.Parse(MeetingToDelete.ID);
                var record = db.Meetings.Where(x => x.Id == MeetingToDelete.Id).Single();
                db.Meetings.Remove(record);
                db.SaveChanges();
            }
        }
    }
}
