using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using In = NBCC_WMAD_Console.Input;
using Out = NBCC_WMAD_Console.Output;

namespace NBCC_WMAD_Console
{
    class Program
    {
        /// <summary>
        /// Menu Items are added here
        /// </summary>
        private static void LoadMenu()
        {
            Menu.menuDictionary.Add(0, "Exit");
            Menu.menuDictionary.Add(1, "About the Console");
            Menu.menuDictionary.Add(2, "Car Builder");
        }

        static void Main(string[] args)
        {
            string choice = Init();

            while (choice.ToLower() == "y")
            {
                switch (In.Get<int>(Menu.CreateMenu(), ConsoleColor.Yellow))
                {
                    case 0:
                        choice = "n";
                        break;
                    case 1:
                        AboutThisApp();
                        break;
                    case 2:
                        CarBuilder();
                        break;
                        //Add more options in the menu here
                }
            }

            Out.P("Press any key to exit.");
            Console.ReadLine();
        }

        #region [My Functionality]

        /*
         * My methods will be added here for executing functionality within the console
         */
        //I want to store the cars I create
        static List<Car> myCars = new List<Car>();

        private static void CarBuilder()
        {
            string userCarType = In.GetString("Provide a car type (ie Car, Truck, Van:)", true);
            int userNumberOfDoors = In.GetInt("Provide the number of doors: ");
            int userCarSpeed = In.GetInt("Provide the car speed: ");

            Car car = new Car();

            car.CarType = userCarType;
            car.NumberOfDoors = userNumberOfDoors;
            car.Speed = userCarSpeed;

            Out.P("**********");
            Out.P($"The car created is:\n" +
                $"Type: {car.CarType}\n" +
                $"Number of doors: {car.NumberOfDoors}\n" +
                $"Speed: {car.Speed}\n" +
                $"Price: {car.Price.GetValueOrDefault()}");
            Out.P("**********\n");

            myCars.Add(car);

            Out.P($"I have a car count in my list of: {myCars.Count}");

            if (In.GetString("Do you wnat to list all cars? y/n ").ToUpper()[0] == 'Y') 
            {
                Out.P("");
                foreach (Car c in myCars)
                {
                    Out.P($"Type: {c.CarType} Number of doors: {c.NumberOfDoors} Speed: {c.Speed} Price: {c.Price.GetValueOrDefault()}");
                }
            }

        }

        #endregion

        /// <summary>
        /// The About this App
        /// </summary>
        private static void AboutThisApp()
        {
            Out.P("\n");
            Out.P("This app is the Console Root Application. Build on it by providing new menu items and adding to the switch statement");
            Out.P("\n");
        }

        /// <summary>
        /// Initialize the Console
        /// </summary>
        /// <returns></returns>
        private static string Init()
        {
            LoadMenu();
            string choice = "y";
            Logo.CreateLogo("The Root App");
            return choice;
        }
    }
}
