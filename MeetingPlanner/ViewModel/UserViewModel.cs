using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetingPlanner.DBModel;
using MeetingPlanner.ViewModel;



//User model that is used in the View
namespace MeetingPlanner.ViewModel
{
    public enum AccessLevel { Manager = 1, Employee = 0 }
    public class UserViewModel
    {
        public string UserName { get; set; }
        public AccessLevel AccessLevel { get; set; } // manager or employee
        public string Password { get; set; }
        public List<MeetingViewModel> Meetings { get; set; }
    }


    //incase needed uncomment****************

    //public static class UserViewModelExtentions
    //{
    //    // this extension method converts the database model of the user to the view model
    //    public static UserViewModel FromDBtoVMConvert(this User DBUser)
    //    {
    //        return new UserViewModel() { UserName = DBUser.UserName, AccessLevel = (AccessLevel)DBUser.AccessLevel }; // dont care to keep track of password in object after logged in
    //    }
    //}

    //public class UsersViewModel
    //{
    //    public List<UserViewModel> Users
    //    {
    //        get;
    //        set;
    //    }
    //    public UsersViewModel()
    //    {
    //        var Meetings = new UserViewModel().Meetings;
    //        Users = new List<UserViewModel>();
    //        {
    //            using (var db = new MeetingPlannerEntities())
    //            {
    //                Users = db.Users.Select(x => new UserViewModel() { UserName = x.UserName, AccessLevel = (AccessLevel)x.AccessLevel, Meetings = Meetings, Password = x.Password }).ToList();
    //            }
    //        }
    //    }
    //}
}