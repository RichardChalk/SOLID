using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_I
{
    public class Worker : IWorker
    {
        public void Work()
        {
            // Implementera arbetslogik här
            Console.WriteLine("Jag jobbar på!");
        }

        public void Eat()
        {
            // Implementera ätlogik här
        }
    }


}
