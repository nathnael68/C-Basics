using System;
using Lab1;
namespace program;
class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter a number: ");
        string i = Console.ReadLine();
        int ia = Convert.ToInt32(i);
        if (ia % 2 == 0)
            Console.WriteLine("The value is even.");
        else
            Console.WriteLine("The value is odd.");

        Student s = new Student();
        s.id = 3;
        s.name = "Nati";
    }
}
