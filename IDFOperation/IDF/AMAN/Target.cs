using IDFOperation.HAMAS;
using IDFOperation.TOOLS;

namespace IDFOperation.IDF.AMAN
{
    internal class Target
    {
        private string name;
        private string type;
        private string location;
        private double fuelNeed;
        private Terrorist terroristToKill;
        private string source;

        public Target( string location, string name,Terrorist terrorist,string source)
        {
            this.name = name;
            this.type = Input.TypeOfTarget();
            this.location = location;
            this.fuelNeed = Input.GetFuel();
            this.terroristToKill = terrorist;
            this.source = source;
        }
     

        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetTypeOfTarget()
        {
            return type;
        }
        public void SetTypeOfTarget(string type)
        {
            this.type = type;
        }
        public string GetLocation()
        {
            return location;
        }
        public void SetLocation(string location)
        {
            this.location = location;
        }
        public double GetFuelNeed()
        {
            return fuelNeed;
        }
        public void SetFuelNeed(double fuelNeed)
        {
            this.fuelNeed = fuelNeed;
        }
        public Terrorist GetTerrorist()
        {
            return terroristToKill;
        }
        public void SetTerrorist(Terrorist terrorist)
        {
            this.terroristToKill = terrorist;
        }




    }
}
