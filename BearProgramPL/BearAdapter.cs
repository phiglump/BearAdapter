using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearProgramPL
{
    class BearAdapter : ToyBear
    {
        Bear bear;
        public BearAdapter (Bear b)
        {
            this.bear = b;
        }

        public void Hug()
        {
            this.bear.maul();
        }
    }
}
