

namespace IDFOperation.IDF.Strike
{
    internal class Hermes460Drone : StrikeOption
    {

        public Hermes460Drone(string name, double fuelSupply,  string bombType) : base(name, fuelSupply,bombType)
        {
            AddTypeOfTarget("people");
            AddTypeOfTarget("car");
            SetAmmunitionCapacity(3);
        }
       

    }
}
