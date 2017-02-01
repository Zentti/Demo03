using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Toilet
    {
        // properties
        public int Capacity { get; set; }
        public int Load { get; set; }
        public bool Refresher { get; set; }
        public bool Clogged { get; set; }

        // constructor
        public Toilet()
        {

        } 

        public Toilet(int capacity)
        {
            Capacity = capacity;
        }

        public Toilet(int capacity, bool refresher)
        {
            Capacity = capacity;
            Refresher = refresher;
        }

        // methods

        public void Flush()
        {
            Load = 0;
        }

        public void NewContainer()
        {
            Capacity += 5;
        }

        public void SetRefresher()
        {
            Refresher = true;
        }

        public void SetLoad()
        {
            Load += 3;
            if (Load > Capacity)
            {
                Clogged = true;
            }
        }

        public void RemoveClog()
        {
            Clogged = false;
            Load = 0;
        }

        public void PrintData()
        {
            Console.WriteLine("Kapasiteetti: " + Capacity);
            Console.WriteLine("Täyttöaste: " + Load);
            Console.WriteLine("Raikastin: " + Refresher);
            Console.WriteLine("Tukossa? " + Clogged);
        }
        
    }
}
