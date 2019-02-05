using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearProgramPL
{
    class BearAdapter : Bear, ToyBear
    {
        public ToyBear bear;

        void ToyBear.Hug()
        {
            bear.maul();
            bear.hibernate();
        }
    }
}
