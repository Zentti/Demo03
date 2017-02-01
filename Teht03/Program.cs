using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            Televisio telkku1 = new Televisio();
            Console.WriteLine("Telkku1 tiedot: ");
            telkku1.PrintData();
            Console.WriteLine();

            telkku1.PowerOn();
            telkku1.RaiseVol();
            telkku1.ChannelUp();
            Console.WriteLine("Telkku1 tiedot: ");
            telkku1.PrintData();
            Console.WriteLine();

            telkku1.SetVolume(24);
            telkku1.SetChannel(6);
            Console.WriteLine("Telkku1 tiedot: ");
            telkku1.PrintData();
            Console.WriteLine();

            telkku1.PowerOff();
            Console.WriteLine("Telkku1 tiedot: ");
            telkku1.PrintData();
            Console.WriteLine();

            Televisio telkku2 = new Televisio(true, 5, 13);
            Console.WriteLine("Telkku2 tiedot: ");
            telkku2.PrintData();
            Console.WriteLine();

            telkku2.PowerOff();
            Console.WriteLine("Telkku2 tiedot: ");
            telkku1.PrintData();
            Console.WriteLine();
        }
    }
}
