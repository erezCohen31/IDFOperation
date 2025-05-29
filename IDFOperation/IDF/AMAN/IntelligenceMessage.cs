using IDFOperation.HAMAS;
using IDFOperation.TOOLS;

namespace IDFOperation.IDF.AMAN
{
    internal class IntelligenceMessage
    {
        private readonly Terrorist terrorist;
        private readonly DateTime creationTime;
        private readonly string location;
        private int confidence;
        string source;


        public IntelligenceMessage(Terrorist terrorist, DateTime creationTime)
        {
            this.terrorist = terrorist;
            this.creationTime = creationTime;
            this.location = Input.GetLocation();
            this.confidence = Input.GetConfidence();
            this.source = Input.GetSource();

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
        public int GetConfidence()
        {
            return confidence;
        }
        public string GetSource()
        {
            return source;
        }
    }
}
