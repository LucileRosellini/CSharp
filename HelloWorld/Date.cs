﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Date: IDate
    {
        public DateTime GetTime()
        {
            return DateTime.Now;
        }
    }
}
