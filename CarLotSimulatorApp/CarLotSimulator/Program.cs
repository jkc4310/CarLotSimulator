using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            var lot = new CarLot();
            


            //DONE - Create a seperate class file called Car Done
            //DONE - Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONE - Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //DONE - Now that the Car class is created we can instanciate 3 new cars
            //DONE - Set the properties for each of the cars


            // Using Dot Notation
            var KendallsCar = new Car();
            KendallsCar.Year = 2011;
            KendallsCar.Make = "Subaru";
            KendallsCar.Model = "Forester";
            KendallsCar.EngineNoise = "putter";
            KendallsCar.HonkNoise = "Honk";
            KendallsCar.IsDriveable = true;

            lot.Cars.Add(KendallsCar);

            // Object Initializer Syntax
            var CarlosCar = new Car()
            {
                Year = 2023,
                Make = "Ferrari",
                Model = "f1 Car",
                EngineNoise = "waaah",
                HonkNoise = "beep",
                IsDriveable = false,

            };
            lot.Cars.Add(CarlosCar);

            // using the constructer to allow parameter values to be placed inside properties. 
            var ScottsCar = new Car(2023, "Audi", "Q7", "Quiet", "HONK", true);

            lot.Cars.Add(ScottsCar);


            //DONE - Call each of the methods for each car
            KendallsCar.MakeEngineNoise(KendallsCar.EngineNoise);
            CarlosCar.MakeEngineNoise(CarlosCar.EngineNoise);
            ScottsCar.MakeHonkNoise(ScottsCar.HonkNoise);


            //*************BONUS*************//

            // DONE - Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //DONE - Create a CarLot class
            //DONE - It should have at least one property: a List of cars

            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}
