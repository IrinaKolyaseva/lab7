using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну ребра куба");
            double a = Convert.ToDouble(Console.ReadLine());
            VScub(a);
            Console.ReadKey();
        }
        static void VScub(double a)
        {
            double V = Math.Pow(a, 3);
            double S = (6 * Math.Pow(a, 2));
            Console.WriteLine("L ребра = {0} \n V = {1:N2} \n S пов-ти = {2:N2} ", a, V, S);
        }
    }
}
