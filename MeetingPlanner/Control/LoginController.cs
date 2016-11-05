using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetingPlanner.DBModel;
using MeetingPlanner.Control;
using MeetingPlanner.Entity;




//control object used to authenticate user, querys the User Table in Database
namespace MeetingPlanner.Control    
{
    public class LoginController
    {
        
        public User Login(string UserName, string Password)
        {
            using (var db = new DBConnector())
            {
                return db.Users.Single(x => (x.UserName == UserName && x.Password == Password));                
            }

        }

        public bool CheckIfManager(User verifedUser)
        {
            using (var db = new DBConnector())
            {
               return db.Managers.Any(x => (x.UserName == verifedUser.UserName));
            }
         }

        public bool CheckIfEmployee(User verifiedUser)
        {
            using (var db = new DBConnector())
            {
                return db.Employees.Any(x => (x.UserName == verifiedUser.UserName));
            }
        }

        public Employee GetEmployee(User verifiedUser)
        {
            using (var db = new DBConnector())
            {
                return db.Employees.Single(x => (x.UserName == verifiedUser.UserName));
            }
        }

        public Manager GetManager(User verifiedUser)
        {
            using (var db = new DBConnector())
            {
                return db.Managers.Single(x => (x.UserName == verifiedUser.UserName));
            }
        }

    }
}

