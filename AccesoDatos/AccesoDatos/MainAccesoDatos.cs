using AccesoDatos.Catalogos;
using AccesoDatos.Constantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class MainAccesoDatos
    {
        ConstantesBD _constantesBD;
        public OperacionesUsuario opUsuarios { get; set; }
        public OperacionesDepartamentos opDepartamentos { get; set; }
        public OperacionesCategorias opCategorias { get; set; }

        public MainAccesoDatos(ConstantesBD constantesBD) 
        {
            _constantesBD = constantesBD;
            opUsuarios = new OperacionesUsuario(_constantesBD);
            opDepartamentos = new OperacionesDepartamentos(_constantesBD);
            opCategorias = new OperacionesCategorias(_constantesBD);
        }
    }
}
