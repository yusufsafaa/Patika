using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__Struct_and_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            // While we can access members that is not static through objects, 
            // we can access static methods and properties through class name without creating object.


            Employee employee1 = new Employee("Ahmet", 512132);
            Employee employee2 = new Employee();
            employee2.Id = 132149;
            employee2.Name = "Salih";

            Console.WriteLine(Employee.EmployeNumber);

            Transactions.Add(51, 32);

            Console.ReadLine();
        }
    }

    class Employee
    {
        private static int employeNumber;

        public static int EmployeNumber
        {
            get { return employeNumber; }  // I removed set because I want to change employeeNumber only from in this class not from out.
        }

        private string name;
        private int id;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        // Static Constructor           
        static Employee()    // It runs only one time when this class is called and runs before everything.
        {
            employeNumber = 0;
        }
        public Employee(string name, int id)
        {
            employeNumber++;
            this.Id = id;
            this.Name = name;
        }

        public Employee()
        {
            employeNumber++;
        }

        public void Write()
        {
            Console.WriteLine("Employe Name:      " + Name);
            Console.WriteLine("Employe Id  :      " + Id);
        }

    }

    // Static Class
    static class Transactions
    {
        public static void Add(int number1,int number2)       // We cannot create an object from static class.
        {                                                     // We cannot define anything that is not static.
            Console.WriteLine(number1+number2);               // We cannot make inheritance in static class.
        }
    }

    // Struct
    struct Example
    {
        // **Stack**
        // Structs are like classes.
        // Structs cannot take inheritance from other classes or structs.
        // Structs can take inheritance from interface.
        // We can create object from structs.
        // Structs consist of methods, properties and fields like class.
        // Structs can include static members.
    }

    // Enum    ---> Enumeration
    class IntroductionEnum
    {
        enum Days
        {
            Monday,             // Index starts with 0
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public void Write()
        {
            Console.WriteLine(Days.Friday);              // print: Friday
            Console.WriteLine((int)Days.Thursday);       // print: 3
        }
    }
}
