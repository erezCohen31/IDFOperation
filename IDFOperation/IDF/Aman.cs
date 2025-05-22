using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFOperation.HAMAS;

namespace IDFOperation.IDF
{
    internal class Aman
    {
        private static Dictionary<Terrorist, List<IntelligenceMessage>> intelligenceMessagesByTerrorist;

        public Aman(Dictionary<Terrorist, List<IntelligenceMessage>> intelligenceMessagesByTerrorist)
        {
            intelligenceMessagesByTerrorist = intelligenceMessagesByTerrorist;
        }
        public Dictionary<Terrorist, List<IntelligenceMessage>> GetIntelligenceMessages()
        {
            return intelligenceMessagesByTerrorist;
        }
        public List<IntelligenceMessage> GetIntelligenceMessagesByTerrorist(Terrorist terrorist)
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
            if (!intelligenceMessagesByTerrorist.ContainsKey(terrorist))
            {
                intelligenceMessagesByTerrorist.Add(terrorist, new List<IntelligenceMessage>());
            }
            intelligenceMessagesByTerrorist[terrorist].Add(intelligenceMessage);

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
            Console.WriteLine($"name: {dangerousTerrorist.getName()}\n" +
                $"rank: {dangerousTerrorist.getRank()}\n" +
                $"quality score: {dangerousTerrorist.GetQualityRank()}\n" +
                $"latest location: {dangerousTerrorist.GetLocation}");
            return dangerousTerrorist;
        }

    }
}
