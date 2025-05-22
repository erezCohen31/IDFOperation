using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperation.IDF
{
    internal abstract class Soldier
    {
       private string name;
       private readonly int id;
       private int age;

        public Soldier(string name, int id, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public int GetId()
        {
            return this.id;
        }
        public int GetAge()
        {
            return this.age;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
    }
}
