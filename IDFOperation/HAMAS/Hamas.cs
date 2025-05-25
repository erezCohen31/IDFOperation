using IDFOperation.TOOLS;

namespace IDFOperation.HAMAS
{
    internal class Hamas
    {
        private readonly DateTime dateOfFormation;
        private string commander;
        private static List<Terrorist> terrorists;


        public Hamas()
        {
            this.commander = "sinwar";
            this.dateOfFormation = new DateTime(1987, 12, 10);
            terrorists = new List<Terrorist>();
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
        public  List<Terrorist> GetTerrorists()
        {
            return terrorists;
        }
        public  void AddTerrorist()
        {
            
            Print.Title("ADD A TERRORIST");

            try
            {
                Terrorist terrorist = new Terrorist();
                terrorists.Add(terrorist);
                Console.WriteLine($"\nTerrorist added successfully! (ID: {terrorist.GetId()})!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nError adding terrorist: " + ex.Message);
            }
        }
        public void RemoveTerrorist(Terrorist terrorist)
        {
            terrorists.Remove(terrorist);
        }
        public static bool KillTerrorist(Terrorist terrorist)
        {
            if (terrorists.Contains(terrorist))
            {
                terrorist.SetIsAlive(false);
                Console.WriteLine($"{terrorist.GetName} dead.");
            }
            return true;
        }



    }
}
