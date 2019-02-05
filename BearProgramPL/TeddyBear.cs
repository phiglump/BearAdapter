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
