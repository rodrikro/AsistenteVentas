using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using AccesoDatos.Constantes;

namespace AsistenteVentas
{
    public class ConfiguracionGlobal
    {
        public ConstantesBD constantesBD { get; set; }

        public ConfiguracionGlobal() 
        {
            LlenarConstantesBD();
        }

        private void LlenarConstantesBD()
        {
            try
            {
                constantesBD = new ConstantesBD();

                var appSettings = ConfigurationSettings.AppSettings;

                if (appSettings.Count == 0)
                {
                    Console.WriteLine("AppSettings is empty.");
                }
                else
                {

                    constantesBD.host = appSettings["host"] ?? "No existe";
                    constantesBD.puerto = appSettings["puerto"] ?? "No existe";
                    constantesBD.usuario = appSettings["usuario"] ?? "No existe";
                    constantesBD.contrasena = appSettings["contrasena"] ?? "No existe";
                    constantesBD.baseDatos = appSettings["baseDatos"] ?? "No existe";
                }
            }
            catch (Exception ex)
            {
                //throw;
            }
        }

    }
}
