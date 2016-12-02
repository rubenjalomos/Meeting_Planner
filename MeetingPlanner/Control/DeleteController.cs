using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetingPlanner.DBModel;
using MeetingPlanner.Control;
using MeetingPlanner.Entity;
using MeetingPlanner.View;
using System.Windows.Forms;

namespace MeetingPlanner.Control
{
    public class DeleteController
    {
        DBConnector db = new DBConnector();
        public void OpenDeleteMeetingView (Manager MUser)
        {
            DeleteMeetingView DeleteView = new DeleteMeetingView(MUser);
            DeleteView.Show();                       
        }

        public List<Meeting> GetAllMeetings()
        {
            return db.GetAllCalendar();
        }
        public void DeleteMeeting(ListBox.SelectedObjectCollection MeetingsToDelete)
        {
            foreach (Meeting m in MeetingsToDelete)
            {
                db.DeleteMeeting(m);
            }
        }
    }
}
