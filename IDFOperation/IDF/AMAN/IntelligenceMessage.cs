using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFOperation.HAMAS;
using IDFOperation.TOOLS;

namespace IDFOperation.IDF.AMAN
{
    internal class IntelligenceMessage
    {
        private readonly Terrorist terrorist;
        private readonly DateTime creationTime;
        private readonly string location;

        public IntelligenceMessage(Terrorist terrorist,  DateTime creationTime)
        {
            this.terrorist = terrorist;
            this.creationTime = creationTime;
            this.location = Input.GetLocation();
        }
       
        public Terrorist GetTerrorist()
        {
            return terrorist;
        }
        public string GetLocation()
        {
            return location;
        }
        public DateTime GetCreationTime()
        {
            return creationTime;
        }
    }
}
