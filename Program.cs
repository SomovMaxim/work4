using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4workSomov
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, min;
            Console.Write("Введите x:");
            x = double.Parse(Console.ReadLine());
            Console.Write("Введите y:");
            y = double.Parse(Console.ReadLine());
            Console.Write("Введите z:");
            z = double.Parse(Console.ReadLine());
            min = x;
            if (y < min)
            {
                min = y;

            }
            if (z < min)
            {
                min = z;
            }
            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}
