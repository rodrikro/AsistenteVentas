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
    public class ProveedorServicio
    {
        ConstantesBD _constantesBD;
        MainAccesoDatos _accesoDatos;
        public ProveedorServicio(ConstantesBD constantesBD)
        {
            _constantesBD = constantesBD;
            _accesoDatos = new MainAccesoDatos(_constantesBD);
        }

        public List<Proveedor> RecuperaProveedores(Proveedor p)
        {
            List<Proveedor> lista = new List<Proveedor>();
            try
            {
                lista = _accesoDatos.opProveedores.RecuperaProveedores(p);

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
