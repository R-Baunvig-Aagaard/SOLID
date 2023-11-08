﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Write to console: {message}");
        }
    }
}
