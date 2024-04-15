using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    internal class Engine
    {
        public double Speed { get; set; }
        public double Power { get; set; }

        public Engine(double speed, double power)
        {
            this.Speed = speed;
            this.Power = power;
        }
    }
}
