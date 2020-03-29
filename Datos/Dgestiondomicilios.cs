using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Dgestiondomicilios : conexion
    {
        public DataTable nombredomic()
        {
            SqlDataAdapter cespecic = new SqlDataAdapter("NOMBREDOMICILIARIOS", entradatos());
            cespecic.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            cespecic.Fill(tabla);
            return tabla;
        }
        public string dconsultadireccion(string a)
        {
            try
            {
                SqlDataAdapter Consultar = new SqlDataAdapter("CONSUDIRECCION", entradatos());
                Consultar.SelectCommand.CommandType = CommandType.StoredProcedure;
                Consultar.SelectCommand.Parameters.Add("@CEDULA", SqlDbType.BigInt).Value = a;
                DataTable tabla = new DataTable();
                Consultar.Fill(tabla);
                string cedula = tabla.Rows[0][0].ToString();
                return cedula;
            }
            catch
            {
                return "no sirvio we  :'v";
            }
        }
    }
}
