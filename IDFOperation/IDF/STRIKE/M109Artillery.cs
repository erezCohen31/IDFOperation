

namespace IDFOperation.IDF.Strike
{
    internal class M109Artillery : StrikeOption
    {
        private int strikeSimutaneity;

        public M109Artillery(string name, double fuelSupply , string bombType) : base(name, fuelSupply,bombType)
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
