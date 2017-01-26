using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Heater
    {
        // properties
        public bool Power { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }

        // constructors
        public Heater()
        {

        }

        public Heater(bool power)
        {
            Power = power;
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
            Humidity = 0;
        }

        public void SetTemperature(int value)
        {
            Temperature = value;
        }

        public void SetHumidity(int value)
        {
            Humidity = value;
        }

        public void PrintData()
        {
            Console.WriteLine("Heater satus: " + Power);
            Console.WriteLine("Heater temperature: " + Temperature);
            Console.WriteLine("Heater humidity: " + Humidity);
        }
    }
}
