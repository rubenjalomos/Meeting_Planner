using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetingPlanner.DBModel;

/// <summary>
/// May not use, can use the DB model and avoid converting from ViewModel to DBModel. but may need if unable to implictly convert from list obtained from view
/// to IColletion list needed for Database Model 
/// User model that is used in the View

/// </summary>

namespace MeetingPlanner.Entity
{
    public enum AccessLevel { Manager = 1, Employee = 0 }
    abstract class UserVM
    {
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        //protected string UserName;
        //protected string Password;
        
        //public UserVM(string UserName, string Password)
        //{
        //    this.UserName = UserName;
        //    this.Password = Password;
        //}
       
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