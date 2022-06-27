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
    public class ProductoServicio
    {
        ConstantesBD _constantesBD;
        MainAccesoDatos _accesoDatos;
        public ProductoServicio(ConstantesBD constantesBD)
        {
            _constantesBD = constantesBD;
            _accesoDatos = new MainAccesoDatos(_constantesBD);
        }


        public bool Inserta(Producto p)
        {
            bool result = false;
            try
            {
                TimeZoneInfo cstZone = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time");

                //p.FechaCreacion = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now, cstZone);
                //p.FechaModificacion = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now, cstZone);
                p.FechaCreacion = DateTime.Now;
                p.FechaModificacion = DateTime.Now;

                _accesoDatos.opProductos.InsertaProducto(p);

                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {

            }

        }

    }
}
