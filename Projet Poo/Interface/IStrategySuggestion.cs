﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modele
{
    public interface IStrategySuggestion
    {
        int[][][] getSuggestion(Carte carte, Unite unite);
    }
}