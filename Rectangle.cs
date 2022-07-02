using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Rectangle : Shape
    {
        public double width { get; set; }
        public double length { get; set; }
        public override double getArea()
        {
            return width * length;
        }
        public override double getPerimeter()
        {
            return 2 * (width + length);
        }
    }
}
