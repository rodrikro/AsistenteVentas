using AccesoDatos;
using AccesoDatos.Constantes;
using AccesoDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Servicios.Control
{
    public class UsuarioServicios
    {
        ConstantesBD _constantesBD;
        MainAccesoDatos _accesoDatos;
        public UsuarioServicios(ConstantesBD constantesBD) 
        {
            _constantesBD = constantesBD;
            _accesoDatos = new MainAccesoDatos(_constantesBD);
        }

        public bool IniciarSesion(Usuario us)
        {
            bool resp = false;
            //Convertir credenciales a mayusculas
            us.usuario = us.usuario.ToUpper();
            us.contrasena = us.contrasena.ToUpper();

            //Recuperar usuario de la base de datos
            var usuarioDB = _accesoDatos.opUsuarios.RecuperaUsuarios(us).FirstOrDefault();

            //Procesar info para validar accesos
            if (us.usuario == usuarioDB.usuario)
            {
                //Encriptar la contraseña que viene de pantalla
                var contrasenaEncript = us.contrasena;

                if (contrasenaEncript == usuarioDB.contrasena)
                {
                    resp = true;
                }
                else
                {
                    resp = false;
                }
            }
            else
            {
                resp = false;
            }


            return resp;
        }

    }
}
