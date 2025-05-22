using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFOperation.HAMAS;

namespace IDFOperation.IDF.AMAN
{
    internal class Aman
    {
        private static Dictionary<Terrorist, List<IntelligenceMessage>> intelligenceMessagesByTerrorist;

        public Aman()
        {
            intelligenceMessagesByTerrorist = new Dictionary<Terrorist, List<IntelligenceMessage>>();
        }
        public Dictionary<Terrorist, List<IntelligenceMessage>> GetIntelligenceMessages()
        {
            return intelligenceMessagesByTerrorist;
        }
        public  List<IntelligenceMessage> GetIntelligenceMessagesByTerrorist(Terrorist terrorist)
        {
            if (intelligenceMessagesByTerrorist.ContainsKey(terrorist))
            {
                return intelligenceMessagesByTerrorist[terrorist];
            }
            else
            {
                return null;
            }
        }
       
       
        public void AddIntelligenceMessage(IntelligenceMessage intelligenceMessage, Terrorist terrorist)
        {
            List<Terrorist> hamasList = new List<Terrorist>();
            if (!hamasList.Contains(terrorist))
            {
                Hamas.Addterrorist(terrorist);
            }
            if (!intelligenceMessagesByTerrorist.ContainsKey(terrorist))
            {
                intelligenceMessagesByTerrorist.Add(terrorist, new List<IntelligenceMessage>());
            }
            intelligenceMessagesByTerrorist[terrorist].Add(intelligenceMessage);

        }
        public Terrorist FindMostReportedTerrorist()
        {
            Terrorist mostReportTerrorist = null;
            int max = 0;
            foreach (KeyValuePair<Terrorist, List<IntelligenceMessage>> terroristAndReports in intelligenceMessagesByTerrorist)
            {
                if (terroristAndReports.Value.Count > max)
                {
                    max = terroristAndReports.Value.Count;
                    mostReportTerrorist = terroristAndReports.Key;
                }
            }
            return mostReportTerrorist;
        }
        public Terrorist FindTheMostDangerousTerrorist()
        {
            Terrorist dangerousTerrorist = null;
            int maxTerroristPoint = 0;
            foreach (Terrorist terrorist in intelligenceMessagesByTerrorist.Keys)
            {
                int terroristPoint = terrorist.GetQualityRank();
                if (terroristPoint > maxTerroristPoint)
                {
                    maxTerroristPoint = terroristPoint;
                    dangerousTerrorist = terrorist;
                }

            }
            Console.WriteLine($"name: {dangerousTerrorist.GetName()}\n" +
                $"rank: {dangerousTerrorist.Getrank()}\n" +
                $"quality score: {dangerousTerrorist.GetQualityRank()}\n" +
                $"latest location: {dangerousTerrorist.GetLocation}");
            return dangerousTerrorist;
        }






    }
}


