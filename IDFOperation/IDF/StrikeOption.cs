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
        private List<string> typeOfTarget;
         private bool IsAvailable;

        public StrikeOption(string name, double fuelSupply)
        {
            this.name = name;
            this.fuelSupply = fuelSupply;
            IsAvailable = true;
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
        public void RemoveOneAmmunitionCapacity()
        {
            this.ammunitionCapacity--;
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

        public List<string> GetTypeOfTarget()
        {
            return this.typeOfTarget;
        }
        public void AddTypeOfTarget(string typeOftarget)
        {
            this.typeOfTarget.Add(typeOftarget);
        }
        public void RemoveTypeOfTarget(string typeOfTarget)
        {
            this.typeOfTarget.Remove(typeOfTarget);
        }
        public bool GetIsAvailable()
        {
            return this.IsAvailable;
        }
        public void SetIsAvailable(bool isAvailable)
        {
            this.IsAvailable = isAvailable;
        }


    }
}
