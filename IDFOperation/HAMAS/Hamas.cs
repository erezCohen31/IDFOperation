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
        private static List<Terrorist> terrorists;


        public Hamas(List<Terrorist> cterrorists)
        {
            terrorists = cterrorists;
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
            return terrorists;
        }
        public void Addterrorist(Terrorist terrorist)
        {
           terrorists.Add(terrorist);
        }
        public void RemoveTerrorist(Terrorist terrorist)
        {
          terrorists.Remove(terrorist);
        }



    }
}
