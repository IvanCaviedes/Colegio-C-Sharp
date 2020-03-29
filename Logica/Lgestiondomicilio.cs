using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;

namespace Logica
{
     public class Lgestiondomicilio
    {
        public DataTable ndomiciliario()
        {
            Dgestiondomicilios nue = new Dgestiondomicilios();
            return nue.nombredomic();
        }
        public string dircliente(string a)
        {
            Dgestiondomicilios Instancia = new Dgestiondomicilios();
            return Instancia.dconsultadireccion(a);
        }
    }
}
