using AccesoDatos.Constantes;
using AccesoDatos.Modelos;
using Negocio.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsistenteVentas.Control
{
    public partial class IniciarSesionForm : Form
    {
        ConstantesBD _constantesBD = new ConstantesBD();
        MainNegocioServicios _usuarioServicio;

        public IniciarSesionForm(ConstantesBD constantesBD)
        {
            _constantesBD = constantesBD;
            _usuarioServicio = new MainNegocioServicios(constantesBD);
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void txt_usuario_KeyUp(object sender, KeyEventArgs e)
        {
            lbl_mensaje.Visible = false;
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }

        }

        private void txt_contrasena_KeyUp(object sender, KeyEventArgs e)
        {
            lbl_mensaje.Visible = false;
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void Login()
        {
            Usuario usuario = new Usuario();
            usuario.usuario = string.IsNullOrEmpty(txt_usuario.Text) ? string.Empty : txt_usuario.Text;
            usuario.contrasena = string.IsNullOrEmpty(txt_contrasena.Text) ? string.Empty : txt_contrasena.Text;

            try
            {
                var estaAutenticado = _usuarioServicio.ServicioUsuarios.IniciarSesion(usuario);

                if (estaAutenticado)
                {
                    //Abrir pantalla principal
                    EscritorioAsistenteForm escritorioAsistente = new EscritorioAsistenteForm(_constantesBD);
                    escritorioAsistente.Show();
                    this.Hide();
                }
                else
                {
                    //Mostrar label con error
                    lbl_mensaje.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Contacte a soporte. \nDetalle de la excepción: "
                    + ex.Message, "Algo salió mal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
