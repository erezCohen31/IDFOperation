using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperation.HAMAS
{
    internal class Weapon
    {
       private string name;
        private int point;
        private Dictionary<string, int> weaponDictionary = new Dictionary<string, int>()
          {
              { "knife", 1 },
              { "gun", 2 },
              { "m16", 3 },
              {"ak47",3 }
                                };

        public Weapon(string name)
        {
            this.name = name;
            this.point = weaponDictionary[name];
        }
        public Weapon()
        {
            this.name = Input.GetName();
            this.point = weaponDictionary[name];
        }

        public void SetName(string name) { this.name = name; }
        public string GetName() { return this.name; }
        public int GetPoint() { return this.point; }
    }
}
