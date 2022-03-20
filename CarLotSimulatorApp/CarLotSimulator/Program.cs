using System;
using System.Collections.Generic;
using System.Linq;
namespace CarLotSimulator
{
    class Program
    {
        public static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            CarLot listOfCars = new CarLot();
            Car buick = new Car
            {

                Year = 2011,
                Make = "Buick",
                Model = "Sonata",
                EngineNoise = "burr",
                isDriveable = true,
                HonkNoise = "boop",
            };
            buick.MakeEngineNoise(buick.EngineNoise);
            buick.MakeHonkNoise();
            listOfCars.Carlots.Add(buick);

            Car porsche = new Car
            {
                Year = 2011,
                Make = "Porsche",
                Model = "Panera",
                EngineNoise = "prrr",
                isDriveable = true,
                HonkNoise = "yaack"
            };
            porsche.MakeEngineNoise(porsche.EngineNoise);
            porsche.MakeHonkNoise();
            listOfCars.Carlots.Add(porsche);

            Car ferrari = new Car();

            ferrari.Year = 2045;
            ferrari.Make = "ferrari";
            ferrari.Model = "Ghost";
            ferrari.EngineNoise = "hatchachacha";
            ferrari.isDriveable = false;
            ferrari.HonkNoise = "wee woo";

            ferrari.MakeEngineNoise(ferrari.EngineNoise);
            ferrari.MakeHonkNoise();
            listOfCars.Carlots.Add(ferrari);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            // object initializer syntax
            Car benzo = new Car() { EngineNoise = "wisssp", HonkNoise = "beep", Model = "Ghost", Make = "Ferrari", isDriveable = false, Year = 3000 };
            benzo.MakeHonkNoise();
            benzo.MakeEngineNoise(ferrari.EngineNoise);



            //constructor initialization
            Car lambo = new Car(2015, "Lambo", "Torch", "chirp", "beepbeep", false);
            lambo.MakeHonkNoise();
            lambo.MakeEngineNoise(lambo.EngineNoise);

            //*************BONUS X 2*************//

            foreach (var car in listOfCars.Carlots)
            {
                Console.WriteLine(car.Year);
                Console.WriteLine(car.Make);
                Console.WriteLine(car.Model);
            }
        }
    }       
} 






            




    

    //Create a CarLot class
    //It should have at least one property: a List of cars
    //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
    //At the end iterate through the list printing each of car's Year, Make, and Model to the console











