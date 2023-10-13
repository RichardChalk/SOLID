using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_BAD
{
    public class AreaCalculator
    {
        public double CalculateArea(object shape)
        {
            if (shape is Rectangle rectangle)
            {
                return rectangle.Width * rectangle.Height;
            }
            else if (shape is Circle circle)
            {
                return Math.PI * Math.Pow(circle.Radius, 2);
            }
            // Varje gång vi vill lägga till en ny form...
            // Måste denna kod ändras!
            throw new InvalidOperationException("Ogiltig form");
        }
    }
}
