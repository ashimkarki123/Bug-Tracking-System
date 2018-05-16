﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bug_Tracker.Model
{
    /// <summary>
    /// Model class for saving information about programmer
    /// </summary>
    class Programmer
    {
        public int? ProgrammerId { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
