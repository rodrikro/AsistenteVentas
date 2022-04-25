using AccesoDatos.Constantes;
using AccesoDatos.Modelos;
using AccesoDatos.Utilidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Catalogos
{
    public class OperacionesUsuario
    {
        ConstantesBD _constantesBD;
        ConexionBaseDatos _conn;
        string _tabla = "Usuarios";
        public OperacionesUsuario(ConstantesBD constantesBD) 
        {
            _constantesBD = constantesBD;
            _conn = new ConexionBaseDatos(_constantesBD);

        }

        public List<Usuario> RecuperaUsuarios(Usuario usuario)
        {
            List<Usuario> listaResp = new List<Usuario>();
            Usuario o = new Usuario();
            try
            {
                //Acceso a base de datos
                _conn.AbreBD();

                //Creacion de query
                string query = "";
                query += " SELECT * ";
                query += " FROM " + _tabla;
                query += " WHERE usuario = '{0}'" ;

                query = String.Format(query, usuario.usuario);

                //Consulta a la base de datos
                MySqlCommand comando = new MySqlCommand(query, _conn.conexionBaseDatos);
                comando.ExecuteNonQuery();

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
                _conn.CerrarBD();
            }

            return listaResp;
        }
    }
}
