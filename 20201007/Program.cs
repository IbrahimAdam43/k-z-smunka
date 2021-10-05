using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20201007
{
    class Program
    {
        
        static void Main(string[] args)
        
        {

            Console.Write("Kérek egy számot: ");
            int sec = int.Parse(Console.ReadLine());
            if (sec < 1 || sec > 12)
            {
                Console.Write("Nem megfelelő szám!");
            }
            else
            {
                switch (sec)
                {
                    case 1:
                        Console.WriteLine("Januar");
                        break;

                    case 2:
                        Console.WriteLine("Február");
                        break;

                    case 3:
                        Console.WriteLine("Március");
                        break;

                    case 4:
                        Console.WriteLine("Április");
                        break;

                    case 5:
                        Console.WriteLine("Május");
                        break;

                    case 6:
                        Console.WriteLine("Június");
                        break;

                    case 7:
                        Console.WriteLine("Július");
                        break;

                    case 8:
                        Console.WriteLine("Augusztus");
                        break;

                    case 9:
                        Console.WriteLine("Szeptember");
                        break;

                    case 10:
                        Console.WriteLine("Október");
                        break;

                    case 11:
                        Console.WriteLine("November");
                        break;

                    case 12:
                        Console.WriteLine("December");
                        break;

                }

            }
        }
        static void Feladat2()
        {
            Console.Write("Kérek egy számot: ");
            int sec = int.Parse(Console.ReadLine());
            if (sec < 1 || sec > 12)
            {
                Console.Write("Nem megfelelő szám!");
            }
            else
            {
                switch (sec)
                {
                    case 1:
                        Console.Write("Tavasz");
                        break;
                    case 2:
                        Console.Write("Nyár");
                        break;

                    case 3:
                        Console.Write("Ősz");
                        break;

                    case 4:
                        Console.Write("Tél");
                        break;
                }
            }
        }
    }
}
