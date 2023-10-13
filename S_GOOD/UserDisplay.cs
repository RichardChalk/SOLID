using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace S_GOOD
{
    // En klass ska ha endast ha en uppgift eller ansvar.

    // Denna klass har endast ett ansvar: 
    // 1. OK - den skriver ut användardata

    public class UserDisplay
    {
        public static void Display(User user)
        {
            Console.WriteLine($"Namn: {user.Name}, E-post: {user.Email}");
        }
    }

}
