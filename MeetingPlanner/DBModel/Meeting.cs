//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MeetingPlanner.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Meeting
    {
        public System.Guid Id { get; set; }
        public string MeetingLocation { get; set; }
        public System.DateTime MeetingDate { get; set; }
        public string GroupTitle { get; set; }
        public int MeetingDuration { get; set; }
        public string UserN { get; set; }
    }
}
