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

        public Weapon(string name, int point)
        {
            this.name = name;
            this.point = point;
        }

        public void SetName(string name) { this.name = name; }
        public string GetName() { return this.name; }
        public int GetPoint() { return this.point; }
    }
}
