using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Modelos
{
    public class Categoria
    {
        public int idCategoria { get; set; }
        public int idDepartamento { get; set; }
        public string clave { get; set; }
        public string nombreCategoria { get; set; }
        public string descripcion { get; set; }
        public DateTime momentoCreacion { get; set; }
        public DateTime momentoModificacion { get; set; }
    }
}
