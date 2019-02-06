//Author: Philippe Lumpkin
//File: Program.cs
//Date: 2/6/2019
//This is the file that declares all of the different bears and then calls each funciton accordingly
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
            //creates different instances accordingly
            Bear bBear = new Grizzly();
            ToyBear tBear = new TeddyBear();
            ToyBear tBear2 = new BearAdapter(bBear);
            //Calls all of the functions that apply.
            Console.WriteLine("Grizzly Bear Created.");
            bBear.hibernate();
            bBear.maul();
            Console.WriteLine("Teddy Bear Created.");
            tBear.Hug();
            Console.WriteLine("Scary Teddy Bear Created.");
            tBear2.Hug();
            Console.WriteLine("Press any key to escape!");
            Console.ReadKey();
        }
    }
}
