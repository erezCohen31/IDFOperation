using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperation.IDF
{
    internal class M109Artillery : StrikeOption
    {
        private string bombType;
        private int strikeSimutaneity;

        public M109Artillery(string name, double fuelSupply, List<Target> typeOfTarget, string bombType, int strikeSimutaneity) : base(name, fuelSupply)
        {
            this.bombType = bombType;
            this.strikeSimutaneity = strikeSimutaneity;
            AddTypeOfTarget("open area");
            SetAmmunitionCapacity(40);
        }
        public string GetBombType()
        {
            return this.bombType;
        }
        public void SetBombType(string bombType)
        {
            this.bombType = bombType;
        }
        public int GetStrikeSimutaneity()
        {
            return this.strikeSimutaneity;
        }
        public void SetStrikeSimutaneity(int strikeSimutaneity)
        {
            this.strikeSimutaneity = strikeSimutaneity;
        }

    }
}
