using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFOperation.HAMAS;
using IDFOperation.IDF.AMAN;
using IDFOperation.IDF.PERSON;
using IDFOperation.IDF.Strike;
using IDFOperation.TOOLS;

namespace IDFOperation.IDF
{
    internal class Idf
    {
        private DateTime dateOfEstablishment;
        private Commander currentCommander;
        private List<StrikeOption> strikeOptions;

        public Idf(Commander currentCommander)
        {
            this.dateOfEstablishment = new DateTime(1948, 05, 26);

            this.currentCommander = currentCommander;
            strikeOptions = new List<StrikeOption>();
        }
        public DateTime GetDateOfEstablishment()
        {
            return this.dateOfEstablishment;
        }
        public void SetDateOfEstablishment(DateTime dateOfEstablishment)
        {
            this.dateOfEstablishment = dateOfEstablishment;
        }
        public Commander GetCurrentCommander()
        {
            return this.currentCommander;
        }
        public void SetCurrentCommander(Commander currentCommander)
        {
            this.currentCommander = currentCommander;
        }
        public List<StrikeOption> GetStrikeOptions()
        {
            return this.strikeOptions;
        }
        public void AddStrikeOption(StrikeOption strikeOption)
        {
            this.strikeOptions.Add(strikeOption);
        }
        public void RemoveStrikeOption(StrikeOption strikeOption)
        {
            this.strikeOptions.Remove(strikeOption);
        }
        public void StrikeExecution(Aman aman)
        {
            //seacrh target
            Target target = SearchTarget(aman);
            
            if (target == null)
            {
                return;
            }

            StrikeOption suitableStrike = strikeOptions.FirstOrDefault(strike =>
                strike.GetIsAvailable() &&
                strike.GetTypeOfTarget().Contains(target.GetTypeOfTarget()) &&
                strike.GetFuelSupply() >= target.GetFuelNeed());

            if (suitableStrike == null)
            {
                Console.WriteLine($"No suitable strike option available for target at {target.GetLocation()}");
                return;
            }


            Console.WriteLine($"Target: {target.GetName()} at {target.GetLocation()}");
            Console.WriteLine($"Using: {suitableStrike.GetName()}");
            Console.WriteLine($"Time: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");

            suitableStrike.RemoveOneAmmunitionCapacity();
            suitableStrike.RemoveFuel(target.GetFuelNeed());
            target.GetTerrorist().SetIsAlive(false);


            Console.WriteLine($"\n Target processed: {target.GetName()}");

            if (suitableStrike.GetAmmunitionCapacity() <= 0 || suitableStrike.GetFuelSupply() < 200)
            {
                suitableStrike.SetIsAvailable(false);
                Console.WriteLine($"\n{suitableStrike.GetName()} is now out of service.");
            }

            Console.WriteLine($"\nStrike completed at {DateTime.Now:HH:mm:ss}");
        }
        public Target SearchTarget(Aman aman)
        {

            Print.Title("EXECUTE A STRIKE");

            // Get existing targets
            List<Target> targets = aman.GetTargets();
            Print.AvailableTarget(targets);

            Console.Write("\nTarget number (or 0 to cancel): ");
            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 0 || choice > targets.Count)
            {
                Console.WriteLine("Invalid selection.");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                return null;
            }


            if (choice == 0) return null; // User cancelled

            return targets[choice - 1];


        }

    }
}
