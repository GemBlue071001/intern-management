﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Meeting : Base
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Location { get; set; }
        public string Minutes { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }

        //Navigation Property 
        public List<UserMeeting> UserMeetings;
    }
}
