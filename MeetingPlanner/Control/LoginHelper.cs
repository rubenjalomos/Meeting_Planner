using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetingPlanner.DBModel;
using MeetingPlanner.Control;
using MeetingPlanner.ViewModel;




//control object used to authenticate user, querys the User Table in Database
namespace MeetingPlanner.Control    
{
    public class LoginHelper
    {
        
        public static User Login(string UserName, string Password)
        {
            using (var db = new MeetingPlannerDataBaseEntities())
            {
                var authenticatedUser = db.Users.Single(x => (x.UserName == UserName && x.Password == Password));
                return authenticatedUser;
            }

        }

    }
}

