﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modele
{
    [Serializable]
    public class PeupleNain : Peuple
    {
        public override string ToString()
        {
            return "Nain";
        }
        public override int toInt()
        {
            return 2;
        }
    }
}
