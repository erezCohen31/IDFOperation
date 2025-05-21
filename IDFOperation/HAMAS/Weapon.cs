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

        public Weapon(string name)
        {
            this.name = name;
        }

        public void setName(string name) { this.name = name; }
        public string getName() { return this.name; }
    }
}
