using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Abstract_Classes
{
    class Mercedes : ICar
    {
        public int HowManyWheels()
        {
            return 4;
        }

        public string WhichBrand()
        {
            return "Mercedes";
        }

        public string WhichColour()
        {
            return "Gray";
        }
    }

    class NewMercedes : Car
    {
        public override string WhichBrand()
        {
            return "Mercedes";
        }
    }
}
