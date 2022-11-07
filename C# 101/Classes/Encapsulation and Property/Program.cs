using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_and_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "Yusuf Safa";
            student1.Surname = "Köksal";
            student1.Department = "Computer Engineering";
            student1.Grade =1;
            student1.Reduce();
            student1.Write();

            Console.WriteLine("--------------------");

            Student student2 = new Student("Ahmet Said", "Acer", "Civil Engineering", 4);
            student2.Boost();
            student2.Write();

            Console.ReadLine();
        }


    }

    class Student
    {
        // Field
        private string name;
        private string surname;
        private string department;
        private int grade;

        // Property
        public string Name
        {
            get { return name; }    // read
            set { name = value; }   
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value.ToUpper(); }
        }
        public string Department
        {
            get { return department; }
            set { department = "YTU "+value; }
        }
        public int Grade
        {
            get { return grade; }
            set {
                if (value<1)
                {
                    Console.WriteLine("Grade cannot be lower than 1 !!");
                }

                else if (value>4)
                {
                    Console.WriteLine("Grade cannot be more than 4 !!");
                }

                else
                {
                    grade = value;
                }
                }
        }

        public Student(string name, string surname, string department, int grade)
        {
            Name = name;
            Surname = surname;
            Department = department;
            Grade = grade;
        }
        public Student()
        {

        }

        public void Write()
        {
            Console.WriteLine("Student Name:        " + Name);
            Console.WriteLine("Student Surname:     " + Surname);
            Console.WriteLine("Student Department:  " + Department);
            Console.WriteLine("Student Grade:       " + Grade);
        }

        public void Reduce()
        {
            this.Grade = this.Grade - 1;
        }
        public void Boost()
        {
            this.Grade = this.Grade + 1;
        }

    }
}
