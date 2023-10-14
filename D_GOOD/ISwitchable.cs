using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_GOOD
{
    public interface ISwitchable
    {
        public bool LightOn { get; set; }
        void TurnOn();
        void TurnOff();
    }
}
