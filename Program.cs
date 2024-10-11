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
        static void Main(string[] args)
        {
            koszon();
        }
    }
}
