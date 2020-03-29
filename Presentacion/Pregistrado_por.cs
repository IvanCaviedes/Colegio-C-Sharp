using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presentacion
{
    public class Pregistrado_por
    {
        static string rol;
        public void Perfil(string a)
        {
            rol = a;
        }

        public string Respuesta()
        {
            return rol;
        }
    }
}
