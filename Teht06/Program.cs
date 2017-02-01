using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            Toilet vessa1 = new Toilet();
            vessa1.PrintData();
            vessa1.NewContainer();
            vessa1.SetLoad();
            vessa1.SetRefresher();
            Console.WriteLine();
            vessa1.PrintData();

            vessa1.SetLoad();
         
            Console.WriteLine();
            vessa1.PrintData();
            vessa1.RemoveClog();
            vessa1.NewContainer();
            Console.WriteLine();
            vessa1.PrintData();

            Toilet vessa2 = new Toilet(50, true);
            Console.WriteLine();
            vessa2.PrintData();
            vessa2.SetLoad();
            vessa2.SetLoad();
            vessa2.SetLoad();
            vessa2.SetLoad();
            vessa2.SetLoad();
            vessa2.SetLoad();
            vessa2.SetLoad();
            vessa2.SetLoad();
            vessa2.SetLoad();
            vessa2.SetLoad();
            vessa2.SetLoad();

            Console.WriteLine();
            vessa2.PrintData();

            vessa2.Flush();
            Console.WriteLine();
            vessa2.PrintData();

        }
    }
}
