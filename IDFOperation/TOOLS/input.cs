using IDFOperation.HAMAS;

namespace IDFOperation.TOOLS
{
    internal static class Input
    {
        // for Terrorist


        // get name 
        static public string GetName()
        {
            Console.WriteLine("enter the name");
            string name = Console.ReadLine();
            return name;
        }


        // get Rank  
        static public int GetRank()
        {
            Console.WriteLine("enter Rank between 1 - 5");
            int rank = int.Parse(Console.ReadLine());
            return rank;
        }


        // get weapons
        public static List<string> GetWeaponsList()
        {
            List<string> currentWeapons = new List<string>();

            Console.WriteLine("\nAdd weapons (select number or type 'end' to finish):");

            while (true)
            {
                // Display available weapons
                Console.WriteLine("\nAvailable weapons:");
                int i = 1;
                foreach (KeyValuePair<string, int> weapon in Weapon.WeaponDictionary)
                {
                    Console.WriteLine($"{i++}. {weapon.Key} (Danger: {weapon.Value})");
                }

                Console.Write("\nSelect weapon (number) or type 'end': ");
                string input = Console.ReadLine().ToLower();

                if (input == "end")
                    break;

                if (int.TryParse(input, out int weaponIndex))
                {
                    if (weaponIndex > 0 && weaponIndex <= Weapon.WeaponDictionary.Count)
                    {
                        string selectedWeapon = Weapon.WeaponDictionary.Keys.ElementAt(weaponIndex - 1);
                        currentWeapons.Add(selectedWeapon);
                        Console.WriteLine($"Added: {selectedWeapon} (Danger: {Weapon.WeaponDictionary[selectedWeapon]})");
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number or 'end'.");
                }
            }
            return currentWeapons;
        }


        // get location
        public static string GetLocation()
        {
            Console.WriteLine("enter location of terrorist");
            string currentLocation = Console.ReadLine();
            return currentLocation;
        }



        // for Weapon


        // create weapon - name
        public static string GetWeaponName()
        {
            Console.WriteLine("enter the weapon type");
            string weapon = Console.ReadLine();
            return weapon;
        }


        // create weapon - point
        public static int GetPointOfWeapon()
        {
            Console.WriteLine("enter weapon level 1 - 3 \n knife = 1 \n gun = 2 \n M16/AK47 = 3");
            int level = int.Parse(Console.ReadLine());
            return level;
        }



        //  for Target


        // get type of target
        public static string TypeOfTarget()
        {
            Console.WriteLine("enter type of target");
            string type = Console.ReadLine();
            return type;
        }


        //  for Soldier


        // get age
        public static int GetAge()
        {
            Console.WriteLine("enter age");
            int age = int.Parse(Console.ReadLine());
            return age;
        }


        // get id 
        public static int GetId()
        {
            Console.WriteLine("enter i.d number");
            int id = int.Parse(Console.ReadLine());
            return id;
        }



        // for StrikeOption
        public static string GetBombType()
        {
            Console.WriteLine("enter bomb type");
            string bombType = Console.ReadLine();
            return bombType;
        }

        // get fuel 
        public static double GetFuel()
        {
            Console.WriteLine("enter quantity of fuel");
            double fuel = double.Parse(Console.ReadLine());
            return fuel;
        }
        public static string GetIdToSearch()
        {
            Console.Write("\nEnter the ID of the terrorist to target (or press Enter to create a generic target): ");
            string input = Console.ReadLine();
            return input;
        }

        public static int GetConfidence()
        {
            int confidenceLevel;

            do
            {
                Console.WriteLine("enter the confidence level 1-100");

                confidenceLevel = int.Parse(Console.ReadLine());
            }
            while (confidenceLevel > 100 && confidenceLevel < 0);


            return confidenceLevel;

        }
        public static string GetSource()
        {
            Console.WriteLine("enter the source");
            return Console.ReadLine();
        }
    }
}
