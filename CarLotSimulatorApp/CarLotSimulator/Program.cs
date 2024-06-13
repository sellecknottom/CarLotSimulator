using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            Car car1 = new Car();
            //Dot Notation
            car1.Make = "Buick";
            car1.Model = "Enclave";
            car1.Year = "2024";
            car1.EngineNoise = "quiet";
            car1.HonkNoise = "bright";
            car1.IsDriveable = "driveable";

            Console.WriteLine($"I need to buy a new car. I want a {car1.Year} {car1.Make} {car1.Model}.");
            Console.WriteLine($"Since it is a new car, it will be {car1.EngineNoise}. The horn will be {car1.HonkNoise}" +
                $"\nand it will be {car1.IsDriveable}");
            car1.MakeEngineNoise();
            car1.MakeHonkNoise();
            Console.WriteLine();
            Console.WriteLine($"Car Number:{++CarLot.NumberOfCars}");
            Console.WriteLine();


            //Custom Constructor
            Car car2 = new Car("Jeep", "Grand Cherokee", "2015", "needed work", "softer", "is currently driveable");
            Console.WriteLine($"In march I bought a {car2.Year} {car2.Make} {car2.Model}. The engine {car2.EngineNoise}" +
                $"\nand the horn is {car2.HonkNoise}, but it {car2.IsDriveable}");
            car2.MakeHonkNoise();
            car2.MakeEngineNoise();
            Console.WriteLine();
            Console.WriteLine($"Car Number:{++CarLot.NumberOfCars}");
            Console.WriteLine();

            //object initializer syntax
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            Car car3 = new Car()
            {
                Make = "Toyota",
                Model = "Corolla",
                Year = "2001",
                EngineNoise = "loud",
                HonkNoise = "nasally",
                IsDriveable = "barely driveable"
            };
            Console.WriteLine($"My first car was a {car3.Year} {car3.Make} {car3.Model}. It was {car3.EngineNoise},\n" +
                $"the horn sounded {car3.HonkNoise} and it was {car3.IsDriveable}.");
            Console.WriteLine($"Annoying {car3.MakeHonkNoise}");
            Console.WriteLine($"Not much {car3.MakeEngineNoise}");
            Console.WriteLine();
            Console.WriteLine($"Car Number:{++CarLot.NumberOfCars}");
            Console.WriteLine();


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
