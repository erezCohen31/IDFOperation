using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperation.IDF.AMAN
{
    internal class Target
    {
        private string name;
        private string type;
        private string location;
        private double fuelNeed;

        public Target(string type, string location, double fuelNeed, string name)
        {
            this.name = name;
            this.type = type;
            this.location = location;
            this.fuelNeed = fuelNeed;
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




    }
}
