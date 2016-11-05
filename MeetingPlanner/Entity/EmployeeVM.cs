using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingPlanner.Entity
{
    class EmployeeVM : UserVM
    {
        public new string UserName { get { return base.UserName; } set { base.UserName = value; } }
        private new string Password { get { return base.Password; } set { base.Password = value; } }
        public AccessLevel AccessLevel { get; set; } // manager or employee
        public List<Calendar> Meetings{ get; set; } // each user has a list of meetings they are assigned to
    }
}