//Author: Philippe Lumpkin
//File: TeddyBear.cs
//Date: 2/6/2019
//This is the class that uses the interface Toybear and declares what Hug() does
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearProgramPL
{
    class TeddyBear : ToyBear
    {
        void ToyBear.Hug()
        {
            string brief = "Here is a hug";
            Console.WriteLine(brief);
        }
    }
}
