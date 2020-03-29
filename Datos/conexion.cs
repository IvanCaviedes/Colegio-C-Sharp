using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Datos
{
    public class conexion
    {
        //metodo de codigo de coneccion a la base de datos
        public SqlConnection entradatos() {
            SqlConnection entr = new SqlConnection("Data source =DESKTOP-UN8HCNB\\SQLEXPRESS; Initial Catalog = Drogueriaberlin ; Integrated Security = true");
            return entr;
        }
    }
}
