﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class notes
    {
        public int ID { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }       
        public string Text { get; set; }
        public TimeSpan Date { get; set; }
    }
}