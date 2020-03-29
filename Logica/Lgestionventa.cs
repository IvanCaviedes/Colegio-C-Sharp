using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using System.Data;

namespace Logica
{
   public class Lgestionventa
    {
        public string LConsultarCliente(string a)
        {
            Dgestionventa Instancia = new Dgestionventa();
            return Instancia.DConsultarCliente(a);
        }
        public DataTable Lconsultatipo()
        {
            Dgestionventa Instancia = new Dgestionventa();
            return Instancia.DConsultatipo();
        }
        public DataTable LconsultaProducto(string a)
        {
            Dgestionventa Instancia = new Dgestionventa();
            return Instancia.DConsultaProducto(a);
        }
        public DataTable LDatosProducto(string a)
        {
            Dgestionventa Instancia = new Dgestionventa();
            return Instancia.DDatosProducto(a);
        }
        public string ValorTotal(string a, string b)
        {
            Int64 total = Convert.ToInt32(a) * Convert.ToInt32(b);
            return total.ToString();
        }

        public string ValorIVA(string a, string b, string c)
        {
            Int64 total = (Convert.ToInt64(a) * Convert.ToInt64(b) * Convert.ToInt64(c)) / 100;
            return total.ToString();
        }
        public string codfactura()
        {
            Dgestionventa fatura = new Dgestionventa();
            return fatura.codfactura1();
        }
        public string nfactura(string a, string b,string c , string d ,string e,string f ,string g)
        {
            Dgestionventa ase = new Dgestionventa();
            return ase.regfactura(a, b, c, d, e, f, g);
        }
        public string detallesv(string a, string b, string c, string d, string e)
        {
            Dgestionventa ase = new Dgestionventa();
            return ase.facventa(a, b, c, d, e );
        }
        public DataTable cespecificacod(string a)
        {
            Dgestionventa ase = new Dgestionventa();
            return ase.consultacod(a);
        }
        public DataTable especificofecha(DateTime a)
        {
            Dgestionventa ase = new Dgestionventa();
            return ase.consultafecha(a);
        }
    }
}
