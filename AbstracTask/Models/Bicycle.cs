using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracTask.Models
{
    internal class Bicycle : Vehicle
 {

        public string Type { get; set; }

        public Bicycle(string type ,string factoryName, string model, string color, int driveTime, double drivePath) : base(factoryName, model, color, driveTime, drivePath)
        {
            Type = type;
        }

        

        public override void DefineNatureHarmness()
        {
            Console.WriteLine("Tebiete ziyani yoxdur");
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Type: {Type}");
            DefineNatureHarmness();
        }
    }

}
