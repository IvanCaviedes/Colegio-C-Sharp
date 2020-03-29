using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using System.Data;

namespace Logica
{
    public class Lgestioncliente
    {
        string resu,estado2;
        public string registrarcliente(string nombre, string identi, string tel1, string direc, string cel, string email, string tel2,string registrado)
        {
            Dgestioncliente registrar = new Dgestioncliente();
            return registrar.insercioncliente(nombre, identi, tel1, direc, cel, email, tel2,registrado);
        }
        public string d(string usu)
        {
            Dgestioncliente reg_por = new Dgestioncliente();
            return reg_por.registrado_por(usu);
        }
        public DataTable cgeneral()
        {
            Dgestioncliente general = new Dgestioncliente();
            return general.consugeneral();
        }
        public DataTable cespecificon(string cnombre)
        {
            Dgestioncliente especifico = new Dgestioncliente();
            return especifico.cespecifico(cnombre);
        }
        public DataTable cespecificoc(string ccedula)
        {
            Dgestioncliente especificoc = new Dgestioncliente();
            return especificoc.cespecificoc(ccedula);
        }
        public string M(string nomcliente, string identificacion,string telefono,string direccion, string celular, string email, string telefono2 , string estado)
        {
            resu = estado;
            estad();
            Dgestioncliente actua = new Dgestioncliente();
            return actua.actuusua( nomcliente, identificacion, telefono,direccion,celular,email,telefono2,estado2);
        }
        public void estad()
        {
            if (resu == "Activo")
            {
                 estado2= "a";
            }
            else
            {
                estado2 = "i";
            }
        }
        public string elimi(string cedulainac)
        {
            Dgestioncliente inactivar = new Dgestioncliente();
            return inactivar.icancti(cedulainac);
        }
    }
}
