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
    public class OperacionesProductos
    {
        ConstantesBD _constantesBD;
        ConexionBaseDatos _conn;
        string _tabla = "Productos";

        public OperacionesProductos(ConstantesBD constantesBD)
        {
            _constantesBD = constantesBD;
            _conn = new ConexionBaseDatos(_constantesBD);
        }

        public Producto InsertaProducto( Producto producto) 
        {
            try
            {
                //Acceso a base de datos
                _conn.AbreBD();

                //Creacion de query
                string query = "";
                query += " INSERT INTO " + _tabla;
                query += " ( ";
                //query += " IdProducto, ";
                query += "      IdDepartamento, IdCategoria, IdProveedor, Clave, Nombre, Presentacion, ";
                query += "      CantidadMinima, CantidadActual, PrecioPublico, CostoProveedor, Descripcion, ";
                query += "      Activo, FechaCreacion, FechaModificacion ";
                query += " ) ";
                query += " VALUES ";
                query += " ( ";
                query += "      {0}, {1}, {2}, '{3}', '{4}', '{5}', ";
                query += "      {6}, {7}, {8}, {9}, '{10}', ";
                query += "      {11}, '{12}', '{13}' ";
                query += " ) ";

                //--------------------------------------------------------------------
                query = String.Format(query,
                    producto.IdDepartamento, producto.IdCategoria, producto.IdProveedor, producto.Clave, producto.Nombre, producto.Presentacion,
                    producto.CantidadMinima, producto.CantidadActual, producto.PrecioPublico, producto.CostoProveedor, producto.Descripcion,
                    producto.Activo, producto.FechaCreacion.ToString("yyyy/MM/dd hh:mm:ss"), producto.FechaModificacion.ToString("yyyy/MM/dd hh:mm:ss"));

                //Consulta a la base de datos
                MySqlCommand comando = new MySqlCommand(query, _conn.conexionBaseDatos);

                comando.ExecuteNonQuery();


                return producto;

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
        }


    }
}
