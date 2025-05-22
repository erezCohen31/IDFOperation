using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperation.HAMAS
{
    internal class Terrorist
    {
        private string name;
        private int rank;
        private bool isAlive;
        private List<Weapon> weapons;
        private int qualityRank;
        private string latestLocation;
        private readonly int id;
        private Dictionary<string, int> weaponDictionary = new Dictionary<string, int>()
          {
              { "knife", 1 },
              { "gun", 2 },
              { "m16", 3 },
              {"ak47",3 }
                                };

        public Terrorist(string name, int rank, List<string> weaponsName, string latestLocation, int id)
        {
            this.id = id;
            this.name = name;
            this.rank = rank;
            this.isAlive = true;
            this.latestLocation = latestLocation;
            int pointRank = 0;
            foreach (string weaponName in weaponsName)
            {
                Weapon currentWeapon = new Weapon(weaponName, weaponDictionary[weaponName]);
                weapons.Add(currentWeapon);
                pointRank += currentWeapon.GetPoint();

            }

            qualityRank = rank * pointRank;
            this.id = id;
        }


        public void SetName(string name) { this.name = name; }
        public string GetName() { return this.name; }
        public void SetRank(int rank) { this.rank = rank; }
        public int Getrank() { return this.rank; }
        public void SetIsAlive(bool isAlive) { this.isAlive = isAlive; }
        public bool GetIsAlive() { return this.isAlive; }
        public int GetQualityRank() { return qualityRank; }
        public void SetLocation(string location) { this.latestLocation = location; }
        public string GetLocation() { return this.latestLocation; }
        public int GetId() { return this.id; }
        public List<Weapon> GetWeapons() { return this.weapons; }
        public void AddWeapons(Weapon weapon) { this.weapons.Add(weapon); }
        public void RemoveWeapons(Weapon weapon) { this.weapons.Remove(weapon); }


    }
}
