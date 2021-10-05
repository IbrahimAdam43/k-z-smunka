using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020._09._30
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            feladat3();
            Console.WriteLine("nyomj le 1 billentyűt");
            Console.ReadKey();
        }
        static void feladat1()
        {
            Console.Write("Kérek egy számot: ");    
          int sec =int.Parse(Console.ReadLine());
            if (sec<16)
            {
                Console.WriteLine("{0} * 10 = {1} ", sec, sec*10);
            }
            else
            {
                Console.WriteLine("{0} / 3 = {1:0.00} ", sec, (double) sec / 3);
                double kerekitve = Math.Round((double)sec / 3, 2);
                Console.WriteLine(kerekitve);
            }
        }
        static void feladat2()
        {
            Console.Write("Kérek egy számot: ");
            int sec = Convert.ToInt32(Console.ReadLine());
            if (sec %2==0)
            {
                Console.WriteLine("Páros a szám");
            }
            else
            {
                Console.WriteLine("Páratlan");
            }
        }
        static void feladat3()
        {
            Console.Write("Kérek egy tíz és ötven között: ");
            int sec = int.Parse(Console.ReadLine());
            if (Math.Floor((double)sec/ 10)==1)
            {
                Console.WriteLine("tízesek");
            }
            else if (Math.Floor((double)sec / 10) == 2)
            {
                Console.WriteLine("Húszasok");
            }
            else if (Math.Floor((double)sec / 10) == 3)
            {
                Console.WriteLine("Harmincasok");
            }
            else if (Math.Floor((double)sec / 10) == 4)
            {
                Console.WriteLine("Negyvenesek");
            }
            else if (Math.Floor((double)sec / 10) == 5)
            {
                Console.WriteLine("Ötvenesek");
            }
        }
    }
}
