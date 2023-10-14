using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_D
{
    public class Switch
    {
        // Här är problemet!
        // Denna high level klass - Switch - har en dependency...
        // på low level klass - LightBulb!
        private LightBulb bulb = new LightBulb();

        public void Toggle()
        {
            if (IsOn())
                bulb.TurnOff();
            else
                bulb.TurnOn();
        }

        public bool IsOn()
        {
            // Logik för att kontrollera om ljuset är på
            if (bulb.LightOn)
                return true;
            return false;
        }
    }
}
