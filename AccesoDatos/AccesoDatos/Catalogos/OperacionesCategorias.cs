using AccesoDatos.Constantes;
using AccesoDatos.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Catalogos
{
    public class OperacionesCategorias
    {
        ConstantesBD _constantesBD;
        ConexionBaseDatos _conn;
        string _tabla = "Categorias";

        public OperacionesCategorias(ConstantesBD constantesBD)
        {
            _constantesBD = constantesBD;
            _conn = new ConexionBaseDatos(_constantesBD);

        }
    }
}
