using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelos
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }

    }
}
