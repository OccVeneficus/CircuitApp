﻿using System;
using System.Numerics;
using CircutApp;
using CircutApp.Elements;

namespace CircuitAppUnitTests
{
    class ElementHeir : Element
    {
        public override Complex CalculateImpedance(double frequency)
        {
            throw new NotImplementedException();
        }
    }
}
