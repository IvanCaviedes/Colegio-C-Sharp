using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;

namespace Logica
{
   public class LgestionProducto
    {
        string resu,estudio;
        public DataTable ctipo()
        {
            DgestionProducto tipo = new DgestionProducto();
            return tipo.tipo1();
        }
        public string tiporeg(string tipo)
        {
           DgestionProducto tipor = new DgestionProducto();
            return tipor.regtipo(tipo);
        }
        public DataTable cunidadmedida()
        {
            DgestionProducto unidadme = new DgestionProducto();
            return unidadme.cunidad();
        }
        public string runidad(string unidad)
        {
            DgestionProducto runidadme = new DgestionProducto();
            return runidadme.runidade(unidad);
        }
        public string d(string usu)
        {
            Dgestioncliente reg_por = new Dgestioncliente();
            return reg_por.registrado_por(usu);
        }
        public string regisproducto(string nombre, string tipo,string unidad, decimal contenido,decimal cantidad, string valorunidad ,string imbima,string  registrado,decimal iva,string proveedor)
        {

            DgestionProducto regis = new DgestionProducto();
            return regis.registrarproducto(nombre,tipo,unidad,contenido,cantidad,valorunidad,imbima,registrado,iva,proveedor);
        }
        public DataTable cempresa()
        {
            DgestionProducto empr = new DgestionProducto();
            return empr.cempr();
        }
        public DataTable cproveedor(string em)
        {
            DgestionProducto proveempr = new DgestionProducto();
            return proveempr.cproempr(em);
        }
        public DataTable cgeneral()
        {
            DgestionProducto general = new DgestionProducto();
            return general.consugeneral();
        }
        public DataTable cespecificon(string cnombre)
        {
            DgestionProducto especifico = new DgestionProducto();
            return especifico.cespecifico(cnombre);
        }
        public DataTable cespecificoc(string codigo)
        {
            DgestionProducto especificoc = new DgestionProducto();
            return especificoc.cespecificoc(codigo);
        }
        public DataTable cestado()
        {
            DgestionProducto general = new DgestionProducto();
            return general.consuestado();
        }
        public string actuproducto(string nombre, string valorunidad, decimal iva,string cod,string estadoe,decimal cantidad)
        {
            resu = estadoe;
            DgestionProducto regis = new DgestionProducto();
            estad();
            return regis.Actuproducto(nombre,valorunidad,iva,cod,estudio,cantidad);
        }
        public void estad()
        {
            if (resu == "Activo")
            {
                estudio = "a";
            }
            else
            {
                estudio = "i";
            }
        }
        public string elimi(string cedulainac)
        {
            DgestionProducto inactivar = new DgestionProducto();
            return inactivar.icancti(cedulainac);
        }
        public string registrofecha(string b,DateTime a)
        {
            DgestionProducto Instancia = new DgestionProducto();
            return Instancia.registrofechav(b,a);
        }
        public string codpro(string nombre)
        {
            DgestionProducto produx = new DgestionProducto();
            return produx.codproducto(nombre);
        }
    }
}
