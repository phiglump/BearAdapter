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
