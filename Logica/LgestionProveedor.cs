using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using System.Data;

namespace Logica
{
    public class LgestionProveedor
    {
        string resu, estado2;
        public string empresareg(string nombreempre, string direccionempre)
        {
            DgestionProveedor empre = new DgestionProveedor();
            return empre.regempre(nombreempre, direccionempre);
        }
        public DataTable cempresa()
        {
            DgestionProveedor empr = new DgestionProveedor();
            return empr.cempr();
        }
        public string regisp(string nombre, string telefono, string cedula, string empresa, string celular, string email, string tel2, string registrado)
        {

            DgestionProveedor regis = new DgestionProveedor();
            return regis.registrarproveedor(nombre, telefono, cedula, empresa, celular, email, tel2, registrado);
        }
        public string d(string usu)
        {
            DgestionProveedor reg_por = new DgestionProveedor();
            return reg_por.registrado_por(usu);
        }
        public DataTable cgeneral()
        {
            DgestionProveedor general = new DgestionProveedor();
            return general.consugeneral();
        }
        public DataTable cespecificon(string cnombre)
        {
            DgestionProveedor especifico = new DgestionProveedor();
            return especifico.cespecifico(cnombre);
        }
        public DataTable cespecificoc(string ccedula)
        {
            DgestionProveedor especificoc = new DgestionProveedor();
            return especificoc.cespecificoc(ccedula);
        }
        public DataTable cespecifices()
        {
            DgestionProveedor especificoc = new DgestionProveedor();
            return especificoc.cespecificesta();
        }
        public string M(string nombre, string identificacion, string telefono, string empresa, string celular, string email, string telefono2, string estado)
        {
            resu = estado;
            estad();
            DgestionProveedor actua = new DgestionProveedor();
            return actua.actuusua(nombre, identificacion, telefono, empresa, celular, email, telefono2, estado2);
        }
        public void estad()
        {
            if (resu == "Activo")
            {
                estado2 = "a";
            }
            else
            {
                estado2 = "i";
            }
        }
        public string elimi(string cedulainac)
        {
            DgestionProveedor inactivar = new DgestionProveedor();
            return inactivar.icancti(cedulainac);
        }
    }
}
