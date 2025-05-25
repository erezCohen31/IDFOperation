using System;
using System.Collections.Generic;
using IDFOperation.HAMAS;
using IDFOperation.IDF;
using IDFOperation.IDF.AMAN;
using IDFOperation.IDF.PERSON;
using IDFOperation.IDF.Strike;
using IDFOperation.TOOLS;

namespace IDFOperation
{
    internal class Menu
    {
        private readonly Idf idf;
        private readonly Aman aman;
        private readonly Commander commander;
        private readonly Hamas hamas;
        private bool isRunning;

        public Menu()
        {
            this.commander = new Commander("Zamir", 1, 45);
            this.idf = new Idf(commander);
            this.aman = new Aman();
            this.isRunning = true;
            this.hamas = new Hamas();
            InitializeStrikeOptions();
        }

        public void Run()
        {
            while (isRunning)
            {
                Print.ShowMainMenu();
                string choice = Console.ReadLine();
                ProcessChoice(choice);
            }
        }
        private void InitializeStrikeOptions()
        {
            idf.AddStrikeOption(new F16FighterJet("F16", 1000, "Bombes"));
            idf.AddStrikeOption(new Hermes460Drone("Drone Hermes 450", 2000, "Missiles"));
            idf.AddStrikeOption(new M109Artillery("Artillerie M109", 5000, "Obus"));
        }
        private void ProcessChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    TerroristMenu();
                    break;
                case "2":
                    IntelligenceMenu();
                    break;
                case "3":
                    TargetMenu();

                    break;
                case "4":
                    StrikeMenu();

                    break;
                case "5":
                    isRunning = false;
                    Console.WriteLine("\nClosing the system. Goodbye!");
                    break;
                default:
                    Console.WriteLine("\nInvalid option. Please try again.");
                    Console.ReadKey();
                    break;
            }
        }
        private void TerroristMenu()
        {
            bool quit = false;
            while (!quit)
            {
                Print.ShowTerroristMenu();

                switch (Console.ReadLine())
                {
                    case "1":
                        hamas.AddTerrorist();
                        break;
                    case "2":
                        Print.ListTerrorists(hamas);
                        break;
                    case "3":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid option.");
                        break;
                }
                if (!quit)
                {
                    Console.WriteLine("\nPress a key to continue...");
                    Console.ReadKey();
                }
            }
        }
        private void IntelligenceMenu()
        {
            bool quit = false;
            while (!quit)
            {
                Print.ShowIntelligenceMenu();


                switch (Console.ReadLine())
                {
                    case "1":
                        aman.AddIntelligenceMessage(hamas);
                        break;
                    case "2":
                        Print.ShowMostDangerousTerrorist(aman,hamas);
                        break;
                    case "3":
                        Print.MostReportedTerrorist(aman);
                        break;
                    case "4":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid option.");
                        break;
                }
                if (!quit)
                {
                    Console.WriteLine("\nPress a key to continue...");
                    Console.ReadKey();
                }
            }
        }
        private void StrikeMenu()
        {
            bool retur = false;
            while (!retur)
            {
                Print.ShowStrikeMenu();

                switch (Console.ReadLine())
                {
                    case "1":
                        Print.StrikeOptions(idf);
                        break;
                    case "2":
                        idf.StrikeExecution(aman);
                        break;
                    case "3":
                        retur = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid option.");
                        break;
                }
                if (!retur)
                {
                    Console.WriteLine("\nPress a key to continue...");
                    Console.ReadKey();
                }
            }
        }
        private void TargetMenu()
        {
            bool retur = false;
            while (!retur)
            {
                Print.ShowTargetMenu();

                switch (Console.ReadLine())
                {
                    case "1":
                        aman.CreateTarget(hamas);
                        break;
                    case "2":
                        Print.ListTargets(aman);
                        break;
                    case "3":
                        retur = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid option. Please try again.");
                        break;
                }

                if (!retur)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }
        }

    }
}


