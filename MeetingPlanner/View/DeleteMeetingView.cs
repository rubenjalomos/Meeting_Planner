﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeetingPlanner.DBModel;

namespace MeetingPlanner.View
{
    public partial class DeleteMeetingView : Form
    {
        private Manager managerLoggedIn;
        public DeleteMeetingView(Manager managerLoggedIn)
        {
            InitializeComponent();
            this.managerLoggedIn = managerLoggedIn;
            
        }
    }
}