
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
