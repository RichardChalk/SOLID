using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_GOOD
{
    internal class Triangle : IForm
    {
        public int Base { get; set; }
        public int Height { get; set; }

        public int Area()
        {
            return (int)(0.5 * Base * Height);
        }
    }
}
