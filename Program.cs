// See https://aka.ms/new-console-template for more information
using Exercise;
Circle c1 = new Circle { radius = 21 };
Rectangle r1 = new Rectangle { length = 14.2, width = 10.6 };
Triangle t1 = new Triangle();
Console.WriteLine("Enter the sides of the triangle");
t1.s1 = Convert.ToDouble(Console.ReadLine());
t1.s2 = Convert.ToDouble(Console.ReadLine());
t1.s3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Area of Circle = " + Math.Round(c1.getArea(), 3));
Console.WriteLine("Perimeter of Circle = " + Math.Round(c1.getPerimeter(), 3) + '\n');

Console.WriteLine("Area of Rectangle = " + Math.Round(r1.getArea(), 3));
Console.WriteLine("Perimeter of Rectangle = " + Math.Round(r1.getPerimeter(), 3) + '\n');

Console.WriteLine("Area of Triangle = " + Math.Round(t1.getArea(), 3));
Console.WriteLine("Perimeter of Triangle = " + Math.Round(t1.getPerimeter(), 3) + '\n');
