using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            var lot = new CarLot();

            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            
            var ford = new Car();
            ford.Year = 2022;
            ford.Make = "ford";
            ford.Model = "f-150";
            ford.EngineNoise = "fassssssst fassssst";
            ford.HonkNoise = "move!!!";
            ford.IsDriveable = true;
            lot.Cars.Add(ford);
            //dodge.Year = 2022;
            //dodge.Make = "dodge";
            //dodge.Model = "dodge";
            //dodge.EngineNoise = "pop pop";
            //dodge.HonkNoise = "to much ram, not enough dodge";
            //dodge.IsDriveable = true;
            var dodge = new Car()
            {
                Year = 2022,
                Make = "dodge",
                Model = "1500",
                EngineNoise = "pop pop",
                HonkNoise = "to much ram not enough dodge!!",
                IsDriveable = true
            };
            lot.Cars.Add(dodge);
            var chevy = new Car(2022, "chevy", "1500 silverado", "girl truckkkkkk", "gaaaaaayyyy", false);
            lot.Cars.Add(chevy);
            //Call each of the methods for each car
            Console.WriteLine("Ford");
            ford.MakeEngineNoise(ford.EngineNoise); ford.MakeHonkNoise(ford.HonkNoise);
            Console.WriteLine("Dodge");
            dodge.MakeEngineNoise(dodge.EngineNoise); dodge.MakeHonkNoise(dodge.HonkNoise);
            Console.WriteLine("Chevy");
            chevy.MakeEngineNoise(chevy.EngineNoise); chevy.MakeHonkNoise(chevy.HonkNoise);

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model} ");
            }

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
