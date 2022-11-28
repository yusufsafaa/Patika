using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Abstract_Classes
{

    class Volvo : ICar
    {
        public int HowManyWheels()
        {
            return 4;
        }

        public string WhichBrand()
        {
            return "Volvo";
        }

        public string WhichColour()
        {
            return "Gray";
        }
    }

    class NewVolvo : Car
    {
        public override string WhichBrand()
        {
            return "Volvo";
        }
    }
}
