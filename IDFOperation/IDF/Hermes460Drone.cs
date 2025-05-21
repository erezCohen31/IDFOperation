using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperation.IDF
{
    internal class Hermes460Drone : StrikeOption
    {
        private string bombType;

        public Hermes460Drone(string name, double fuelSupply, List<Target> typeOfTarget, string bombType) : base(name, fuelSupply)
        {
            this.bombType = bombType;
            AddTypeOfTarget("people");
            AddTypeOfTarget("vehicle");
            SetAmmunitionCapacity(3);
        }
        public string GetBombType()
        {
            return this.bombType;
        }
        public void SetBombType(string bombType)
        {
            this.bombType = bombType;
        }

    }
}
