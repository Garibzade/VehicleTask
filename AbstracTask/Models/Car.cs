using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracTask.Models
{
    internal class Car : Vehicle
    {

        byte _doorCount;
        bool _isElectricCar;

        

        public byte DoorCount
        {
            get
            { return _doorCount; }
            set
            {
                if (value > 1 && value < 5)
                {
                    _doorCount = value;
                }

            }

        }
        public bool IsElectricCar
        {
            get { return _isElectricCar; }


            set
            {
                if (value == true)
                {
                    _isElectricCar = true;

                }
            }
        }



        public Car(byte doorcount , bool iselectriccar, string factoryName, string model, string color, int driveTime, double drivePath) : base(factoryName, model, color, driveTime, drivePath)
        {
            DoorCount=doorcount;
            IsElectricCar=iselectriccar;
        }



        public override void DefineNatureHarmness()
        {
            if (_isElectricCar) { Console.WriteLine("Low damege"); }
            else
            {
                Console.WriteLine("High damege");
            }
                
         
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Qapi sayi:"+DoorCount);
            Console.WriteLine($"Elektrikli masindir: {(IsElectricCar ? "He" : "Yox")}");
            DefineNatureHarmness();
        }
        
    }
}
