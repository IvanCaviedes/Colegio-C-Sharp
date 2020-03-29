using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Dgestionventa : conexion
    {

        public string DConsultarCliente(string a)
        {
            try
            {
                SqlDataAdapter Consultar = new SqlDataAdapter("ConsultarNombreCliente", entradatos());
                Consultar.SelectCommand.CommandType = CommandType.StoredProcedure;
                Consultar.SelectCommand.Parameters.Add("@Cedula", SqlDbType.BigInt).Value = a;
                DataTable tabla = new DataTable();
                Consultar.Fill(tabla);
                string cedula = tabla.Rows[0][0].ToString();
                return cedula;
            }
            catch
            {
                return "Cliente no registrado";
            }

        }
        public DataTable DConsultatipo()
        {
            SqlDataAdapter adaptador = new SqlDataAdapter("ConsultaTipo", entradatos());
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable ds = new DataTable();
            adaptador.Fill(ds);
            return ds;
        }
        public DataTable DConsultaProducto(string a)
        {

                SqlDataAdapter producto = new SqlDataAdapter("ConsultarCodigotipo", entradatos());
                producto.SelectCommand.CommandType = CommandType.StoredProcedure;
                producto.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = a;
                DataTable tabla1 = new DataTable();
                producto.Fill(tabla1);
                a = tabla1.Rows[0][0].ToString();

                SqlDataAdapter adaptador = new SqlDataAdapter("Consultaproductotipo", entradatos());
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand.Parameters.Add("tipo", SqlDbType.BigInt).Value = a;
                DataTable ds = new DataTable();
                adaptador.Fill(ds);
                return ds;
             
        }

        public DataTable DDatosProducto(string a)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter("DatosPorProducto",entradatos());
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
            adaptador.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 120).Value = a;
            DataTable ds = new DataTable();
            adaptador.Fill(ds);
            return ds;
        }
        public string codfactura1()
        {
            try
            {
                SqlDataAdapter producto = new SqlDataAdapter("CODFACTURA", entradatos());
                producto.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable tabla1 = new DataTable();
                producto.Fill(tabla1);
                return tabla1.Rows[0][0].ToString();
            }
            catch
            {
                return "1";
            }
        }
        public string regfactura(string a, string b, string c, string d, string e, string f, string g)
        {
            SqlCommand facturas = new SqlCommand("FVENTA", entradatos());
            facturas.CommandType = CommandType.StoredProcedure;
            facturas.Connection.Open();
            facturas.Parameters.Add("@FECHA", SqlDbType.Date).Value = Convert.ToDateTime(a);
            facturas.Parameters.Add("@VALOR", SqlDbType.Int).Value = b;
            facturas.Parameters.Add("@CANTIDAD", SqlDbType.BigInt).Value = c;
            facturas.Parameters.Add("@IVA", SqlDbType.Real).Value = d;
            facturas.Parameters.Add("@DESC", SqlDbType.Real).Value = e;
            facturas.Parameters.Add("@REGISTRADO", SqlDbType.BigInt).Value = f;
            facturas.Parameters.Add("@CEDULA", SqlDbType.BigInt).Value = g;
            facturas.ExecuteNonQuery();
            return "1";
        }
        public string facventa(string a, string b, string c, string d, string e)
        {
            SqlCommand facturas = new SqlCommand("DETALLESFACTURA", entradatos());
            facturas.CommandType = CommandType.StoredProcedure;
            facturas.Connection.Open();
            facturas.Parameters.Add("@PRODUCTO", SqlDbType.TinyInt).Value =a;
            facturas.Parameters.Add("@FACTURAVENTA", SqlDbType.TinyInt).Value = b;
            facturas.Parameters.Add("@VALORUNIDAD", SqlDbType.BigInt).Value = c;
            facturas.Parameters.Add("@UNIDADESVENDIDAS", SqlDbType.Int).Value = d;
            facturas.Parameters.Add("@VALORIVA", SqlDbType.BigInt).Value = e;
            facturas.ExecuteNonQuery();

            SqlCommand DESC = new SqlCommand("DESCONTCANTIDAD", entradatos());
            DESC.CommandType = CommandType.StoredProcedure;
            DESC.Connection.Open();
            DESC.Parameters.Add("@CODIGO", SqlDbType.TinyInt).Value = a;
            DESC.Parameters.Add("@CANTI", SqlDbType.Int).Value = d;
            DESC.ExecuteNonQuery();

            return "1";
        }
        public DataTable consultacod(string a)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter("CONSULTAESPECIFICODFAC", entradatos());
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
            adaptador.SelectCommand.Parameters.Add("@COD", SqlDbType.VarChar, 120).Value = a;
            DataTable ds = new DataTable();
            adaptador.Fill(ds);
            return ds;
        }
        public DataTable consultafecha(DateTime a)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter("CONSULTAESPECIFICOFECHA", entradatos());
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
            adaptador.SelectCommand.Parameters.Add("@FECHA", SqlDbType.Date).Value = a;
            DataTable ds = new DataTable();
            adaptador.Fill(ds);
            return ds;
        }
    }
}
