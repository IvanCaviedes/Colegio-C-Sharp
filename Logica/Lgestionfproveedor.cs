using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;

namespace Logica
{
    public class Lgestionfproveedor
    {
        public DataTable Nombreproveedor()
        {
            Dgestionfproveedor nue = new Dgestionfproveedor();
            return nue.nombredomic();
        }

    }
}
