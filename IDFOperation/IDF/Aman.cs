using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFOperation.HAMAS;
using IDFOperation.IDF;

namespace IDFOperation.IDF
{
    internal class Aman
    {
        Dictionary<Terrorist, List<IntelligenceMessage>> intelligenceMessagesByTerrorist;

        public Aman(Dictionary<Terrorist, List<IntelligenceMessage>> intelligenceMessagesByTerrorist)
        {
            this.intelligenceMessagesByTerrorist = intelligenceMessagesByTerrorist;
        }
        public Dictionary<Terrorist, List<IntelligenceMessage>> GetIntelligenceMessages()
        {
            return this.intelligenceMessagesByTerrorist;
        }
        public List<IntelligenceMessage> GetIntelligenceMessagesByTerrorist(Terrorist terrorist)
        {
            if (this.intelligenceMessagesByTerrorist.ContainsKey(terrorist))
            {
                return this.intelligenceMessagesByTerrorist[terrorist];
            }
            else
            {
                return null;
            }
        }
        public void AddIntelligenceMessage(IntelligenceMessage intelligenceMessage, Terrorist terrorist)
        {
            if (!this.intelligenceMessagesByTerrorist.ContainsKey(terrorist))
            {
                this.intelligenceMessagesByTerrorist.Add(terrorist, new List<IntelligenceMessage>());
            }
            this.intelligenceMessagesByTerrorist[terrorist].Add(intelligenceMessage);

        }


        public Terrorist FindMostReportedTerrorist()
        {
            Terrorist mostReportTerrorist = null;
            int max = 0;
            foreach (KeyValuePair<Terrorist, List<IntelligenceMessage>> terroristAndReports in intelligenceMessagesByTerrorist)
            {
                if(terroristAndReports.Value.Count > max)
                {
                    max = terroristAndReports.Value.Count;
                    mostReportTerrorist = terroristAndReports.Key;
                }
            }
            return mostReportTerrorist;
        }
      
    }
}


