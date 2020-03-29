using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Dgestioncliente : conexion
    {
        public string insercioncliente(string nombrec, string identi, string tel1, string direc, string cel, string email, string tel2, string registrado)
        {
            //try
            //{

            SqlCommand registrar = new SqlCommand("NuevoCliente", entradatos());
            registrar.CommandType = CommandType.StoredProcedure;
            registrar.Connection.Open();
            registrar.Parameters.Add("@Cedula_Cliente", SqlDbType.BigInt).Value = identi;
            registrar.Parameters.Add("@registrado_por", SqlDbType.BigInt).Value = registrado;
            registrar.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = nombrec;
            registrar.Parameters.Add("@Direccion", SqlDbType.VarChar, 50).Value = direc;
            registrar.Parameters.Add("@Telefono", SqlDbType.Int).Value = tel1;
            registrar.Parameters.Add("@Telefono2", SqlDbType.Int).Value = tel2;
            registrar.Parameters.Add("@Celular", SqlDbType.BigInt).Value = cel;
            registrar.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;
            registrar.ExecuteNonQuery();

            return "1";
        }
        //catch
        //{
        //    return "2";
        //}



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
        public DataTable consugeneral()
        {
            SqlDataAdapter cgene = new SqlDataAdapter("ConsultaGeneralCliente", entradatos());
            cgene.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            cgene.Fill(tabla);
            return tabla;
        }
        public DataTable cespecifico(string nombre)
        {
            SqlDataAdapter cespeci = new SqlDataAdapter("consultaEspecificaNombreCliente", entradatos());
            cespeci.SelectCommand.CommandType = CommandType.StoredProcedure;
            cespeci.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
            DataTable tabla = new DataTable();
            cespeci.Fill(tabla);
            return tabla;
        }
        public DataTable cespecificoc(string cedula)
        {
            SqlDataAdapter cespecic = new SqlDataAdapter("ConsultaEspecificaCedulaCliente", entradatos());
            cespecic.SelectCommand.CommandType = CommandType.StoredProcedure;
            cespecic.SelectCommand.Parameters.Add("@cedula", SqlDbType.BigInt).Value = cedula;
            DataTable tabla = new DataTable();
            cespecic.Fill(tabla);
            return tabla;
        }
        public string actuusua(string nomcliente, string identificacion,string telefono,string direccion,string  celular, string email,string telefono2, string estado)
        {
            SqlCommand actualizar = new SqlCommand("ActualizarCliente", entradatos());
            actualizar.CommandType = CommandType.StoredProcedure;
            actualizar.Connection.Open();
            actualizar.Parameters.Add("@cedula", SqlDbType.BigInt).Value = identificacion;
            actualizar.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value =nomcliente;
            actualizar.Parameters.Add("@Direccion", SqlDbType.VarChar, 50).Value = direccion;
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
            SqlCommand actualizar = new SqlCommand("InactivarCliente", entradatos());
            actualizar.CommandType = CommandType.StoredProcedure;
            actualizar.Connection.Open();
            actualizar.Parameters.Add("@cedula", SqlDbType.BigInt).Value = cedulaincati;
            actualizar.ExecuteNonQuery();

            return "1";

        }
    }
}

    //nomcliente, identificacion, telefono,direccion,celular,email,telefono2,estado2

