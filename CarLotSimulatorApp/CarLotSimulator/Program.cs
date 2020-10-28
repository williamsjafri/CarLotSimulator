using System;

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


            Car car1 = new Car();
            car1.Year = 2013;
            car1.Make = "Toyota";
            car1.Model = "Sienna";
            car1.EngineNoise = "Vroom";
            car1.HonkNoise = "tutut";
            car1.IsDriveable  = true;

            Car car2 = new Car();
            car2.Year = 2013;
            car2.Make = "Ford";
            car2.Model = "Focus";
            car2.EngineNoise = "nguing";
            car2.HonkNoise = "honkhonk";
            car2.IsDriveable  = true;

            Car car3 = new Car();
            car3.Year = 2013;
            car3.Make = "Lexus";
            car3.Model = "Rx";
            car3.EngineNoise = "tratatata";
            car3.HonkNoise  = "titutitu";
            car3.IsDriveable  = true ;//Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

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
