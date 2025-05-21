using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperation.IDF
{
    internal abstract class StrikeOption
    {
        private string name;
        private int ammunitionCapacity;
        private double fuelSupply;
        private List<Target> typeOfTarget;

        public StrikeOption(string name, int ammunitionCapacity, double fuelSupply, List<Target> typeOfTarget)
        {
            this.name = name;
            this.ammunitionCapacity = ammunitionCapacity;
            this.fuelSupply = fuelSupply;
            this.typeOfTarget = typeOfTarget;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public int GetAmmunitionCapacity()
        {
            return this.ammunitionCapacity;
        }
        public void SetAmmunitionCapacity(int ammunitionCapacity)
        {
            this.ammunitionCapacity = ammunitionCapacity;
        }
        public double GetFuelSupply()
        {
            return this.fuelSupply;
        }
        public void AddFuel(double fuelSupply)
        {
            this.fuelSupply += fuelSupply;
        }
        public void RemoveFuel(double fuelSupply)
        {
            this.fuelSupply -= fuelSupply;
        }

        public List<Target> GetTypeOfTarget()
        {
            return this.typeOfTarget;
        }
        public void AddTypeOfTarget(Target target)
        {
            this.typeOfTarget.Add(target);
        }
        public void RemoveTypeOfTarget(Target target)
        {
            this.typeOfTarget.Remove(target);
        }


    }
}
