using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DgestionUsuario : conexion
    {
        public string registrarusua(string cedula, string registrado, string nombre, string direcc, string tel, string tel2, string cel, string nestudio, string pensiones, string email, string lic, string clave, string cargo,string eps2,string nom_usua)
        {
            SqlDataAdapter epese = new SqlDataAdapter("ConsultarCodigoEps", entradatos());
            epese.SelectCommand.CommandType = CommandType.StoredProcedure;
            epese.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = eps2;
            DataTable tabla = new DataTable();
            epese.Fill(tabla);
            eps2 = tabla.Rows[0][0].ToString();
            
            SqlDataAdapter pensiond = new SqlDataAdapter("ConsultarCodigoPensiones", entradatos());
            pensiond.SelectCommand.CommandType = CommandType.StoredProcedure;
            pensiond.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = pensiones;
            DataTable tabla1 = new DataTable();
            pensiond.Fill(tabla1);
            pensiones = tabla1.Rows[0][0].ToString();

            SqlDataAdapter nestudios = new SqlDataAdapter("ConsultarCodigoNestudio", entradatos());
            nestudios.SelectCommand.CommandType = CommandType.StoredProcedure;
            nestudios.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nestudio;
            DataTable tabla2 = new DataTable();
            nestudios.Fill(tabla2);
            nestudio = tabla2.Rows[0][0].ToString();



                SqlCommand registrar = new SqlCommand("NuevoUsuario", entradatos());
                registrar.CommandType = CommandType.StoredProcedure;
                registrar.Connection.Open();
                registrar.Parameters.Add("@cedula", SqlDbType.BigInt).Value = cedula;
                registrar.Parameters.Add("@registrado_por", SqlDbType.BigInt).Value = registrado;
                registrar.Parameters.Add("@nombre_completo", SqlDbType.VarChar, 50).Value = nombre;
                registrar.Parameters.Add("@Direccion", SqlDbType.VarChar, 50).Value = direcc;
                registrar.Parameters.Add("@telefono", SqlDbType.Int).Value = tel;
                registrar.Parameters.Add("@Telefono2", SqlDbType.Int).Value = tel2;
                registrar.Parameters.Add("@celular", SqlDbType.BigInt).Value = cel;
                registrar.Parameters.Add("@eps", SqlDbType.TinyInt).Value = eps2;
                registrar.Parameters.Add("@ndeestudio", SqlDbType.VarChar, 1).Value = nestudio;
                registrar.Parameters.Add("@fondo_pensiones", SqlDbType.TinyInt).Value = pensiones;
                registrar.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = email;
                registrar.Parameters.Add("@licdecon", SqlDbType.BigInt).Value = lic;
                registrar.Parameters.Add("@Nombre_usuario", SqlDbType.VarChar, 50).Value = nom_usua ;
                registrar.Parameters.Add("@clave", SqlDbType.VarChar, 20).Value = clave;
                registrar.Parameters.Add("@cargo", SqlDbType.VarChar, 4).Value = cargo;
           

                registrar.ExecuteNonQuery();

                return "1";
            
        }

        public string registrado_por(string a)
        {
            SqlDataAdapter reg_por = new SqlDataAdapter("registrado_por", entradatos());
            reg_por.SelectCommand.CommandType = CommandType.StoredProcedure;
            reg_por.SelectCommand.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = a;
            DataTable tabla = new DataTable();
            reg_por.Fill(tabla);
            string ced = tabla.Rows[0][0].ToString();
            return ced;
        }
        public DataTable cgeneral() {
            SqlDataAdapter cgene = new SqlDataAdapter("ConsultaGeneralUsuario", entradatos());
            cgene.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            cgene.Fill(tabla);
            return tabla;
        }
        public DataTable cespecifico(string nombre)
        {
            SqlDataAdapter cespeci = new SqlDataAdapter("ConsultaEspecificaNombre", entradatos());
            cespeci.SelectCommand.CommandType = CommandType.StoredProcedure;
            cespeci.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
            DataTable tabla = new DataTable();
            cespeci.Fill(tabla);
            return tabla;
        }
        public DataTable cespecificoc(string cedula) {
            SqlDataAdapter cespecic = new SqlDataAdapter("ConsultaEspecificaCedula", entradatos());
            cespecic.SelectCommand.CommandType = CommandType.StoredProcedure;
            cespecic.SelectCommand.Parameters.Add("@cedula", SqlDbType.BigInt).Value = cedula;
            DataTable tabla = new DataTable();
            cespecic.Fill(tabla);
            return tabla;
        }
        public DataTable cespecificocargo(string cargof) {
            SqlDataAdapter cespecic = new SqlDataAdapter("ConsultaEspecificaCargo", entradatos());
            cespecic.SelectCommand.CommandType = CommandType.StoredProcedure;
            cespecic.SelectCommand.Parameters.Add("@cargo", SqlDbType.VarChar,11).Value = cargof;
            DataTable tabla = new DataTable();
            cespecic.Fill(tabla);
            return tabla;
        }
        public string actuusua(string c, string ne, string de, string t1e, string t2e, string cele, string epe, string nese, string fpense, string emaile, string liscone, string nusue, string cargoe,string estado)
        {

            SqlDataAdapter epese = new SqlDataAdapter("ConsultarCodigoEps", entradatos());
            epese.SelectCommand.CommandType = CommandType.StoredProcedure;
            epese.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = epe;
            DataTable tabla = new DataTable();
            epese.Fill(tabla);
            epe = tabla.Rows[0][0].ToString();

            SqlDataAdapter pensiond = new SqlDataAdapter("ConsultarCodigoPensiones", entradatos());
            pensiond.SelectCommand.CommandType = CommandType.StoredProcedure;
            pensiond.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = fpense;
            DataTable tabla1 = new DataTable();
            pensiond.Fill(tabla1);
            fpense = tabla1.Rows[0][0].ToString();

            SqlDataAdapter nestudios = new SqlDataAdapter("ConsultarCodigoNestudio", entradatos());
            nestudios.SelectCommand.CommandType = CommandType.StoredProcedure;
            nestudios.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nese;
            DataTable tabla2 = new DataTable();
            nestudios.Fill(tabla2);
            nese = tabla2.Rows[0][0].ToString();


            //try
            //{ 

            SqlCommand actualizar = new SqlCommand("ActualizarUsuario", entradatos());
            actualizar.CommandType = CommandType.StoredProcedure;
            actualizar.Connection.Open();
            actualizar.Parameters.Add("@cedula", SqlDbType.BigInt).Value = c;
            actualizar.Parameters.Add("@nombre_completo", SqlDbType.VarChar, 50).Value = ne;
            actualizar.Parameters.Add("@Direccion", SqlDbType.VarChar, 50).Value = de;
            actualizar.Parameters.Add("@telefono", SqlDbType.Int).Value = t1e;
            actualizar.Parameters.Add("@telefono2", SqlDbType.Int).Value = t2e;
            actualizar.Parameters.Add("@celular", SqlDbType.BigInt).Value = cele;
            actualizar.Parameters.Add("@eps", SqlDbType.TinyInt).Value = epe;
            actualizar.Parameters.Add("@ndeestudio", SqlDbType.VarChar, 1).Value = nese;
            actualizar.Parameters.Add("@fondo_pensiones", SqlDbType.TinyInt).Value = fpense;
            actualizar.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = emaile;
            actualizar.Parameters.Add("@licdecon", SqlDbType.BigInt).Value = liscone;
            actualizar.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = nusue;
            actualizar.Parameters.Add("@cargo", SqlDbType.Char, 4).Value = cargoe;
            actualizar.Parameters.Add("@estado", SqlDbType.Char, 1).Value = estado;
            actualizar.ExecuteNonQuery();

            return "1";
        }
        //catch
        //{
        //    return "2";


        public string icancti(string cedulaincati)
        {
            SqlCommand actualizar = new SqlCommand("InactivarUsuario", entradatos());
            actualizar.CommandType = CommandType.StoredProcedure;
            actualizar.Connection.Open();
            actualizar.Parameters.Add("@cedula", SqlDbType.BigInt).Value =cedulaincati;
            actualizar.ExecuteNonQuery();

            return "1";

        }
        public string regeps(string eps)
        {
            SqlCommand epse = new SqlCommand("InsertarNuevaEPS", entradatos());
            epse.CommandType = CommandType.StoredProcedure;
            epse.Connection.Open();
            epse.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = eps;
            epse.ExecuteNonQuery();
            return "1";
        }
        public DataTable ceps1()
        {
            SqlDataAdapter cespecic = new SqlDataAdapter("ConsultaEPS ", entradatos());
            cespecic.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            cespecic.Fill(tabla);
            return tabla;
        }
        public string rpension(string pension)
        {
            SqlCommand epse = new SqlCommand("InsertarNuevofondo", entradatos());
            epse.CommandType = CommandType.StoredProcedure;
            epse.Connection.Open();
            epse.Parameters.Add("@Fondo", SqlDbType.VarChar, 50).Value = pension;
            epse.ExecuteNonQuery();
            return "1";
        }
        public DataTable cpension()
        {
            SqlDataAdapter cespecic = new SqlDataAdapter("ConsultaPensiones", entradatos());
            cespecic.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            cespecic.Fill(tabla);
            return tabla;
        }
        public string restudio1(string nestudio1)
        {
            SqlCommand epse = new SqlCommand("InsertarNuevoNivel", entradatos());
            epse.CommandType = CommandType.StoredProcedure;
            epse.Connection.Open();
            epse.Parameters.Add("@Nivel", SqlDbType.VarChar, 50).Value = nestudio1;
            epse.ExecuteNonQuery();
            return "1";
        }
        public DataTable cestudio1()
        {
            SqlDataAdapter cespecic = new SqlDataAdapter("ConsultaNivel", entradatos());
            cespecic.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            cespecic.Fill(tabla);
            return tabla;
        }
    }
}


        
    

