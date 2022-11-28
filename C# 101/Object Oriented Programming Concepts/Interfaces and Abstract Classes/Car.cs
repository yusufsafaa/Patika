using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Abstract_Classes
{
    public abstract class Car
    {
        public int HowManyWheels()
        {
            return 4;
        }

        public virtual string WhichColour()
        {
            return "Gray";
        }
        public abstract string WhichBrand();
    }
}
