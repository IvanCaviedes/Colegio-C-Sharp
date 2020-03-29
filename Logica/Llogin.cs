using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;


namespace Logica
{
    public class Llogin
    {
        //instacincia recibe y envia 2 datos

        public int validar(string usua, string pass)
        {
            Dlogin enviar = new Dlogin();
            return enviar.comunicar(usua, pass);
        
        }
    
        //instacincia recibe y envia 1 datos

        public string tipou(string q)
        {        
            Dlogin tipo1 = new Dlogin();
            return tipo1.leercargo(q);
        }

        //instacincia recibe y envia 1 datos

        public string name(string g)
        {
            Dlogin tipo2 = new Dlogin();
            return tipo2.leernombre(g);
        }
    }
}
