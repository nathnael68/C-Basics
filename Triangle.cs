using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Triangle : Shape
    {
        public double s1 { get; set; } 
        public double s2 { get; set; }
        public double s3 { get; set; }

        public override double getArea()
        {
            double s = this.getPerimeter() / 2; 
            return Math.Sqrt(s * (s - s1) * (s - s2) * (s - s3)); 
        }
        public override double getPerimeter()
        {
            return (s1 + s2 + s3);
        }
    }
}
