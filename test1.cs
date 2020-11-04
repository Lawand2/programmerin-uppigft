using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text1.test
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal = 1;//får inte vara noll från början 
            while (tal != 0)
            {

                Console.WriteLine("skriv din mobil nummer, 0:");
                tal = Convert.ToInt32(Console.ReadLine());
                if (tal % 2 == 0)
                    Console.WriteLine("Talet är jämt");
                else
                    Console.WriteLine("Talet är udda");
            }
        }
    }
}
