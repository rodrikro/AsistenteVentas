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
    public partial class ArticuloDialog : Form
    {
        ConstantesBD _constantesBD = new ConstantesBD();
        MainNegocioServicios _servicios;

        public ArticuloDialog(ConstantesBD constantesBD)
        {
            _constantesBD = constantesBD;
            _servicios = new MainNegocioServicios(constantesBD);
            InitializeComponent();
        }

        private void ArticuloDialog_Load(object sender, EventArgs e)
        {
            //Recupera listas para combos
            var listaDepartamentos = _servicios.ServicioDepartamentos.RecuperaDepartamentos(new Departamento());
            var listaProveedores = _servicios.ServicioProveedores.RecuperaProveedores(new Proveedor());
            
            //
            LlenaCombos(listaDepartamentos, listaProveedores);

        }

        private void LlenaCombos(List<Departamento> listaDepartamentos, List<Proveedor> listaProveedores) 
        {
            //Lista de departamentos
            cmbx_departamento.DataSource = listaDepartamentos;
            cmbx_departamento.ValueMember = "idDepartamento";
            cmbx_departamento.DisplayMember = "nombreDepartamento";

            //Lista de proveedores
            cmbx_proveedor.DataSource = listaProveedores;
            cmbx_proveedor.ValueMember = "IdProveedor";
            cmbx_proveedor.DisplayMember = "NombreProveedor";

        }

        private void cmbx_departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var itemSelected = (Departamento) cmbx_departamento.SelectedItem;
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
