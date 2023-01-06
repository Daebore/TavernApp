using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taverna
{
    internal class Usuario
    {
        String nombre;
        String password;

        public Usuario(string nombre, string password)
        {
            this.nombre = nombre;
            this.password = password;
        }
    }


}
