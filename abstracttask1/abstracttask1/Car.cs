using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstracttask1
{
    internal class Car:Vehicle
    {
        public int DoorCount;
        public bool isElectricCar;



        public Car(string factoryname, string model, string color, double drivetime, double drivepath,int doorcount,bool iselectriccar):
        base(factoryname, model, color, drivetime, drivepath)
        {
         DoorCount = doorcount;
         isElectricCar = iselectriccar;  
        }

        public override string GetInfo()
        {
            return string.Concat(base.GetInfo(), " ", $"DoorCount:{DoorCount} isElectricCar:{isElectricCar}");
        }

        public override void DefineNatureHarmness()
        {
           if(isElectricCar==false)
            {
                Console.WriteLine("High harmness");
            }
            else
            {
                Console.WriteLine("Low harmness");
            }
        }
    }
}
