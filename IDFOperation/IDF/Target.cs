using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperation.IDF
{
    internal class Target
    {
        private string name;
        private string type;
        private string location;

        public Target(string name, string type, string location)
        {
            this.name = name;
            this.type = type;
            this.location = location;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetTypeOfTarget()
        {
            return this.type;
        }
        public void SetTypeOfTarget(string type)
        {
            this.type = type;
        }
        public string GetLocation()
        {
            return this.location;
        }
        public void SetLocation(string location)
        {
            this.location = location;
        }
    }
}
