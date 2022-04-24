using AccesoDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Catalogos
{
    public class OperacionesUsuario
    {
        public OperacionesUsuario() { }

        public List<Usuario> RecuperaUsuarios(Usuario usuario)
        {
            List<Usuario> listaResp = new List<Usuario>();
            Usuario o = new Usuario();
            try
            {
                //Acceso a base de datos

                //Creacion de query

                //Consulta a la base de datos

                //Llenado de DataSet con contenido de la consulta

                //Manipulación del DataSet para tratarlo como lista

                o = new Usuario();
                o.usuario = "RAMK";
                o.nombre = "Rodrigo Monarrez";
                o.perfil = "ADMINISTRADOR";
                o.descripcion = "";
                o.contrasena = "12345";

                listaResp.Add(o);

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                //Cerrar conexión a base de datos
            }

            return listaResp;
        }
    }
}
