using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Constantes;
using MySql.Data.MySqlClient;

namespace AccesoDatos.Utilidades
{
    public class ConexionBaseDatos
    {
        public MySqlConnection conexionBaseDatos;
        string _cadenaConexion = "";
        public ConexionBaseDatos(ConstantesBD constantesBD) 
        {
            this._cadenaConexion = 
                String.Format(
                    "datasource={0};" +
                    "port={1};" +
                    "username={2};" +
                    "password={3};" +
                    "database={4};"
                    , constantesBD.host
                    , constantesBD.puerto
                    , constantesBD.usuario
                    , constantesBD.contrasena
                    , constantesBD.baseDatos);
        }

        public MySqlConnection AbreBD()
        {
            conexionBaseDatos = new MySqlConnection(this._cadenaConexion);
            try
            {
                conexionBaseDatos.Open();
            }
            catch (Exception ex)
            {

                throw;
            }

            return conexionBaseDatos;
        }

        public bool CerrarBD()
        {
            bool respuesta = false;
            try
            {
                conexionBaseDatos.Close();
                respuesta = true;
            }
            catch (Exception ex)
            {
                respuesta = false;
                throw;
            }

            return respuesta;
        }
    }
}
