using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFOperation.TOOLS;

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


   
        public Terrorist()
        {
            Random rnd = new Random();
            this.id = rnd.Next(1000, 10000); this.name = Input.GetName();
            this.rank = Input.GetRank();
            this.isAlive = true;
            this.latestLocation = Input.GetLocation();
            this.weapons = new List<Weapon>();
            int pointRank = 0;

            List<string> weaponsList = Input.GetWeaponsList();
            if (weaponsList != null)
            {
                foreach (string weaponName in weaponsList)
                {
                    if (!string.IsNullOrEmpty(weaponName))
                    {
                        Weapon currentWeapon = new Weapon(weaponName);
                        weapons.Add(currentWeapon);
                        pointRank += currentWeapon.GetPoint();
                    }
                }
            }

            qualityRank = rank * pointRank;
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
