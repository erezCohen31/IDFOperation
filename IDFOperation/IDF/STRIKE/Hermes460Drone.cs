﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFOperation.IDF.AMAN;

namespace IDFOperation.IDF.Strike
{
    internal class Hermes460Drone : StrikeOption
    {

        public Hermes460Drone(string name, double fuelSupply, List<Target> typeOfTarget, string bombType) : base(name, fuelSupply,bombType)
        {
            AddTypeOfTarget("people");
            AddTypeOfTarget("vehicle");
            SetAmmunitionCapacity(3);
        }
       

    }
}
