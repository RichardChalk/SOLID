using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_GOOD
{
    public class LightBulb : ISwitchable
    {
        // Vad händer om jag inte deklararerar LightOn som 'false'?
        public bool LightOn { get; set; } = false;
        public void TurnOn()
        {
            Console.WriteLine("Lampan är på.");
            LightOn = true;
        }

        public void TurnOff()
        {
            Console.WriteLine("Lampan är av.");
            LightOn = false;
        }
    }
}
