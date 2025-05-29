using IDFOperation.HAMAS;
using IDFOperation.IDF;
using IDFOperation.IDF.AMAN;
using IDFOperation.IDF.Strike;

namespace IDFOperation.TOOLS
{
    internal static class Print
    {
        public static void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("=== SYSTEM OF MANAGEMENT OF IDF OPERATIONS ===");
            Console.WriteLine("1. Terrorist Management");
            Console.WriteLine("2. Intelligence Management");
            Console.WriteLine("3. Target Management");
            Console.WriteLine("4. Strike Management");
            Console.WriteLine("5. Quit");
            Console.Write("\nYour choice (1-5) : ");
        }
        public static void ShowTerroristMenu()
        {
            Console.Clear();
            Console.WriteLine("=== TERRORIST MANAGEMENT ===");
            Console.WriteLine("1. Add a terrorist");
            Console.WriteLine("2. List terrorists");
            Console.WriteLine("3. Back to main menu");
            Console.Write("\nYour choice (1-3) : ");
        }
        public static void ShowIntelligenceMenu()
        {
            Console.Clear();
            Console.WriteLine("=== INTELLIGENCE MANAGEMENT ===");
            Console.WriteLine("1. Add an intelligence report");
            Console.WriteLine("2. Show most dangerous terrorist");
            Console.WriteLine("3. Show most reported terrorist");
            Console.WriteLine("4. Back to main menu");
            Console.Write("\nYour choice (1-4) : ");
        }
        public static void ShowStrikeMenu()
        {
            Console.Clear();
            Console.WriteLine("=== STRIKE MANAGEMENT ===");
            Console.WriteLine("1. Show available strike options");
            Console.WriteLine("2. Execute a strike");
            Console.WriteLine("3. Back to main menu");
            Console.Write("\nYour choice (1-3) : ");
        }
        public static void ShowTargetMenu()
        {
            Console.Clear();
            Console.WriteLine("=== TARGET MANAGEMENT ===");
            Console.WriteLine("1. Add a target");
            Console.WriteLine("2. List targets");
            Console.WriteLine("3. Back to main menu");
            Console.Write("\nYour choice (1-3) : ");

        }
        public static void ShowMostDangerousTerrorist(Aman aman,Hamas hamas)
        {
            Console.Clear();
            Console.WriteLine("\n=== MOST DANGEROOUS TERRORIST ===\n");

            Terrorist terrorist = aman.FindTheMostDangerousTerrorist(hamas);
            if (terrorist != null)
            {
                Console.WriteLine($"Name: {terrorist.GetName()}");
                Console.WriteLine($"Rank: {terrorist.Getrank()}");
                Console.WriteLine($"Quality Rank: {terrorist.GetQualityRank()}");
                Console.WriteLine($"Location: {terrorist.GetLocation()}");
            }
            else
            {
                Console.WriteLine("No terrorist found in the database.");
            }
        }
        public static void ListTargets(Aman aman)
        {
            Console.Clear();
            Console.WriteLine("=== TARGET LIST ===\n");

            List<Target> targets = aman.GetTargets();
            if (targets.Count == 0)
            {
                Console.WriteLine("No targets available.");
                return;
            }

            foreach (Target target in targets)
            {
                Console.WriteLine($"Name: {target.GetName()}");
                Console.WriteLine($"Type: {target.GetTypeOfTarget()}");
                Console.WriteLine($"Location: {target.GetLocation()}");
                Console.WriteLine($"Fuel needed: {target.GetFuelNeed():F2}");
                Console.WriteLine();
            }
        }
        public static void ListTerrorists(Hamas hamas)
        {
            Print.Title("TERRORIST LIST");

            List<Terrorist> terrorists = hamas.GetTerrorists();
            if (terrorists == null || terrorists.Count == 0)
            {
                Console.WriteLine("No terrorists registered.");
                return;
            }

            foreach (Terrorist t in terrorists)
            {
                Console.WriteLine($"ID: {t.GetId()}");
                Console.WriteLine($"Name: {t.GetName()}");
                Console.WriteLine($"Rank: {t.Getrank()}");
                Console.WriteLine($"Alive: {(t.GetIsAlive() ? "Yes" : "No")}");
                Console.WriteLine($"Location: {t.GetLocation()}");

                List<Weapon> WeaponsList = t.GetWeapons();
                Console.Write("Weapons: ");
                if (WeaponsList != null && WeaponsList.Count > 0)
                {
                    foreach (Weapon weapon in WeaponsList)
                    {
                        Console.Write($"{weapon.GetName()}, ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("No weapons");
                }

                Console.WriteLine("----------------------------------------");
            }
        }
        public static void MostReportedTerrorist(Aman aman)
        {


            Print.Title("MOST REPORTED TERRORIST");

            Terrorist terrorist = aman.FindMostReportedTerrorist();
            if (terrorist != null)
            {
                List<IntelligenceMessage> repports = aman.GetIntelligenceMessagesByTerrorist(terrorist);
                Console.WriteLine($"Name: {terrorist.GetName()}");
                Console.WriteLine($"Number of reports: {repports?.Count ?? 0}");
                Console.WriteLine($"Last report: {repports?[0]?.GetCreationTime()}");
                Console.WriteLine($"Location: {terrorist.GetLocation()}");
            }
            else
            {
                Console.WriteLine("No reports found in the database.");
            }
        }
        public static void StrikeOptions(Idf idf)
        {
            Print.Title("AVAILABLE STRIKE OPTIONS");

            Console.WriteLine("Available strikes:");
            foreach (StrikeOption strike in idf.GetStrikeOptions())
            {
                if (strike.GetIsAvailable())
                {

                    Console.WriteLine($"Name: {strike.GetName()}, Ammunition Capacity: {strike.GetAmmunitionCapacity()}, Fuel Supply: {strike.GetFuelSupply()}");
                }
            }

        }
        public static void Title(string title)
        {
            Console.Clear();
            Console.WriteLine($"\n=== {title} ===\n");

        }
        public static void ListTerroristAndReports(List<Terrorist> terrorists, Aman aman)
        {
            Console.WriteLine("=== LIST OF TERRORISTS ===\n");


            if (terrorists == null || terrorists.Count == 0)
            {
                Console.WriteLine("No terrorists available. Please add a terrorist first.");
                return;
            }

            // Display each terrorist with their reports
            foreach (Terrorist terrorist in terrorists)
            {
                Console.WriteLine($"\nID: {terrorist.GetId()}");
                Console.WriteLine($"Name: {terrorist.GetName()}");
                Console.WriteLine($"Location: {terrorist.GetLocation()}");

                // Get intelligence reports for this terrorist
                List<IntelligenceMessage> reports = aman.GetIntelligenceMessagesByTerrorist(terrorist);
                if (reports != null && reports.Count > 0)
                {
                    Console.WriteLine("  Intelligence Reports:");
                    foreach (IntelligenceMessage report in reports)
                    {
                        Console.WriteLine($"  - {report.GetCreationTime().ToShortDateString()}: {report.GetLocation()}");
                    }
                }
                else
                {
                    Console.WriteLine("  No intelligence reports for this terrorist.");
                }
                Console.WriteLine("----------------------------------------");
            }
        }
        public static void AvailableTarget(List<Target> targets)
        {
            if (targets == null || targets.Count == 0)
            {
                Console.WriteLine("No targets available. Please create targets first.");
               
                return;
            }


            // Display available targets
            Console.WriteLine("Select a target to strike:");
            for (int i = 0; i < targets.Count; i++)
            {
                Target target = targets[i];
                Console.WriteLine($"{i + 1}. {target.GetName()} - {target.GetLocation()} (Type: {target.GetTypeOfTarget()})");
            }
        }
    }
}
