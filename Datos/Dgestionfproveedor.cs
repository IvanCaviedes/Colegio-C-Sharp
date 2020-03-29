using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Dgestionfproveedor:conexion
    {
        public DataTable nombredomic()
        {
            SqlDataAdapter cespecic = new SqlDataAdapter("NOMBREPROVEEDORES", entradatos());
            cespecic.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            cespecic.Fill(tabla);
            return tabla;
        }

    }
}
