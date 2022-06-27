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

        private void CatalogoArticulosForm_Load(object sender, EventArgs e)
        {
            var listaDepartamentos = _servicios.ServicioDepartamentos.RecuperaDepartamentos(new Departamento());
            LlenaCombos(listaDepartamentos, null);
        }

        private void LlenaCombos(List<Departamento> listaDepartamentos, List<Proveedor> listaProveedores)
        {
            //Lista de departamentos
            cmbx_departamento.DataSource = listaDepartamentos;
            cmbx_departamento.ValueMember = "idDepartamento";
            cmbx_departamento.DisplayMember = "nombreDepartamento";


        }

        private void cmbx_departamento_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                var itemSelected = (Departamento)cmbx_departamento.SelectedItem;
                int idDepartamento = itemSelected.idDepartamento;

                Categoria categoria = new Categoria() { idDepartamento = idDepartamento };

                var listaCategorias = _servicios.ServiciosCategorias.RecuperaCategorias(categoria);
                this.LlenaComboCategorias(listaCategorias);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo salió mal.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LlenaComboCategorias(List<Categoria> listaCategorias)
        {
            cmbx_categoria.DataSource = listaCategorias;
            cmbx_categoria.ValueMember = "idCategoria";
            cmbx_categoria.DisplayMember = "nombreCategoria";

        }
    }
}
