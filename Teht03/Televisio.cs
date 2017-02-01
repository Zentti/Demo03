using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Televisio
    {
        // properties
        public int Channel { get; set; }
        public int Volume { get; set; }
        public bool Status { get; set; }


        // constructors
        public Televisio()
        {

        }

        public Televisio(bool status, int channel, int volume)
        {
            Status = status;
            Channel = channel;
            Volume = volume;
        }

        // methods

        public void PowerOn()
        {
            Status = true;
        }

        public void PowerOff()
        {
            Status = false;
            Channel = 0;
            Volume = 0;
        }

        public void RaiseVol()
        {
            Volume += 1;
        }

        public void LoverVol()
        {
            Volume -= 1;
        }

        public void SetVolume(int value)
        {
            Volume = value;
        }

        public void ChannelUp()
        {
            Channel += 1;
        }

        public void ChannelDown()
        {
            Channel -= 1;
        }

        public void SetChannel(int value)
        {
            Channel = value;
        }


        public void PrintData()
        {
            Console.WriteLine("Virta: " + Status);
            Console.WriteLine("Kanava: " + Channel);
            Console.WriteLine("Äänenvoimakkuus: " + Volume);
        }
    }
}
