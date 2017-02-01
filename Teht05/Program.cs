using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Student oppilas1 = new Student();
            oppilas1.SetFirstName("Pete");
            oppilas1.SetLastName("Kauppine");
            oppilas1.SetAge(54);
            oppilas1.SetMotivation(5);
            oppilas1.SetSchool("Elämäm kova korkia koulu");

            Student oppilas2 = new Student();
            oppilas2.SetFirstName("Mara");
            oppilas2.SetLastName("Tekijä");
            oppilas2.SetAge(34);
            oppilas2.SetMotivation(8);
            oppilas2.SetSchool("Sähkö ala");

            Student oppilas3 = new Student();
            oppilas3.SetFirstName("Pirkko");
            oppilas3.SetLastName("Kukkahattu");
            oppilas3.SetAge(29);
            oppilas3.SetMotivation(10);
            oppilas3.SetSchool("Mielensäpahoittajakoulu");

            Student oppilas4 = new Student();
            oppilas4.SetFirstName("Jou");
            oppilas4.SetLastName("Mään");
            oppilas4.SetAge(22);
            oppilas4.SetMotivation(1);
            oppilas4.SetSchool("Pintakäsittely amis");

            Student oppilas5 = new Student();
            oppilas5.SetFirstName("Heikki");
            oppilas5.SetLastName("Hienosto");
            oppilas5.SetAge(26);
            oppilas5.SetMotivation(10);
            oppilas5.SetSchool("AMK");

            Student[] taulukko = { oppilas1, oppilas2, oppilas3, oppilas4, oppilas5 };

            foreach (Student dude in taulukko)
            {
                dude.PrintData();
            }


            oppilas1.DrinkBeer();
            oppilas4.Study();

            Console.WriteLine();

            oppilas1.PrintData();
            oppilas4.PrintData();
        }
    }
}
