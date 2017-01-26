using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            //create one instance of heater class
            //testing..
            Heater heater = new Heater();
            heater.PrintData();
            heater.Power = true;
            Console.WriteLine();
            heater.Temperature = 100;
            heater.Humidity = 30;
            heater.PrintData();
            Console.WriteLine();
            Heater heater2 = new Heater(true);
            heater2.PrintData();
            Console.WriteLine();
            heater2.Temperature = 75.5;
            heater2.Humidity = 32;
            heater2.PrintData();
            Console.WriteLine();
            heater2.SwitchOff();
            heater2.PrintData();
            Console.WriteLine();
            heater2.SwitchOn();
            heater2.PrintData();
            heater2.Temperature = 200;
            Console.WriteLine();
            heater2.PrintData();
        }
    }
}
