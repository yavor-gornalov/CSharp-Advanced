using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    internal class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, Engine engine, int weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        public override string ToString() => $"{this.Model}:\n" +
            $"  {this.Engine.Model}:\n" +
            $"    Power: {this.Engine.Power}\n" +
            $"    Displacement: {(this.Engine.Displacement == 0 ? "n/a" : this.Engine.Displacement)}\n" +
            $"    Efficiency: {this.Engine.Efficiency}\n" +
            $"  Weight: {(this.Weight == 0 ? "n/a" : this.Weight)}\n" +
            $"  Color: {this.Color}";
    }
}
