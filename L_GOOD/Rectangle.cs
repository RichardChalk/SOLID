using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_GOOD
{
    public class Rectangle : IForm
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int Area()
        {
            return Width * Height;
        }
    }

}
