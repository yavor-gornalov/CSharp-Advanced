using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        private readonly T value;

        public Box(T value)
        {
            this.value = value;
        }

        //public override string ToString() => this.value.ToString();
        public override string ToString()
        {
            return $"{this.value.GetType().ToString()}: {this.value}";
        }
    }
}
