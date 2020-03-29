using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class DgestionProveedor:conexion
    {
        public string regempre(string nombreemp,string direccionempr)
        {
            SqlCommand empre = new SqlCommand("InsertarNuevaEmpresa", entradatos());
            empre.CommandType = CommandType.StoredProcedure;
            empre.Connection.Open();
            empre.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = nombreemp;
            empre.Parameters.Add("@Direccion", SqlDbType.VarChar, 50).Value = direccionempr;
            empre.ExecuteNonQuery();
            return "1";
        }
        public DataTable cempr()
        {
            SqlDataAdapter cespecic = new SqlDataAdapter("ConsultaEmpresa", entradatos());
            cespecic.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            cespecic.Fill(tabla);
            return tabla;
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
        public string registrarproveedor(string nombre, string telefono, string cedula, string empresa, string celular, string email, string tel2, string registrado)
        {
            //try
            //{
            SqlDataAdapter empresa1 = new SqlDataAdapter("ConsultarCodigoEmpresa", entradatos());
            empresa1.SelectCommand.CommandType = CommandType.StoredProcedure;
            empresa1.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = empresa;
            DataTable tabla1 = new DataTable();
            empresa1.Fill(tabla1);
            empresa = tabla1.Rows[0][0].ToString();

            SqlCommand registrar = new SqlCommand("NuevoProveedor", entradatos());
            registrar.CommandType = CommandType.StoredProcedure;
            registrar.Connection.Open();
            registrar.Parameters.Add("@Cedula", SqlDbType.BigInt).Value = cedula;
            registrar.Parameters.Add("@registrado_por", SqlDbType.BigInt).Value = registrado;
            registrar.Parameters.Add("@empresa", SqlDbType.VarChar, 50).Value =empresa;
            registrar.Parameters.Add("@Telefono", SqlDbType.Int).Value =telefono;
            registrar.Parameters.Add("@Telefono2", SqlDbType.Int).Value = tel2;
            registrar.Parameters.Add("@Celular", SqlDbType.BigInt).Value = celular;
            registrar.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;
            registrar.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
            registrar.ExecuteNonQuery();

            return "1";
        }
        public DataTable consugeneral()
        {
            SqlDataAdapter cgene = new SqlDataAdapter("ConsultaGeneralProveedor", entradatos());
            cgene.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            cgene.Fill(tabla);
            return tabla;
        }
        public DataTable cespecifico(string nombre)
        {
            SqlDataAdapter cespeci = new SqlDataAdapter("consultaEspecificaNombreProveedor", entradatos());
            cespeci.SelectCommand.CommandType = CommandType.StoredProcedure;
            cespeci.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
            DataTable tabla = new DataTable();
            cespeci.Fill(tabla);
            return tabla;
        }
        public DataTable cespecificoc(string cedula)
        {
            SqlDataAdapter cespecic = new SqlDataAdapter("ConsultaEspecificaCedulaProveedor", entradatos());
            cespecic.SelectCommand.CommandType = CommandType.StoredProcedure;
            cespecic.SelectCommand.Parameters.Add("@cedula", SqlDbType.BigInt).Value = cedula;
            DataTable tabla = new DataTable();
            cespecic.Fill(tabla);
            return tabla;
        }
        public DataTable cespecificesta()
        {
            SqlDataAdapter cespecic = new SqlDataAdapter("consultaEspecificaEstadoProveedor", entradatos());
            cespecic.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            cespecic.Fill(tabla);
            return tabla;
        }
        public string actuusua(string nomcliente, string identificacion, string telefono, string empresa, string celular, string email, string telefono2, string estado)
        {
            SqlDataAdapter empresa1 = new SqlDataAdapter("ConsultarCodigoEmpresa", entradatos());
            empresa1.SelectCommand.CommandType = CommandType.StoredProcedure;
            empresa1.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = empresa;
            DataTable tabla1 = new DataTable();
            empresa1.Fill(tabla1);
            empresa = tabla1.Rows[0][0].ToString();

            SqlCommand actualizar = new SqlCommand("ActualizarProveedor", entradatos());
            actualizar.CommandType = CommandType.StoredProcedure;
            actualizar.Connection.Open();
            actualizar.Parameters.Add("@cedula", SqlDbType.BigInt).Value = identificacion;
            actualizar.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nomcliente;
            actualizar.Parameters.Add("@empresa", SqlDbType.TinyInt).Value = empresa;
            actualizar.Parameters.Add("@telefono", SqlDbType.Int).Value = telefono;
            actualizar.Parameters.Add("@telefono2", SqlDbType.Int).Value = telefono2;
            actualizar.Parameters.Add("@celular", SqlDbType.BigInt).Value = celular;
            actualizar.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = email;
            actualizar.Parameters.Add("@estado", SqlDbType.Char, 1).Value = estado;
            actualizar.ExecuteNonQuery();

            return "1";
        }
        public string icancti(string cedulaincati)
        {
            SqlCommand actualizar = new SqlCommand("InactivarProveedor", entradatos());
            actualizar.CommandType = CommandType.StoredProcedure;
            actualizar.Connection.Open();
            actualizar.Parameters.Add("@cedula", SqlDbType.BigInt).Value = cedulaincati;
            actualizar.ExecuteNonQuery();

            return "1";

        }
    }
}
