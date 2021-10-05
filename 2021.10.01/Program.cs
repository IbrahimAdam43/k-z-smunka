using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021._10._01
{
    class Program
    {
        static void Main(string[] args)
        {
            // feladat();
            //feladat2();
            //feladat3();
            // feladat6();
            //feladat9();
            feladat4();
            Console.WriteLine("Enter");
            Console.ReadLine();
        }
        static void feladat()
        {
            Console.WriteLine("Hello world!");
        }
        static void feladat2()
        {
            Console.Write("Kérema neved! ");
            string nev = Console.ReadLine();
            Console.WriteLine("Szia {0}!", nev);
        }
        static void feladat3()
        {

        }
        static void feladat6()
        {
            Console.Write("Kérem a négyzet oldalát! a=");
            double a = double.Parse(Console.ReadLine());
            double k = 4 * a;
            Console.WriteLine("A négyzet kerülete {0}",k);
            double t = a * a;
            Console.WriteLine("A négyzet területe {0}", t);
            t = Math.Pow(a,2);
            Console.WriteLine("A négyzet területe {0} ", t);
            

        }
        static void feladat9()
        {
            Console.Write("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c= ");
            int c = int.Parse(Console.ReadLine());
            int legkisebb = Math.Min(a, Math.Min(b, c));
            Console.WriteLine("A három szám közül a legkisebb{0}", legkisebb);
        }
        static void feladat4()
        {
            Console.Write("Kérek egy számot: ");
            double a = double.Parse(Console.ReadLine());
            double  = 2 * a;
            Console.WriteLine("A szám kétszerese: {0}", a);
        }
    }
}
