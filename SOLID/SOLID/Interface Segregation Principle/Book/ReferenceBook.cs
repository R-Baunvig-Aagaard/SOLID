﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    public class ReferenceBook : IBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        
        public string LibraryId { get; set; }
        public int Pages { get; set; }

       
    }
}
