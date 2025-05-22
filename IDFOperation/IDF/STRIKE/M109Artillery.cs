using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFOperation.IDF.AMAN;

namespace IDFOperation.IDF.Strike
{
    internal class M109Artillery : StrikeOption
    {
        private int strikeSimutaneity;

        public M109Artillery(string name, double fuelSupply, List<Target> typeOfTarget, string bombType) : base(name, fuelSupply,bombType)
        {
            
            this.strikeSimutaneity = 3;
            AddTypeOfTarget("open area");
            SetAmmunitionCapacity(40);
        }
       
        public int GetStrikeSimutaneity()
        {
            return strikeSimutaneity;
        }
        public void SetStrikeSimutaneity(int strikeSimutaneity)
        {
            this.strikeSimutaneity = strikeSimutaneity;
        }

    }
}
