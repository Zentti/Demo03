using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle auto1 = new Vehicle();
            auto1.CarName("Honda");
            auto1.CarSpeed(100);
            auto1.CarTyres(4);
            auto1.PrintData();
            Console.WriteLine();

            auto1.ToString();
            Console.WriteLine();

            Vehicle auto2 = new Vehicle();
            auto2.CarName("Ferrari");
            auto2.CarSpeed(300);
            auto2.CarTyres(4);
            auto2.PrintData();
            Console.WriteLine();

            auto2.ToString();
        }
    }
}
