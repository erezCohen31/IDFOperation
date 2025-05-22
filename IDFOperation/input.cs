using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using IDFOperation.HAMAS;

namespace IDFOperation
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
            Console.WriteLine("enter weapons");
            string[] weapons = Console.ReadLine().Split();
            List<string> weaponList = weapons.ToList();
            
            return weaponList;
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

    }
}
