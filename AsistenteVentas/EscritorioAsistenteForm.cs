using AccesoDatos.Constantes;
using AsistenteVentas.Inventario;
using AsistenteVentas.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsistenteVentas
{
    public partial class EscritorioAsistenteForm : Form
    {
        ConstantesBD _constantesBD;
        bool banderaFormAbierto = true;
        public EscritorioAsistenteForm(ConstantesBD constantesBD)
        {
            _constantesBD = constantesBD;
            InitializeComponent();
        }

        private void EscritorioAsistente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (banderaFormAbierto)
            {
                var resp = MessageBox.Show("¿Estas segur@ de cerrar el asistente?", "Espera", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {
                    banderaFormAbierto = false;
                    Application.Exit();
                }
                else
                {
                    //No hace nada
                    e.Cancel = true;
                }
            }
        }

        private void EscritorioAsistente_Load(object sender, EventArgs e)
        {
            AbrirFormVentas();
        }

        private void AbrirFormVentas()
        {
            PuntoVentaForm puntoVenta = new PuntoVentaForm();
            puntoVenta.MdiParent = EscritorioAsistenteForm.ActiveForm;
            puntoVenta.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormVentas();
        }

        private void catálogoDeArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirCatalogoArticulos();
        }

        private void AbrirCatalogoArticulos()
        {
            CatalogoArticulosForm catalogoArticulos = new CatalogoArticulosForm();
            catalogoArticulos.MdiParent = EscritorioAsistenteForm.ActiveForm;
            catalogoArticulos.Show();
        }

        private void categoriasYDepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirCategoriasDepartamentos();
        }

        private void AbrirCategoriasDepartamentos()
        {
            CategoriasDepartamentosForm categoriasDepartamentosForm = new CategoriasDepartamentosForm();
            categoriasDepartamentosForm.MdiParent = EscritorioAsistenteForm.ActiveForm;
            categoriasDepartamentosForm.Show();
        }
    }
}
