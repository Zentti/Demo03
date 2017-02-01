using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Vehicle
    {

        // properties
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        //methods

        public void PrintData()
        {
            Console.WriteLine("Nimi: " + Name);
            Console.WriteLine("Nopeus: " + Speed);
            Console.WriteLine("Renkaat: " + Tyres);
        }


        public void ToString()
        {
            string jono = "Nimi: " + Name + ", Nopeus: " + Speed + ", Renkaiden määrä: " + Tyres;
            Console.WriteLine(jono);
        }

        public void CarName(string value)
        {
            Name = value;
        }

        public void CarSpeed(int value)
        {
            Speed = value;
        }

        public void CarTyres(int value)
        {
            Tyres = value;
        }
    }
}
