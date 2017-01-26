using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Washingmachine
    {
        // properties
        public bool Power { get; set; }
        public int Temperature { get; set; }
        public int Speed { get; set; }
        public int Duration { get; set; }

        // constructors
        public Washingmachine()
        {

        }

        public Washingmachine(int temperature, int speed, int duration)
        {
            Temperature = temperature;
            Speed = speed;
            Duration = duration;
        }

        // methods
        public void SwitchOn()
        {
            Power = true;
        }

        public void SwitchOff()
        {
            Power = false;
            Temperature = 0;
            Speed = 0;
            Duration = 0;       
        }

        public void SetTemperature(int value)
        {
            Temperature = value;
        }

        public void SetDuration(int value)
        {
            Duration = value;
        }

        public void SetSpeed(int value)
        {
            Speed = value;
        }
        public void PrintData()
        {
            Console.WriteLine("Washer satus: " + Power);
            Console.WriteLine("Washer temperature: " + Temperature);
            Console.WriteLine("Washer speed: " + Speed);
            Console.WriteLine("Washer duration: " + Duration + " minutes ");
        }
    }
}
