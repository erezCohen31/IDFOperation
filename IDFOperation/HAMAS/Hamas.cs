using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperation.HAMAS
{
    internal class Hamas
    {
        private readonly DateTime dateOfFormation;
        private string commander;
        List<Terrorist> terrorists;


        public Hamas(List<Terrorist> terrorists)
        {
            this.terrorists = terrorists;
            this.commander = "sinwar";
            this.dateOfFormation = new DateTime(1987, 12, 10);
        }

        public DateTime GetFormation()
        {
            return dateOfFormation;
        }
        public void SetCommander(string commander)
        {
            this.commander = commander;
        }
        public string GetCommander()
        {
            return commander;
        }
        public List<Terrorist> GetTerrorists()
        {
            return this.terrorists;
        }
        public void Addterrorist(Terrorist terrorist)
        {
           this. terrorists.Add(terrorist);
        }
        public void RemoveTerrorist(Terrorist terrorist)
        {
          this.terrorists.Remove(terrorist);
        }



    }
}
