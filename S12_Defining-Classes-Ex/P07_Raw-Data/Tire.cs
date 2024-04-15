using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    internal class Tire
    {
        public int Age { get; set; }
        public double Pressure { get; set; }

        public Tire(int age, double pressure)
        {
            this.Age = age;
            this.Pressure = pressure;
        }
    }
}
