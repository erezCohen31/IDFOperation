using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFOperation.TOOLS;

namespace IDFOperation.HAMAS
{
    internal class Weapon
    {
        private string name;
        private int point;
        public static readonly Dictionary<string, int> WeaponDictionary = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
        {
            { "knife", 1 },
            { "gun", 2 },
            { "m16", 3 },
            { "ak47", 3 },
            { "rpg", 4 },
            { "explosive", 4 },
            { "rifle", 3 },
            { "pistol", 2 }
        };

        public Weapon(string name)
        {
            this.name = name.ToLower();
            this.point = WeaponDictionary.ContainsKey(this.name) ? WeaponDictionary[this.name] : 1;
        }
        
      

        public void SetName(string name) { this.name = name; }
        public string GetName() { return this.name; }
        public int GetPoint() { return this.point; }
    }
}
