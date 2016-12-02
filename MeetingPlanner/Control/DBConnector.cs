using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetingPlanner.DBModel;

namespace MeetingPlanner.Control
{
    class DBConnector
    {
        public void InsertMeeting(Meeting NewMeeting)
        {
            using (var db = new MeetingPlannerDataBaseEntities()) // creates an instance of the database 
            {                
                db.Meetings.Add(NewMeeting);                
                db.SaveChanges();
            }
        }

        public void DeleteMeeting(Meeting MeetingToDelete)
        {
            using (var db = new MeetingPlannerDataBaseEntities())
            {
                //Guid id = Guid.Parse(MeetingToDelete.ID);
                var record = db.Meetings.Where(x => x.Id == MeetingToDelete.Id).Single();
                db.Meetings.Remove(record);
                db.SaveChanges();
            }
        }
        public List<Meeting> GetAllCalendar()
        {
            using (var db = new MeetingPlannerDataBaseEntities())
            {
                var meetings = db.Meetings.Select(x => x).ToList();
                return meetings;
            }
        }

        public User UserLogin(string UserName, string Password)
        {
            using (var db = new MeetingPlannerDataBaseEntities())
            {
                return db.Users.Single(x => (x.UserName == UserName && x.Password == Password));
            }

        }

        public bool CheckIfManager(User verifedUser)
        {
            using (var db = new MeetingPlannerDataBaseEntities())
            {
                return db.Managers.Any(x => (x.UserName == verifedUser.UserName));
            }
        }

        public bool CheckIfEmployee(User verifiedUser)
        {
            using (var db = new MeetingPlannerDataBaseEntities())
            {
                return db.Employees.Any(x => (x.UserName == verifiedUser.UserName));
            }
        }

        public Employee GetEmployee(User verifiedUser)
        {
            using (var db = new MeetingPlannerDataBaseEntities())
            {
                return db.Employees.Single(x => (x.UserName == verifiedUser.UserName));
            }
        }

        public Manager GetManager(User verifiedUser)
        {
            using (var db = new MeetingPlannerDataBaseEntities())
            {
                return db.Managers.Single(x => (x.UserName == verifiedUser.UserName));
            }
        }

        public List<Meeting> GetSingleUserCalendar(User user)
        {
            using (var db = new MeetingPlannerDataBaseEntities())
            {
                var meetings = db.Meetings.Where(x => x.UserN == user.UserName).ToList();
                return meetings;
            }
        }

    }
}
