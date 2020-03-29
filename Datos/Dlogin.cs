using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace Datos
{
    public class Dlogin : conexion
    {
        //metodo de validar usuario y contraseña
        public int comunicar(string a, string b)
        {
            try
            {
                SqlCommand verificar = new SqlCommand("Iniciodesesion", entradatos());
                verificar.CommandType = CommandType.StoredProcedure;
                verificar.Parameters.Add("@var_usuario", SqlDbType.VarChar, 50).Value = a;
                verificar.Parameters.Add("@var_contrasena", SqlDbType.VarChar, 20).Value = b;
                verificar.Connection.Open();
                SqlDataReader lector = verificar.ExecuteReader();
                if (lector.Read() == true)
                {
                    return 1;

                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 2;

            }
        }

        //metodo para extraer tipo de usuario
        public string leercargo(string f)
        {
            try
            {
                SqlDataAdapter usua = new SqlDataAdapter("Cargoynombre", entradatos());
                usua.SelectCommand.CommandType = CommandType.StoredProcedure;
                usua.SelectCommand.Parameters.Add("@var_usuario", SqlDbType.VarChar, 50).Value = f;
                DataTable tabla = new DataTable();
                usua.Fill(tabla);
                string dato = tabla.Rows[0][0].ToString();
                return dato;

            }
            catch
            {
                return "no devuelve ningun valor";
            }

        }
        //metodo para extraer el nombre del usuario
        public string leernombre(string h)
        {
            try
            {
                SqlDataAdapter usua = new SqlDataAdapter("Cargoynombre", entradatos());
                usua.SelectCommand.CommandType = CommandType.StoredProcedure;
                usua.SelectCommand.Parameters.Add("@var_usuario", SqlDbType.VarChar, 50).Value = h;
                DataTable tabla = new DataTable();
                usua.Fill(tabla);
                string nombre = tabla.Rows[0][1].ToString();
                return nombre;
            }
            catch
            {
                return "no devuelve ningun valor";
            }
        }
    }
}

