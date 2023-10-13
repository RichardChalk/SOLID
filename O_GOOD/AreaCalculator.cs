using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_GOOD
{
    public class AreaCalculator
    {
        public double CalculateArea(IShape shape)
        {
            return Math.Round(shape.CalculateArea(),2);
        }
    }
}
