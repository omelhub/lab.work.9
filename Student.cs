﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.work._9
{
    class Student : Human, IQRCode, ICanDisinfectHand, ICanPutOnMask
    {
        public bool IsHaveQR { get; set; }
        public bool IsHaveMask { get; set; }
    }
}
