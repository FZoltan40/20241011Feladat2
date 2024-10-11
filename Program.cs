using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat2
{
    internal class Program
    {
        public static void koszon()
        {
           
            int hour = DateTime.Now.Hour;
            Console.WriteLine(hour);

            if (hour < 5)
            {
                Console.WriteLine("Jó éjszakát.");
            }
            else if (hour < 12)
            {
                Console.WriteLine("Jó reggelt.");
            }
            else if (hour < 18)
            {
                Console.WriteLine("Jó napot.");
            }
            else if (hour < 24)
            {
                Console.WriteLine("Jó estét.");
            }
        }
        public static double kamat()
        {
            double megtakaritas=0;
            double betet;
            double kamat;
            int ev;

            Console.Write("Kérem a betét összegét: ");
            betet = int.Parse(Console.ReadLine());
            Console.Write("Kérem a kamatot: ");
            kamat = int.Parse(Console.ReadLine());
            Console.Write("Kérem a megtakarítás hosszát: ");
            ev = int.Parse(Console.ReadLine());

            for (int i = 0; i < ev; i++)
            {
                megtakaritas = (betet*(kamat)/100);
                betet= betet + megtakaritas;
            }

            return megtakaritas;
        }
        static void Main(string[] args)
        {
            //koszon();
            Console.WriteLine(kamat());
        }
    }
}
