﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.work._9
{
    class Dog : Animal, ICanPutOnMask
    {
        public bool IsHaveMask { set; get; }
    }
}
