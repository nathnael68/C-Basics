using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Circle : Shape
    {
        public double radius { get; set; }
        static readonly double pi = 3.14;

        public override double getArea()
        {
            return pi*radius*radius;
        }
        public override double getPerimeter()
        {
            return 2*pi*radius;
        }
    }
}
