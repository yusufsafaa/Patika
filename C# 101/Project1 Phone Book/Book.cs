using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_Phone_Book
{
    class Book
    {
        public static List<People> personList = new List<People>();
        
        
        public Book()
        {
            People person1 = new People { Name = "Ahmet",    Surname = "Kurt",   Phone = "05445385666" };
            People person2 = new People { Name = "Abdullah", Surname = "Uzun",   Phone = "05423443040" };
            People person3 = new People { Name = "Furkan",   Surname = "Kibar",  Phone = "05403992050" };
            People person4 = new People { Name = "Berat",    Surname = "Çevik",  Phone = "05439896030" };
            People person5 = new People { Name = "Ali",      Surname = "Yılmaz", Phone = "05395556070" };

            personList.Add(person1);
            personList.Add(person2);
            personList.Add(person3);
            personList.Add(person4);
            personList.Add(person5);
        }


        
    }
}
