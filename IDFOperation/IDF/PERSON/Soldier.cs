using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFOperation.TOOLS;

namespace IDFOperation.IDF.PERSON
{
    internal abstract class Soldier
    {
       private string name;
       private readonly int id;
       private int age;


        // constractor for test
        public Soldier(string name, int id, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }


        // constractor 
        public Soldier()
        {
            this.name = Input.GetName();
            this.id = Input.GetId();
            this.age = Input.GetAge();
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public int GetId()
        {
            return id;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
    }
}
