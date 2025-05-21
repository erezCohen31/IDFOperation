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

        public Terrorist(string name, int rank, List<Weapon> weapons)
        {
            this.name = name;
            this.rank = rank;
            this.isAlive = true;
            this.weapons = weapons;
        }

        public void setName(string name) { this.name = name; }
        public string getName() { return this.name; }
        public void SetRank(int rank) { this.rank = rank; }
        public int getRank() { return this.rank; }
        public void setIsAlive(bool isAlive) { this.isAlive = isAlive; }
        public bool GetIsAlive() { return this.isAlive; }
        public List<Weapon> GetWeapons() { return this.weapons; }
        public void AddWeapons(Weapon weapon) { this.weapons.Add(weapon); }
        public void RemoveWeapons(Weapon weapon) { this.weapons.Remove(weapon); }


    }
}
