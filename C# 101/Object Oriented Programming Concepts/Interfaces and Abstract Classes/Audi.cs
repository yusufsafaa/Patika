using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Abstract_Classes
{
    class Audi : ICar
    {
        public int HowManyWheels()
        {
            return 4;
        }

        public string WhichBrand()
        {
            return "Audi";
        }

        public string WhichColour()
        {
            return "Black";
        }
    }

    class NewAudi : Car
    {
        public override string WhichBrand()
        {
            return "Audi";
        }

        public override string WhichColour()
        {
            return "Black";
        }
    }
}
