using AccesoDatos.Constantes;
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

namespace AsistenteVentas.Inventario
{
    public partial class CatalogoArticulosForm : Form
    {
        ConstantesBD _constantesBD = new ConstantesBD();
        MainNegocioServicios _servicios;

        public CatalogoArticulosForm(ConstantesBD constantesBD)
        {
            _constantesBD = constantesBD;
            _servicios = new MainNegocioServicios(constantesBD);
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            AbrirArticuloDialog();
        }

        private void AbrirArticuloDialog()
        {
            ArticuloDialog articuloDialog = new ArticuloDialog(_constantesBD);
            articuloDialog.ShowDialog(this);
        }
    }
}
