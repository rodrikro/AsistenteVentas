using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelos
{
    public class Producto
    {

        public int IdProducto { get; set; }
        public int IdDepartamento { get; set; }
        public int IdCategoria { get; set; }
        public int IdProveedor { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Presentacion { get; set; }
        public int CantidadMinima { get; set; }
        public int CantidadActual { get; set; }
        public decimal PrecioPublico { get; set; }
        public decimal CostoProveedor { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion{ get; set; }
    }
}
