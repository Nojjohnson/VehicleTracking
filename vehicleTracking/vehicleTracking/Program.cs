using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicleTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
             /* Vehicle testVehicle = new Vehicle("Opel", "Corsa", eVehicleCondition.GOOD, 85000);
              Console.WriteLine("Car: " + testVehicle.make + " " + testVehicle.model + " - R" + testVehicle.price + ". Condition: " + testVehicle.condition);

              Console.ReadLine();*/ 

            //Vehicle array
            Vehicle[] vehicleArray = new Vehicle[50];
            int numVehicles = 0;

            //Method to list all vehicles
            void DisplayAllVehicles()
            {
                Console.WriteLine("Display All Vehicles");
                Console.WriteLine("-----------------------------");
                for (int loop = 0; loop < numVehicles; loop++);
                {
                    int loop = 0;
                    Console.WriteLine(vehicleArray[loop]);
                }
            }

            //Method to list all cars
            void DisplayAllCars()
            {
                Console.WriteLine("Display All Cars");
                Console.WriteLine("-----------------------");
                for (int loop = 0; loop < numVehicles; loop++)
                {
                    //The 'is' operator returns true if object type is car
                    if (vehicleArray[loop] is Car)
                    {
                        Console.WriteLine(vehicleArray[loop]);
                    }
                }
            }

            //Method to list all trucks
            void DisplayAllTrucks()
            {
                Console.WriteLine("Display All Trucks");
                Console.WriteLine("--------------------------");
                for (int loop = 0; loop < numVehicles; loop++)
                {
                    if (vehicleArray[loop] is Truck)
                    {
                        Console.WriteLine(vehicleArray[loop]);
                    }
                }
            }

            //Method to list all bikes
            void DisplayAllBikes()
            {
                Console.WriteLine("Display All Bikes");
                Console.WriteLine("-------------------------");
                for (int loop = 0; loop < numVehicles; loop++)
                {
                    if (vehicleArray[loop] is Bike)
                    {
                        Console.WriteLine(vehicleArray[loop]);
                    }
                }
            }

            //Method to add vehicles
            void AddVehicle()
            {
                //Declaring variables
                Vehicle v;
                char vehicleType;
                int vehicleCapacity;
                string vehicleMake;
                string vehicleModel;
                eVehicleCondition vehicleCondition;
                double vehiclePrice;

                //Make sure program cant store more than 50 vehicles
                if (numVehicles >= 50)
                {
                    Console.WriteLine("This array is full");
                    //Stops executing the method
                    return;
                }

                //Prompt user for information and read it in
                Console.WriteLine("Add Vehicle");
                Console.WriteLine("------------------");
                Console.WriteLine("Please fill in the following information : ");

                Console.Write("Vehicle Make : ");
                vehicleMake = Console.ReadLine();
                Console.Write("Vehicle Model : ");
                vehicleModel = Console.ReadLine();

                Console.Write("Vehicle Price : ");
                vehiclePrice = Double.Parse(Console.ReadLine());

                Console.Write("Vehicle Condition (0 == Good, 1 == Bad, 2 = Ugly : ");
                vehicleCondition = (eVehicleCondition) Int32.Parse(Console.ReadLine());

                Console.Write("Vehicle Type : ");
                //Only need to check the first letter
                vehicleType = Console.ReadLine()[0];

                //Switch case depending on which type of vehicle is input
                switch(Char.ToLower(vehicleType))
                {
                    case 'c':    //Car
                        //Prompts for correct capacity type
                        Console.Write("Passenger Capacity : ");
                        //Parse the input
                        vehicleCapacity = Int32.Parse(Console.ReadLine());
                        //Create new instance of the Car class
                        v = new Car(vehicleMake, vehicleModel, vehicleCondition, vehiclePrice, vehicleCapacity);
                        break;

                    case 't':    //Truck
                        //Prompts for correct capacity type
                        Console.Write("Cargo Capacity : ");
                        //Parse the input
                        vehicleCapacity = Int32.Parse(Console.ReadLine());
                        //Create new instance of the Truck class
                        v = new Truck(vehicleMake, vehicleModel, vehicleCondition, vehiclePrice, vehicleCapacity);
                        break;

                    case 'b':    //Bike
                        //Prompt for correct capacity type
                        Console.Write("Engine Capacity : ");
                        //Parse the input
                        vehicleCapacity = Int32.Parse(Console.ReadLine());
                        //Create new instance of the Bike class
                        v = new Bike(vehicleMake, vehicleModel, vehicleCondition, vehiclePrice, vehicleCapacity);
                        break;

                    default:    //Invalid input
                        Console.WriteLine("Invalid vehicle type entered. Returning to main menu....");
                        //Stop executing method and return to main menu
                        return;
                        
                }

                //Add the vehicle to the array
                vehicleArray[numVehicles] = v;
                //Increment the count
                numVehicles = numVehicles + 1;

                //Clear the console
                Console.Clear();
                Console.WriteLine("Vehicle Added");

                //Displays a menu and prompts user to make a selection
                 void DisplayMenu()
                {
                    //Clears the screen
                    Console.Clear();

                    Console.WriteLine("Vehicle Tracking");
                    Console.WriteLine("------------------------");
                    Console.WriteLine("1. Add a vehicle");
                    Console.WriteLine("2.Display all vehicles");
                    Console.WriteLine("3. Display all cars");
                    Console.WriteLine("4. Display all trucks");
                    Console.WriteLine("5. Display all bikes");
                    Console.WriteLine("6. Exit");
                    Console.WriteLine("-------------------------");
                    Console.Write("Please make your selection : ");
                }

                //Executes the users choice
                void ExecuteChoice(char c)
                {
                    //Clears the screen
                    Console.Clear();

                    //Switch case to determine which choice the user made
                    switch (c)
                    {
                        case '1':   //Adds a vehicle
                            AddVehicle();
                            break;
                        case '2':   //Displays all vehicles
                            DisplayAllVehicles();
                            break;
                        case '3':   //Displays all cars
                            DisplayAllCars();
                            break;
                        case '4':   //Displays all trucks
                            DisplayAllTrucks();
                            break;
                        case '5':   //Display all bikes
                            DisplayAllBikes();
                            break;
                        case '6':   //Exits
                            Console.WriteLine("Goodbye");
                            break;
                        default:    //Invalid input
                            Console.WriteLine("Please enter a number between one and six");
                            break;
                    }

                    //Pause
                    Console.WriteLine("Please hit any key to continue");
                    Console.ReadLine();
                }

                //Constructor
                DisplayMenu();
                {
                    char choice = ' ';
                    while (choice != '6')
                    {
                        //Display the menu
                        DisplayMenu();
                        //Read in the users choice
                        choice = Console.ReadLine()[0];
                        //Perform the requested operation
                        ExecuteChoice(choice);
                        
                        
                    }
                }

                





                    
            }
        } 
       
           
        
    }
}
