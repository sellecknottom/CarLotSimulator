using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car() 
        { 
        }
        //Custom Constructor
        public Car(string make, string model, string year, string engineNoise, string honkNoise, string isDriveable)
        {
            Make = make;
            Model = model;
            Year = year;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public string IsDriveable { get; set; }

        //methods
        public void MakeEngineNoise()
        {
            Console.WriteLine("Vroom Vroom!");
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine("Beep Beep!");
        }
    }
}
