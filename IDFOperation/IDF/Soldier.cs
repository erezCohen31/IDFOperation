using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperation.IDF
{
    internal abstract class Soldier
    {
        string name;
        int id;
        int age;

        public Soldier(string name, int id, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }
    }
}
