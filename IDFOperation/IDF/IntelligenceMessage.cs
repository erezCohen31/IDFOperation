using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFOperation.HAMAS;

namespace IDFOperation.IDF
{
    internal class IntelligenceMessage
    {
        private readonly Terrorist terrorist;
        private readonly string location;
        private readonly DateTime creationTime;

        public IntelligenceMessage(Terrorist terrorist, string location, DateTime creationTime)
        {
            this.terrorist = terrorist;
            this.location = location;
            this.creationTime = creationTime;
        }
        public Terrorist GetTerrorist()
        {
            return this.terrorist;
        }

        public string GetLocation()
        {
            return this.location;
        }
        public DateTime GetCreationTime()
        {
            return this.creationTime;
        }
    }
}
