//Author: Philippe Lumpkin
//File: BearAdapter.cs
//Date: 2/6/2019
//This is the file that is the adapter to adapt the toybear into a bear
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearProgramPL
{
    class BearAdapter : ToyBear
    {
        // here this.bear is set to the b which in this case is equal to the Grizzly information
        Bear bear;
        public BearAdapter (Bear b)
        {
            this.bear = b;
        }
        //Hug is called and uses the grizzly information or this.bear to call the maul function.
        public void Hug()
        {
            this.bear.maul();
        }
    }
}
