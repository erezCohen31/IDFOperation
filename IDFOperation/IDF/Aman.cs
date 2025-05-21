using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperation.IDF
{
    internal class Aman
    {
        List<IntelligenceMessage> intelligenceMessages;

        public Aman(List<IntelligenceMessage> intelligenceMessages)
        {
            this.intelligenceMessages = intelligenceMessages;
        }
        public List<IntelligenceMessage> GetIntelligenceMessages()
        {
            return this.intelligenceMessages;
        }
        public void AddIntelligenceMessage(IntelligenceMessage intelligenceMessage)
        {
            this.intelligenceMessages.Add(intelligenceMessage);
        }
        public void RemoveInteligenceMessage(IntelligenceMessage intelligenceMessage)
        {
            this.intelligenceMessages.Remove(intelligenceMessage);
        }
    }
}
