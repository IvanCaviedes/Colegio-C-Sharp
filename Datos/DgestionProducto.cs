using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class DgestionProducto:conexion
    {
        public string regtipo(string tipo)
        {
            SqlCommand epse = new SqlCommand("InsertarNuevotipo", entradatos());
            epse.CommandType = CommandType.StoredProcedure;
            epse.Connection.Open();
            epse.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = tipo;
            epse.ExecuteNonQuery();
            return "1";
        }
        public DataTable tipo1()
        {
            SqlDataAdapter cespecic = new SqlDataAdapter("ConsultaTipo", entradatos());
            cespecic.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            cespecic.Fill(tabla);
            return tabla;
        }
        public string runidade(string unidad)
        {
            SqlCommand epse = new SqlCommand("InsertarNuevounidad", entradatos());
            epse.CommandType = CommandType.StoredProcedure;
            epse.Connection.Open();
            epse.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = unidad;
            epse.ExecuteNonQuery();
            return "1";
        }
        public DataTable cunidad()
        {
            SqlDataAdapter cespecic = new SqlDataAdapter("Consultaunidad", entradatos());
            cespecic.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            cespecic.Fill(tabla);
            return tabla;
        }
        public string registrarproducto(string nombre, string tipo, string unidad, decimal contenido, decimal cantidad, string valorunidad, string imbima, string registrado,decimal iva,string proveedor)
        {
            //try
            //{
            SqlDataAdapter tipo1 = new SqlDataAdapter("ConsultarCodigotipo", entradatos());
            tipo1.SelectCommand.CommandType = CommandType.StoredProcedure;
            tipo1.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = tipo;
            DataTable tabla = new DataTable();
            tipo1.Fill(tabla);
            tipo = tabla.Rows[0][0].ToString();

            SqlDataAdapter uni = new SqlDataAdapter("ConsultarCodigounidad", entradatos());
            uni.SelectCommand.CommandType = CommandType.StoredProcedure;
            uni.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = unidad;
            DataTable tabla1 = new DataTable();
            uni.Fill(tabla1);
            unidad = tabla1.Rows[0][0].ToString();

            SqlDataAdapter prov = new SqlDataAdapter("ConsultarCodigopornombreproveedor", entradatos());
            prov.SelectCommand.CommandType = CommandType.StoredProcedure;
            prov.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = proveedor;
            DataTable tabla2 = new DataTable();
            prov.Fill(tabla2);
            proveedor = tabla2.Rows[0][0].ToString();

            SqlCommand registrar = new SqlCommand("NuevoProducto", entradatos());
            registrar.CommandType = CommandType.StoredProcedure;
            registrar.Connection.Open();
            registrar.Parameters.Add("@NOMBRE", SqlDbType.VarChar,150).Value = nombre;
            registrar.Parameters.Add("@CANTIDAD", SqlDbType.BigInt).Value =cantidad;
            registrar.Parameters.Add("@VALLORUNIDAD", SqlDbType.BigInt).Value = valorunidad;
            registrar.Parameters.Add("@TIPO", SqlDbType.TinyInt).Value = tipo;
            registrar.Parameters.Add("@MEDIDA", SqlDbType.TinyInt).Value = unidad;
            registrar.Parameters.Add("@CONTENIDO", SqlDbType.BigInt).Value = contenido;
            registrar.Parameters.Add("@IMBIMA", SqlDbType.VarChar,50).Value = imbima;
            registrar.Parameters.Add("@iva", SqlDbType.TinyInt).Value = iva;
            registrar.Parameters.Add("@ENTREGADO_POR", SqlDbType.BigInt).Value = proveedor;
            registrar.ExecuteNonQuery();

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
        public DataTable cproempr(string empresa)
        {
            SqlDataAdapter empresaa = new SqlDataAdapter("ConsultarCodigoEmpresa", entradatos());
            empresaa.SelectCommand.CommandType = CommandType.StoredProcedure;
            empresaa.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = empresa;
            DataTable tabla = new DataTable();
            empresaa.Fill(tabla);
            empresa = tabla.Rows[0][0].ToString();

            SqlDataAdapter proempres = new SqlDataAdapter("NProveedores", entradatos());
            proempres.SelectCommand.CommandType = CommandType.StoredProcedure;
            proempres.SelectCommand.Parameters.Add("@empresa", SqlDbType.TinyInt).Value = empresa;
            DataTable tabla1 = new DataTable();
            proempres.Fill(tabla1);
            return tabla1;
        }
        public DataTable consugeneral()
        {
            SqlDataAdapter cgene = new SqlDataAdapter("ConsultaGeneralProducto", entradatos());
            cgene.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            cgene.Fill(tabla);
            return tabla;
        }
        public DataTable cespecifico(string nombre)
        {
            DataTable tabla = new DataTable();
            try
            {
                SqlDataAdapter cespeci = new SqlDataAdapter("consultaEspecificaNombreProducto", entradatos());
                cespeci.SelectCommand.CommandType = CommandType.StoredProcedure;
                cespeci.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombre;
                cespeci.Fill(tabla);
                return tabla;
            }
            catch
            {
                return tabla;
            }
        }
        public DataTable cespecificoc(string codigo)
        {
            SqlDataAdapter cespecic = new SqlDataAdapter("consultaespecificacodigoproducto", entradatos());
            cespecic.SelectCommand.CommandType = CommandType.StoredProcedure;
            cespecic.SelectCommand.Parameters.Add("@codigo", SqlDbType.BigInt).Value = codigo;
            DataTable tabla = new DataTable();
            cespecic.Fill(tabla);
            return tabla;
        }
        public DataTable consuestado()
        {
            SqlDataAdapter cgene = new SqlDataAdapter("ConsultaGeneralProductoinctivo", entradatos());
            cgene.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            cgene.Fill(tabla);
            return tabla;
        }
        public string Actuproducto(string nombre, string valorunidad,  decimal iva,string cod,string estado,decimal cantidad)
        {

            SqlCommand registrar = new SqlCommand("ActualizarProducto", entradatos());
            registrar.CommandType = CommandType.StoredProcedure;
            registrar.Connection.Open();
            registrar.Parameters.Add("@COD",SqlDbType.TinyInt).Value = cod;
            registrar.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 150).Value = nombre;
            registrar.Parameters.Add("@VALLORUNIDAD", SqlDbType.BigInt).Value = valorunidad;
            registrar.Parameters.Add("@iva", SqlDbType.TinyInt).Value = iva;
            registrar.Parameters.Add("@estado", SqlDbType.Char,1).Value = estado;
            registrar.Parameters.Add("@catidad", SqlDbType.BigInt).Value = cantidad;
            registrar.ExecuteNonQuery();

            return "1";
        }
        public string icancti(string cedulaincati)
        {
            SqlCommand actualizar = new SqlCommand("InactivarProducto", entradatos());
            actualizar.CommandType = CommandType.StoredProcedure;
            actualizar.Connection.Open();
            actualizar.Parameters.Add("@cedula", SqlDbType.BigInt).Value = cedulaincati;
            actualizar.ExecuteNonQuery();

            return "1";

        }
        public string registrofechav(string b,DateTime a)
        {
            SqlCommand comando = new SqlCommand("fechadevencimiento", entradatos());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@producto", SqlDbType.BigInt).Value = b;
            comando.Parameters.Add("@fecha_de_vencimiento", SqlDbType.Date).Value = a;          
            comando.Connection.Open();
            comando.ExecuteNonQuery();
            return "1";
        }
        public string codproducto(string a)
        {
            SqlDataAdapter tipo1 = new SqlDataAdapter("cod_nombre", entradatos());
            tipo1.SelectCommand.CommandType = CommandType.StoredProcedure;
            tipo1.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = a;
            DataTable tabla = new DataTable();
            tipo1.Fill(tabla);
            string tipo = tabla.Rows[0][0].ToString();
            return tipo;
            
        }
    }
}
