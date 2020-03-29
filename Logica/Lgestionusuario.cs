using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using System.Data;

namespace Logica
{
    public class Lgestionusuario
    {
        string estudio, resu, lic, s, c2, m, cargo1, valor;
        public string a(string cargo, string nombre, string cedula, string telefono, string direccion, string celular, string nestudio, string pensiones, string email, string licencia, string telefono2, string registrado,string eps,string nusu)
        {
            lic = licencia;
            c2 = cedula;
            cargo1 = cargo;
            licen();
            clave();
            cargof();
            DgestionUsuario regis = new DgestionUsuario();
            return regis.registrarusua(cedula, registrado, nombre, direccion, telefono, telefono2, celular, nestudio, pensiones, email, s, m, valor,eps,nusu);
        }
        public string d(string usu)
        {
            DgestionUsuario reg_por = new DgestionUsuario();
            return reg_por.registrado_por(usu);
        }

        public void licen()
        {
            if (lic == "Si")
            {
                s = c2;
            }
            else
            {
                s = "0";
            }
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

        public void clave()
        {
            StringBuilder SB = new StringBuilder();
            Random R = new Random();
            string digitos = "abcdfghijklmnopqrstuvwxyzABCDEFGFHIJKLMNOPQRSTUVWXYZ1234567890";
            for (int cont = 0; cont < 7; cont++)
            {
                SB.Append(digitos[R.Next(digitos.Length)]);
                m = Convert.ToString(SB);
            }
        }
        public void cargof()
        {
            if (cargo1 == "Administrador")
            {
                valor = "admi";
            }
            else if (cargo1 == "Cajero")
            {
                valor = "caje";
            }
            else
            {
                valor = "domi";
            }
        }
        public DataTable cgeneral()
        {
            DgestionUsuario general = new DgestionUsuario();
            return general.cgeneral();
        }
        public DataTable cespecificon(string cnombre)
        {
            DgestionUsuario especifico = new DgestionUsuario();
            return especifico.cespecifico(cnombre);
        }
        public DataTable cespecificoc(string ccedula)
        {
            DgestionUsuario especificoc = new DgestionUsuario();
            return especificoc.cespecificoc(ccedula);
        }
        public DataTable cespecificocargo(string cargoh)
        {
            DgestionUsuario especificocargo = new DgestionUsuario();
            return especificocargo.cespecificocargo(cargoh);
        }
        public string M(string c, string ne, string de, string t1e, string t2e, string cele, string epe, string nese, string fpense, string emaile, string liscone, string nusue, string cargoe, string estado)
        {
            c2 = c;
            lic = liscone;
            resu = estado;
            cargo1 = cargoe;
            licen();
            cargof();
            estad();
            DgestionUsuario actua = new DgestionUsuario();
            return actua.actuusua(c, ne, de, t1e, t2e, cele, epe, nese, fpense, emaile, s, nusue, valor, estudio);
        }
        public string elimi(string cedulainac)
        {
            DgestionUsuario inactivar = new DgestionUsuario();
            return inactivar.icancti(cedulainac);
        }
        public DataTable ceps()
        {
            DgestionUsuario epsz = new DgestionUsuario();
            return epsz.ceps1();
        }
        public string epsreg(string eps)
        {
            DgestionUsuario epsq = new DgestionUsuario();
            return epsq.regeps(eps);
        }
        public DataTable cpensiones()
        {
            DgestionUsuario pensio = new DgestionUsuario();
            return pensio.cpension();
        }
        public string rpensiones(string pensione)
        {
            DgestionUsuario rpension = new DgestionUsuario();
            return rpension.rpension(pensione);
        }
        public DataTable cnestudio()
        {
            DgestionUsuario cnestudi = new DgestionUsuario();
            return cnestudi.cestudio1();
        }
        public string rnestudio(string estdio1)
        {
            DgestionUsuario restudio = new DgestionUsuario();
            return restudio.restudio1(estdio1);
        }
    }
}
