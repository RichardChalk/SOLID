using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_D
{
    public class LightBulb
    {
        // Vad händer om jag inte deklararerar LightOn som 'false'?
        public bool LightOn { get; set; } = false;
        public void TurnOn()
        {
            Console.WriteLine("Ljuset är på.");
            LightOn= true;
        }

        public void TurnOff()
        {
            Console.WriteLine("Ljuset är av.");
            LightOn= false;
        }
    }

}
