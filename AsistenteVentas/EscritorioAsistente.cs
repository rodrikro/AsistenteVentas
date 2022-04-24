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
    public partial class EscritorioAsistente : Form
    {
        public EscritorioAsistente()
        {
            InitializeComponent();
        }

        private void EscritorioAsistente_FormClosing(object sender, FormClosingEventArgs e)
        {
            var resp = MessageBox.Show("¿Estas segur@ de cerrar el asistente?", "Espera", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                //No hace nada
            }
        }

        private void EscritorioAsistente_Load(object sender, EventArgs e)
        {
            AbrirFormVentas();
        }

        private void AbrirFormVentas()
        {
            PuntoVenta puntoVenta = new PuntoVenta();
            puntoVenta.MdiParent = EscritorioAsistente.ActiveForm;
            puntoVenta.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormVentas();
        }
    }
}
