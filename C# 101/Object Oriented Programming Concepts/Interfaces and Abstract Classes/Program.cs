using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Abstract_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interfaces
            Volvo volvo = new Volvo();
            Mercedes mercedes = new Mercedes();
            Audi audi = new Audi();

            Console.WriteLine("Car: " + volvo.WhichBrand());
            Console.WriteLine("Wheel Numbers: " + volvo.HowManyWheels());
            Console.WriteLine("Colour: " + volvo.WhichColour());
            Console.WriteLine("----------------------");



            // Abstract Class
            NewAudi newAudi = new NewAudi();
            NewMercedes newMercedes = new NewMercedes();
            NewVolvo newVolvo = new NewVolvo();

            List<Car> newcars = new List<Car>() { newAudi, newMercedes, newVolvo };
            foreach (Car car in newcars)
            {
                Console.WriteLine("Car: " + car.WhichBrand());
                Console.WriteLine("Wheel Numbers: " + car.HowManyWheels());
                Console.WriteLine("Colour: " + car.WhichColour());
                Console.WriteLine("----------------------");
            }

            Console.ReadLine();
        }
    }
}


