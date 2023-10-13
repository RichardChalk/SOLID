using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_GOOD
{
    // En klass ska ha endast ha en uppgift eller ansvar.

    // Denna klass har endast ett ansvar: 
    // 1. OK - den hanterar användardata

    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public void Create(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }

}
