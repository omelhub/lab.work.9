﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.work._9
{
    class Teacher : Human, IQRCode, ICanDisinfectHand, ICanPutOnMask
    {
        public bool IsHaveQR { set; get; }
        public bool IsHaveMask { set; get; }
    }
}
