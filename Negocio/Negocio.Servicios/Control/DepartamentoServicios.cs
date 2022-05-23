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
    public class DepartamentoServicios
    {
        ConstantesBD _constantesBD;
        MainAccesoDatos _accesoDatos;
        public DepartamentoServicios(ConstantesBD constantesBD)
        {
            _constantesBD = constantesBD;
            _accesoDatos = new MainAccesoDatos(_constantesBD);
        }

        public List<Departamento> RecuperaDepartamentos(Departamento d)
        {
            List<Departamento> lista = new List<Departamento>();
            try
            {
                lista = _accesoDatos.opDepartamentos.RecuperaDepartamentos(d);

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
