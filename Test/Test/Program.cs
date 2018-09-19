using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
           bool maybe = false;
            do
            {
                maybe = true;
                if (maybe)
                {
                    
                    Console.WriteLine("This is functional Code");
                    maybe = false;
                }
                Kieren();
            } while (maybe == false);
        }

        public static void Kieren()
        {
            /* this is kierens part */
            Console.WriteLine("Kierens part");
        }
    }
}
