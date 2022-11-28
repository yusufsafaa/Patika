using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__Polymorphism__Virtual_and_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Boat boat = new Boat();
            Bicycle bicycle = new Bicycle();

            // Polymorphism
            Vehicle[] vehicles ={car,boat,bicycle };               
            foreach (var vehicle in vehicles)
            {
                vehicle.Go();
            }
;



            Console.ReadLine();
        }
    }

    class Vehicle                         //  If a class be introduced as sealed, it cannot be inherit. 
    {
        public int speed = 25;
        public virtual void Go()
        {
            Console.WriteLine("This vehicle is moving.");
        }
    }

    // Inheritance
    class Car : Vehicle
    {
        public int wheels = 4;
        public override void Go()
        {
            Console.WriteLine("This car is moving.");
        }
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
        public override void Go()
        {
            Console.WriteLine("This boat is floating.");
        }
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
        public override void Go()
        {
            Console.WriteLine("This bicycle is moving.");
        }
    }
}
