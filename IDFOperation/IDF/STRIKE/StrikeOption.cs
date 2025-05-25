using IDFOperation.TOOLS;

namespace IDFOperation.IDF.Strike
{
    internal abstract class StrikeOption
    {
        private string name;
        private int ammunitionCapacity;
        private double fuelSupply;
        private List<string> typeOfTarget;
        private bool IsAvailable;
        private string bombType;


        public StrikeOption(string name, double fuelSupply, string bombType)
        {
            this.name = name;
            this.fuelSupply = fuelSupply;
            this.bombType = bombType;
            IsAvailable = true;
            typeOfTarget = new List<string>();
        }
        public StrikeOption()
        {
            this.name = Input.GetName();
            this.fuelSupply = Input.GetFuel();
            this.bombType = Input.GetBombType();
            IsAvailable = true;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public int GetAmmunitionCapacity()
        {
            return ammunitionCapacity;
        }
        public void SetAmmunitionCapacity(int ammunitionCapacity)
        {
            this.ammunitionCapacity = ammunitionCapacity;
        }
        public void RemoveOneAmmunitionCapacity()
        {
            ammunitionCapacity--;
        }
        public double GetFuelSupply()
        {
            return fuelSupply;
        }
        public void AddFuel(double fuelSupply)
        {
            this.fuelSupply += fuelSupply;
        }
        public void RemoveFuel(double fuelSupply)
        {
            this.fuelSupply -= fuelSupply;
        }
        public string GetBombType()
        {
            return bombType;
        }
        public void SetBombType(string bombType)
        {
            this.bombType = bombType;
        }

        public List<string> GetTypeOfTarget()
        {
            return typeOfTarget;
        }
        public void AddTypeOfTarget(string typeOftarget)
        {
            typeOfTarget.Add(typeOftarget);
        }
        public void RemoveTypeOfTarget(string typeOfTarget)
        {
            this.typeOfTarget.Remove(typeOfTarget);
        }
        public bool GetIsAvailable()
        {
            return IsAvailable;
        }
        public void SetIsAvailable(bool isAvailable)
        {
            IsAvailable = isAvailable;
        }


    }
}
