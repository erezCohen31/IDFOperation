using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperation.IDF
{
    internal abstract class StrikeOption
    {
        private string name;
        private int ammunitionCapacity;
        private double fuelSupply;
        private List<Target> typeOfTarget;

        public StrikeOption(string name, int ammunitionCapacity, double fuelSupply, List<Target> typeOfTarget)
        {
            this.name = name;
            this.ammunitionCapacity = ammunitionCapacity;
            this.fuelSupply = fuelSupply;
            this.typeOfTarget = typeOfTarget;
        }



    }
}
