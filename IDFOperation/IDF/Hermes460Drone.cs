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

        public Hermes460Drone(string name, int ammunitionCapacity, double fuelSupply, List<Target> typeOfTarget, string bombType) : base(name, ammunitionCapacity, fuelSupply, typeOfTarget)
        {
            this.bombType = bombType;
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
