using AccesoDatos.Constantes;
using Negocio.Servicios.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Servicios
{
    public class MainNegocioServicios
    {
        ConstantesBD _constantesBD;
        public UsuarioServicios ServicioUsuarios { get; set; }
        public DepartamentoServicios ServicioDepartamentos { get; set; }
        public CategoriaServicios ServiciosCategorias { get; set; }
        public ProveedorServicio ServicioProveedores { get; set; }


        public MainNegocioServicios(ConstantesBD constantesBD) 
        {
            _constantesBD = constantesBD;
            
            ServicioUsuarios = new UsuarioServicios(_constantesBD);
            ServicioDepartamentos = new DepartamentoServicios(_constantesBD);
            ServiciosCategorias = new CategoriaServicios(_constantesBD);
            ServicioProveedores = new ProveedorServicio(_constantesBD);

        }
    }
}
