using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Student
    {


        // properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Motivation { get; set; }
        public string School { get; set; }

        // constructors

        // methods

        public void PrintData()
        {
            Console.WriteLine("Nimi: " + FirstName + " " + LastName);
            Console.WriteLine("Ikä: " + Age);
            Console.WriteLine("Motivaatio(1-10): " + Motivation);
            Console.WriteLine("Koulu: " + School);
            Console.WriteLine();
        }

        public void DrinkBeer()
        {
            Motivation -= 1;
        }

        public void Study()
        {
            Motivation += 1;
        }
        public void SetFirstName(string value)
        {
            FirstName = value;
        }

        public void SetLastName(string value)
        {
            LastName = value;
        }

        public void SetAge(int value)
        {
            Age = value;
        }

        public void SetMotivation(int value)
        {
            Motivation = value;
        }

        public void SetSchool(string value)
        {
            School = value;
        }
    }
}
