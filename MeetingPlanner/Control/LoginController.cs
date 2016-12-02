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
        DBConnector db = new DBConnector();
        
        public User Login(string UserName, string Password)
        {
            return db.UserLogin(UserName, Password);

        }

        public bool CheckIfManager(User verifedUser)
        {
            return db.CheckIfManager(verifedUser);
         }

        public bool CheckIfEmployee(User verifiedUser)
        {
            return db.CheckIfEmployee(verifiedUser);
        }

        public Employee GetEmployee(User verifiedUser)
        {
            return db.GetEmployee(verifiedUser);
        }

        public Manager GetManager(User verifiedUser)
        {
            return db.GetManager(verifiedUser);
        }

    }
}

