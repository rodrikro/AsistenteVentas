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
    public class OperacionesProveedores
    {
        ConstantesBD _constantesBD;
        ConexionBaseDatos _conn;
        string _tabla = "Proveedores";

        public OperacionesProveedores(ConstantesBD constantesBD)
        {
            _constantesBD = constantesBD;
            _conn = new ConexionBaseDatos(_constantesBD);
        }

        public List<Proveedor> RecuperaProveedores(Proveedor proveedor)
        {
            List<Proveedor> listaResp = new List<Proveedor>();
            Proveedor o = new Proveedor();
            try
            {
                //Acceso a base de datos
                _conn.AbreBD();

                //Creacion de query
                string query = "";
                query += " SELECT * ";
                query += " FROM " + _tabla;
                //query += " WHERE departamento = '{0}'";


                //Consulta a la base de datos
                MySqlCommand comando = new MySqlCommand(query, _conn.conexionBaseDatos);

                MySqlDataReader reader = comando.ExecuteReader();


                //Llenado de DataSet con contenido de la consulta
                while (reader.Read())
                {
                    //Manipulación del DataSet para tratarlo como lista
                    o = new Proveedor();

                    o.IdProveedor = DBNull.Value == reader["IdProveedor"] ? 0 : int.Parse(reader["IdProveedor"].ToString());
                    o.NombreProveedor = DBNull.Value == reader["NombreProveedor"] ? string.Empty : reader["NombreProveedor"].ToString();
                    o.FechaCreacion = DBNull.Value == reader["FechaCreacion"] ? DateTime.MinValue : DateTime.Parse(reader["FechaCreacion"].ToString());
                    o.FechaModificacion = DBNull.Value == reader["FechaModificacion"] ? DateTime.MinValue : DateTime.Parse(reader["FechaModificacion"].ToString());

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
