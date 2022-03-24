using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property
        public Car(int year, string make, string model, string enginenOise, string honknOise, bool driveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = enginenOise;
            HonkNoise = honknOise;
            isDriveable = driveable;
            
            
        }

        public Car()
        {
            CarLot.NumberOfCars++;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }

        public bool isDriveable = false;
        public void MakeEngineNoise(string EngineNoise)
        {
            Console.WriteLine(EngineNoise);
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }
    }
}
  

