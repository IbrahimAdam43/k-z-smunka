using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021._12._10
{
    class Program
    {
        static Random rnd = new Random();
        private static int szam;
        private static object ajto;

        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            //feladat3();
            //feladat4();
            //feladat5();
            //feladat6();
            //feladat7();
            //feladat8();
            //feladat9();
            //feladat10();
            Feladat11();
        }
        static void feladat1()
        {
            char asztal;
        }
        static void feladat2()
        {
            int husz;
        }
        static void feladat3()
        {
            double eger;
        }
        static void feladat4()
        {
            bool logikai;
        }
        static void feladat5()
        {
            Console.Write("Kérek egy szót: ");
            Console.ReadLine();

        }
        static void feladat6()
        {
            Console.Write("Kérek egy mondatot:");
            string mondat = Console.ReadLine();

        }
        static void feladat7()
        {
            Console.WriteLine("Adj meg egy karaktert! ");
            char karakter = char.Parse(Console.ReadLine());
        }
        static void feladat8()
        {
            Console.Write("Kerek egy egyesz szamot: ");
            int szam =int.Parse(Console.ReadLine());

        }
        static void feladat9()
        {
            Console.Write("Kerek egy számot: ");
            double valos = double.Parse(Console.ReadLine());
            Console.WriteLine(valos*2);
            Console.WriteLine(Math.PI*valos);
            Console.WriteLine(Math.Pow(valos,3));
            Console.WriteLine(Math.Pow(valos,(double) 1/2));
            Console.WriteLine(Math.Sqrt(valos));
            Console.WriteLine(Math.Round(Math.Sqrt(valos),2));
            Console.ReadLine();

        }
        static void feladat10()
        {
            int veletlen = rnd.Next(10, 51);
            Console.WriteLine("veletlen: {0}", veletlen);
            Console.ReadLine();
        }
        static void Feladat11()
        {
            if (szam % 2 == 0)
            {
                Console.WriteLine("A {0} páros", szam);
            }
            else
            {
                Console.WriteLine("A {0} paratlan szám", szam);
            }
            if (szam > 0)
            {
                Console.WriteLine("A {0} pozítív", szam);
            }
            else if (szam < 0)
            {
                Console.WriteLine("A {0} negatív", szam);
            }
            else 
            {
                Console.WriteLine("A {0} nulla", szam);
            }
            Console.WriteLine("A szó {0} karakterből áll" ajto.Legnth);
            string maganhangzok = "aáeéoóöőüűuú";
            int dbmh = 0;
            foreach (var item in mondat)
            {
                if (maganhangzok.Contains(item.tostring().tolower());
                {
                    dbmh++;
                }
            }
            Console.WriteLine("A maganhangzók száma: {0}", dbmh);
            Console.ReadLine();
        }

    }
}
