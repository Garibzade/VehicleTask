using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AbstracTask.Models
{
    internal abstract class Vehicle
    {
        string _factoryName;
        string _model;
        string _color;
        int _driveTime;
        double _drivePath;

        public string FactoryName
        {
            get
            {
                return _factoryName;
            }
            set
            {
                _factoryName = value;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        public int DriveTime
        {
            get
            {
                return _driveTime;
            }
            set
            {
                _driveTime = value;
            }
        }
        public double DrivePath
        {
            get
            {
                return _drivePath;
            }
            set
            {
                _drivePath = value;
            }
        }

        protected Vehicle(string factoryName, string model, string color, int driveTime, double drivePath)
        {
            FactoryName = factoryName;
            Model = model;
            Color = color;
            DriveTime = driveTime;
            DrivePath = drivePath;


        }

        public double AverageSpeed()
        {
            return DrivePath / DriveTime;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Zavod adi:{FactoryName}\nModel adi:{Model}\nReng:{Color}\nGetme vaxti:{DriveTime}saat\nGetme mesafesi:{DrivePath}km");
            
        }
        public override string ToString()
        {
           return $"{FactoryName}  {Model}";

        }
        public abstract void DefineNatureHarmness();
    }
}
