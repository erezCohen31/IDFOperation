using IDFOperation.HAMAS;
using IDFOperation.TOOLS;

namespace IDFOperation.IDF.AMAN
{
    internal class Aman
    {
        private static Dictionary<Terrorist, List<IntelligenceMessage>> intelligenceMessagesByTerrorist;
        private static List<Target> targets;

        public Aman()
        {
            intelligenceMessagesByTerrorist = new Dictionary<Terrorist, List<IntelligenceMessage>>();
            targets = new List<Target>();
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


        public void AddIntelligenceMessage(Hamas hamas)
        {

            Print.Title("ADD INTELLIGENCE REPORT ");

            List<Terrorist> terrorists = hamas.GetTerrorists();
            if (terrorists == null || terrorists.Count == 0)
            {
                Console.WriteLine("No terrorists registered. Please add a terrorist first.");
                return;
            }

            try
            {
                // Display the list of terrorists
                Console.WriteLine("Select a terrorist :");
                for (int i = 0; i < terrorists.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {terrorists[i].GetName()} (ID: {terrorists[i].GetId()})");
                }

                Console.Write("\nTerrorist number : ");
                int index = int.Parse(Console.ReadLine()) - 1;

                if (index < 0 || index >= terrorists.Count)
                {
                    Console.WriteLine("Invalid selection.");
                    return;
                }

                Terrorist terrorist = terrorists[index];

                IntelligenceMessage report = new IntelligenceMessage(terrorist, DateTime.Now);

                // Check if the terrorist already exists in the Hamas terrorists list
                List<Terrorist> existingTerrorists = hamas.GetTerrorists();
                if (!existingTerrorists.Contains(terrorist))
                {
                    Console.WriteLine("not terrorist exist\n" +
                        "add terrorist");
                    return;
                }

                // Add the intelligence message for this terrorist
                if (!intelligenceMessagesByTerrorist.ContainsKey(terrorist))
                {
                    intelligenceMessagesByTerrorist[terrorist] = new List<IntelligenceMessage>();
                }
                intelligenceMessagesByTerrorist[terrorist].Add(report);
                terrorist.SetLocation(report.GetLocation());

                Console.WriteLine("\nIntelligence report added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nError adding report: " + ex.Message);
            }
        }

        public void AddTarget(Target target)
        {
            if (target == null)
                throw new ArgumentNullException(nameof(target));

            targets.Add(target);
        }

        public List<Target> GetTargets()
        {
            return new List<Target>(targets);
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
        public void CreateTarget(Hamas hamas)
        {

            Print.Title("CREATE NEW TARGET");

            List<Terrorist> terrorists = hamas.GetTerrorists();

            // Show list of terrorists with their reports
            Print.ListTerroristAndReports(terrorists, this);


            // Ask user to select a terrorist for the target
            int input = Input.GetId();
            Terrorist selectedTerrorist = terrorists.FirstOrDefault(t => t.GetId() == input);
            if (selectedTerrorist != null)
            {
                // Create target based on terrorist information
                Target target = new Target(selectedTerrorist.GetLocation(), $"Eliminate {selectedTerrorist.GetName()}", selectedTerrorist);
                Console.WriteLine($"\nTarget created for terrorist {selectedTerrorist.GetName()} at {selectedTerrorist.GetLocation()}");
                this.AddTarget(target);
                Console.WriteLine($"\nTarget '{target.GetName()}' created successfully!");
            }
            else
            {
                Console.WriteLine("not terrorist exist");
            }
        }
        public Terrorist FindTheMostDangerousTerrorist()
        {
            if (intelligenceMessagesByTerrorist == null || intelligenceMessagesByTerrorist.Count == 0)
            {
                Console.WriteLine("No terrorists have been registered in the system.");
                return null;
            }

            Terrorist dangerousTerrorist = null;
            int maxTerroristPoint = 0;

            foreach (Terrorist terrorist in intelligenceMessagesByTerrorist.Keys)
            {
                if (terrorist != null)
                {
                    int terroristPoint = terrorist.GetQualityRank();
                    if (terroristPoint > maxTerroristPoint)
                    {
                        maxTerroristPoint = terroristPoint;
                        dangerousTerrorist = terrorist;
                    }
                }
            }

            if (dangerousTerrorist != null)
            {
                Console.WriteLine($"Name: {dangerousTerrorist.GetName()}");
                Console.WriteLine($"Rank: {dangerousTerrorist.Getrank()}");
                Console.WriteLine($"Threat level: {dangerousTerrorist.GetQualityRank()}");
                Console.WriteLine($"Last known location: {dangerousTerrorist.GetLocation()}");
            }
            else
            {
                Console.WriteLine("No dangerous terrorist could be identified.");
            }

            return dangerousTerrorist;
        }






    }
}


