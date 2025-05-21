using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperation.HAMAS
{
    internal class Terrorist
    {
        string name;
        int rank;
        bool isAlive;
        List<Weapon> weapons;

        public Terrorist(string name, int rank, bool isAlive, List<Weapon> weapons)
        {
            this.name = name;
            this.rank = rank;
            this.isAlive = isAlive;
            this.weapons = weapons;
        }
    }
}
