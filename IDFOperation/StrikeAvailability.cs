using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFOperation.IDF;

namespace IDFOperation
{
    internal class StrikeAvailability
    {
        public static void ShowAvailableStrikes(List<StrikeOption> strikes)
        {
            Console.WriteLine("Available strikes:");
            foreach (var strike in strikes)
            {
                if (strike.GetIsAvailable())
                {

                    Console.WriteLine($"Name: {strike.GetName()}, Ammunition Capacity: {strike.GetAmmunitionCapacity()}, Fuel Supply: {strike.GetFuelSupply()}");
                }
            }
        }
    }
}
