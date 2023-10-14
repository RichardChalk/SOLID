using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_I
{
    public class Unemployed : IWorker
    {
        public void Work()
        {
            // Jag har inget jobb!
            // Vad gör jag med denna metod?
            Console.WriteLine("Jag är ARBETSLÖS!");
            Console.WriteLine("Jag behöver inte denna Work() metod!!");
        }

        public void Eat()
        {
            // Implementera ätlogik här
        }

    }
}
