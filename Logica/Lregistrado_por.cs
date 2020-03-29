using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;

namespace Logica
{
    public class Lregistrado_por
    {
        public string LRegistradoPor(string NombreUsuario)
        {
           Dregistrado_por instancia = new Dregistrado_por();
            return instancia.DRegistradoPor(NombreUsuario);
        }
    }
}
