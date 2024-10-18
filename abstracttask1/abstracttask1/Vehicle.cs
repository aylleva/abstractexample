using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstracttask1
{
    internal abstract class Vehicle
    {
        public string FactoryName;
        public string Model;
        public string Color;
        public double DriveTime;
        public double DrivePath;


       public Vehicle (string factoryname,string model,string color,double drivetime,double drivepath)
        {
            FactoryName = factoryname;  
            Model = model;
            Color = color;  
            DriveTime = drivetime;  
            DrivePath = drivepath;
        }

        public double AvarageSpeed()
        {
            double speed = 0;
            speed = (DrivePath / DriveTime);

            return speed;
        }

        public virtual string GetInfo()
        {
          return  $"Factoryname:{FactoryName} Model:{Model} Color:{Color} DriveTime:{DriveTime} DrivePath:{DrivePath}";
        }

        public override string ToString()
        {
            return $"FactoryName:{FactoryName} Model:{Model}";
        }

        public abstract void DefineNatureHarmness();

        

    }
}
