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
    public class OperacionesCategorias
    {
        ConstantesBD _constantesBD;
        ConexionBaseDatos _conn;
        string _tabla = "Categorias";

        public OperacionesCategorias(ConstantesBD constantesBD)
        {
            _constantesBD = constantesBD;
            _conn = new ConexionBaseDatos(_constantesBD);
        }

        public List<Categoria> RecuperaCategorias(Categoria categoria)
        {
            List<Categoria> listaResp = new List<Categoria>();
            Categoria o = new Categoria();
            try
            {
                //Acceso a base de datos
                _conn.AbreBD();

                //Creacion de query
                string query = "";
                query += " SELECT * ";
                query += " FROM " + _tabla;
                query += " WHERE idDepartamento = {0}";

                query = string.Format(query, categoria.idDepartamento);

                //Consulta a la base de datos
                MySqlCommand comando = new MySqlCommand(query, _conn.conexionBaseDatos);

                MySqlDataReader reader = comando.ExecuteReader();


                //Llenado de DataSet con contenido de la consulta
                while (reader.Read())
                {
                    //Manipulación del DataSet para tratarlo como lista
                    o = new Categoria();

                    o.idCategoria = DBNull.Value == reader["idCategoria"] ? 0 : int.Parse(reader["idCategoria"].ToString());
                    o.idDepartamento= DBNull.Value == reader["idDepartamento"] ? 0 : int.Parse(reader["idDepartamento"].ToString());
                    o.clave = DBNull.Value == reader["clave"] ? string.Empty : reader["clave"].ToString();
                    o.nombreCategoria = DBNull.Value == reader["nombreCategoria"] ? string.Empty : reader["nombreCategoria"].ToString();
                    o.descripcion = DBNull.Value == reader["descripcion"] ? string.Empty : reader["descripcion"].ToString();
                    o.momentoCreacion = DBNull.Value == reader["momentoCreacion"] ? DateTime.MinValue : DateTime.Parse(reader["momentoCreacion"].ToString());
                    o.momentoModificacion = DBNull.Value == reader["momentoModificacion"] ? DateTime.MinValue : DateTime.Parse(reader["momentoModificacion"].ToString());

                    listaResp.Add(o);
                }

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
