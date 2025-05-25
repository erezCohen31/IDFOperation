using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFOperation.IDF.AMAN;
using IDFOperation.IDF.PERSON;

namespace IDFOperation.IDF.Strike
{
    internal class F16FighterJet : StrikeOption
    {

        public F16FighterJet(string name, double fuelSupply, string bombType) : base(name, fuelSupply,bombType)
        {
            AddTypeOfTarget("building");
            SetAmmunitionCapacity(8);
        }

        
       


    }
}
