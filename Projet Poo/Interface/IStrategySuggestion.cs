﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modele
{
    public interface IStrategySuggestion
    {
        SuggMap getSuggestion(Carte carte, Unite unite);
    }
}
