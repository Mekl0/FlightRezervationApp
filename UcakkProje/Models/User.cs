﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForm
{
    public partial class User
    {
        public int id { get; set; }
        public DateTime createdate { get; set; } = DateTime.Now;
        public string name { get; set; }
        //public List<Lesson> lessons { get; set; }
    }
}
