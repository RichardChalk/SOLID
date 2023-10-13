using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_BAD
{
    // En klass ska ha endast ha en uppgift eller ansvar.

    // Denna klass har fler än ett ansvar: 
    // 1. OK - den hanterar användardata
    // 2. NOT OK - och skriver ut den

    public class UserHandler
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public void Create(string name, string email)
        {
            Name = name;
            Email = email;
        }

        // Denna borde finnas i sin egen klass!
        public void Display()
        {
            Console.WriteLine($"Namn: {Name}, E-post: {Email}");
        }
    }

}
