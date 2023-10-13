using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_GOOD
{
    public class Square : IForm
    {
        public int Side { get; set; }

        public int Area()
        {
            return Side * Side;
        }
    }
}
