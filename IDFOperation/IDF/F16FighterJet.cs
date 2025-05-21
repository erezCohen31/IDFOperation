using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperation.IDF
{
    internal class F16FighterJet : StrikeOption
    {
        private string bombType;
        private IPilot pilot;

        public F16FighterJet(string name, int ammunitionCapacity, double fuelSupply, List<Target> typeOfTarget, string bombType, IPilot pilot) : base(name, ammunitionCapacity, fuelSupply, typeOfTarget)
        {
            this.bombType = bombType;
            this.pilot = pilot;
        }

        public string GetBombType()
        {
            return this.bombType;
        }
        public void SetBombType(string bombType)
        {
            this.bombType = bombType;
        }
        public IPilot GetPilot()
        {
            return this.pilot;
        }
        public void SetPilot(IPilot pilot)
        {
            this.pilot = pilot;
        }


    }
}
