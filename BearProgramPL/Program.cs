using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearProgramPL
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear bBear = new Grizzly();
            ToyBear tBear = new TeddyBear();
            ToyBear tBear2 = new BearAdapter(bBear);

            bBear.hibernate();
            bBear.maul();
            tBear.Hug();
            tBear2.Hug();

            Console.WriteLine("Press any key to escape!");
            Console.ReadKey();
        }
    }
}
