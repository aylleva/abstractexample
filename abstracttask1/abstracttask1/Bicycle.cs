using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstracttask1
{
    internal class Bicycle:Vehicle
    {
        public string Type;
        


        public Bicycle(string factoryname, string model, string color, double drivetime,double drivepath,string type) : base(factoryname, model, color, drivetime, drivepath)
        {
            Type = type;
        }

        public override string GetInfo()
        {
            return string.Concat(base.GetInfo(), " ", $"Type:{Type}");
        }

        public override void DefineNatureHarmness()
        {
            Console.WriteLine("No Harmness");
        }
    }
}
