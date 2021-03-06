using AccesoDatos;
using AccesoDatos.Constantes;
using AccesoDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Servicios.Control
{
    public class CategoriaServicios
    {
        ConstantesBD _constantesBD;
        MainAccesoDatos _accesoDatos;
        public CategoriaServicios(ConstantesBD constantesBD)
        {
            _constantesBD = constantesBD;
            _accesoDatos = new MainAccesoDatos(_constantesBD);
        }

        public List<Categoria> RecuperaCategorias(Categoria c)
        {
            List<Categoria> lista = new List<Categoria>();
            try
            {
                lista = _accesoDatos.opCategorias.RecuperaCategorias(c);

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {

            }

            return lista;
        }
    }
}
