using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetingPlanner.DBModel;
using MeetingPlanner.Control;
using MeetingPlanner.Entity;

namespace MeetingPlanner.Control
{
    public class DeleteController
    {
        public void DeleteMeeting(Meeting MeetingToDelete)
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
