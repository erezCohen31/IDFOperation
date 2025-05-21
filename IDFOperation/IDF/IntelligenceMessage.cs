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
        private readonly Target target;
        private readonly DateTime creationTime;

        public IntelligenceMessage(Terrorist terrorist, Target target, DateTime creationTime)
        {
            this.terrorist = terrorist;
            this.target = target;
            this.creationTime = creationTime;
        }
        public Terrorist GetTerrorist()
        {
            return this.terrorist;
        }

        public string GetLocation()
        {
            return this.target.GetLocation();
        }
        public DateTime GetCreationTime()
        {
            return this.creationTime;
        }
    }
}
