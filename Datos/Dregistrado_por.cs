using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
   public class Dregistrado_por:conexion
    {
        public string DRegistradoPor(string nombre)
        {
            SqlDataAdapter Consultar = new SqlDataAdapter("registrado_por", entradatos());
            Consultar.SelectCommand.CommandType = CommandType.StoredProcedure;
            Consultar.SelectCommand.Parameters.Add("@usuario", SqlDbType.VarChar, 120).Value = nombre;
            DataTable tabla = new DataTable();
            Consultar.Fill(tabla);
            string cedula = tabla.Rows[0][0].ToString();
            return cedula;
        }
    }
}
