using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_L
{
    public class Square : Rectangle
    {
        // Här ändrar vi beteendet av Width & Height
        // jämnfört mot bas klassen Rectangle!
        // De går de inte att byta ut mot varann längre!
        public override int Width
        {
            set { base.Width = base.Height = value; }
        }

        public override int Height
        {
            set { base.Width = base.Height = value; }
        }
    }
}
