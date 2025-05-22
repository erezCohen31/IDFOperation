using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFOperation.HAMAS;
using IDFOperation.IDF.AMAN;
using IDFOperation.IDF.PERSON;
using IDFOperation.IDF.Strike;

namespace IDFOperation.IDF
{
    internal class Idf
    {
        private DateTime dateOfEstablishment;
        private Commander currentCommnader;
        private List<StrikeOption> strikeOptions;

        public Idf(Commander currentCommnader, List<StrikeOption> strikeOptions)
        {
            this.dateOfEstablishment = new DateTime(1948, 05, 26);

            this.currentCommnader = currentCommnader;
            this.strikeOptions = strikeOptions;
        }
        public DateTime GetDateOfEstablishment()
        {
            return this.dateOfEstablishment;
        }

        public void SetDateOfEstablishment(DateTime dateOfEstablishment)
        {
            this.dateOfEstablishment = dateOfEstablishment;
        }
        public Commander GetCurrentCommnader()
        {
            return this.currentCommnader;
        }
        public void SetCurrentCommnader(Commander currentCommnader)
        {
            this.currentCommnader = currentCommnader;
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
        public void ShowAvailableStrikes()
        {
            Console.WriteLine("Available strikes:");
            foreach (var strike in strikeOptions)
            {
                if (strike.GetIsAvailable())
                {

                    Console.WriteLine($"Name: {strike.GetName()}, Ammunition Capacity: {strike.GetAmmunitionCapacity()}, Fuel Supply: {strike.GetFuelSupply()}");
                }
            }
        }

        public void StrikeExecution(Target target, Terrorist terrorist)
        {
            foreach (var strike in strikeOptions)
            {
                if (strike.GetIsAvailable() && strike.GetTypeOfTarget().Contains(target.GetTypeOfTarget()) && strike.GetFuelSupply() < target.GetFuelNeed())
                {
                    strike.RemoveOneAmmunitionCapacity();
                    strike.RemoveFuel(target.GetFuelNeed());
                    Aman.KillTerrorist(terrorist);
                    Console.WriteLine($"Strike executed on target {target.GetLocation()} using {strike.GetName()}\n" +
                        $" hour: {DateTime.Now}");
                    if (strike.GetAmmunitionCapacity() == 0 || strike.GetFuelSupply() < 200)
                    {
                        strike.SetIsAvailable(false);
                        Console.WriteLine($"{strike.GetName()} is no longer available.");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine($"No available strike option for target {target.GetLocation()}");
                }
            }
        }
    }
}
