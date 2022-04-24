using AccesoDatos.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class MainAccesoDatos
    {

        public OperacionesUsuario opUsuarios { get; set; }

        public MainAccesoDatos() 
        {
            opUsuarios = new OperacionesUsuario();
        }
    }
}
