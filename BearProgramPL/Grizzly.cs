//Author: Philippe Lumpkin
//File: Grizzly.cs
//Date: 2/6/2019
//This is the class that will use the interface Bear and declare what hibernate() and maul() both do.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearProgramPL
{
    class Grizzly : Bear
    {
        void Bear.hibernate()
        {
            string brief = "Hibernating bear";
            Console.WriteLine(brief);
        }

        void Bear.maul()
        {
            string brief = "Mauling Bear";
            Console.WriteLine(brief);
        }
    }
}
