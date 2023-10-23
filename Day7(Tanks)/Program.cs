using MyClassLib.WorldOfTanks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Tanks_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tank t34 = new Tank("Т-34");
            Tank pantera = new Tank("Pantera");

            Console.WriteLine(t34.GetTankParameters());
            Console.WriteLine(pantera.GetTankParameters());

            if (t34 ^ pantera)
            {
                Console.WriteLine("Т-34 победил в бою!");
            }
            else
            {
                Console.WriteLine("Pantera победил в бою!");
            }
        }
    }
}
