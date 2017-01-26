using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            Washingmachine machine = new Washingmachine();
            machine.PrintData();
            Console.WriteLine();
            machine.SwitchOn();
            machine.Temperature = 50;
            machine.Duration = 60;
            machine.Speed = 900;
            machine.PrintData();
            Console.WriteLine();
            machine.SwitchOff();
            machine.PrintData();
            Console.WriteLine();

            Washingmachine machine2 = new Washingmachine(40, 600, 55);
            machine2.PrintData();
            Console.WriteLine();
            machine2.Temperature = 60;
            machine2.PrintData();
            Console.WriteLine();
        }
    }
}
