using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стророны 1 треугольника");
            double ao = Convert.ToDouble(Console.ReadLine());
            double ad = Convert.ToDouble(Console.ReadLine());
            double at = Convert.ToDouble(Console.ReadLine());
            double so = Geron(ao, ad, at);

            Console.WriteLine("Введите стророны 2 треугольника");
            double bo = Convert.ToDouble(Console.ReadLine());
            double bd = Convert.ToDouble(Console.ReadLine());
            double bt = Convert.ToDouble(Console.ReadLine());
            double sd = Geron(bo, bd, bt);


            if (so > sd)
            {
                Console.WriteLine("S первого треугольника больше = {0} \nS второго треугольника меньше = {1:N2}", so, sd);
            }
            else if (so < sd)
            {
                Console.WriteLine("S первого треугольника меньше = {0} \n S второго треугольника больше  = {1:N2}", so, sd);
            }
            else if (so == sd && so != 0)
            {
                Console.WriteLine("S первого и второго треугольника равна = {0}= {1:N2}", so, sd);
            }
            Console.ReadKey();
        }
        static double Geron (double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }
    }
}