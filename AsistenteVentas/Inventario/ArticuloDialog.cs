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
        int cantPiezas = 0;
        int cantMin = 0; 
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

        private void txt_cantPiezas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (    !char.IsControl(e.KeyChar) 
                    && !char.IsDigit(e.KeyChar) 
                    && (e.KeyChar != '.')   )
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_cantidadMas_Click(object sender, EventArgs e)
        {
            string strCantPiezas = string.IsNullOrEmpty(txt_cantPiezas.Text) ? "0" : txt_cantPiezas.Text;
            cantPiezas = int.Parse(strCantPiezas);
            cantPiezas++;
            txt_cantPiezas.Text = cantPiezas.ToString();
        }

        private void btn_cantidadMenos_Click(object sender, EventArgs e)
        {
            string strCantPiezas = string.IsNullOrEmpty(txt_cantPiezas.Text) ? "0" : txt_cantPiezas.Text;
            cantPiezas = int.Parse(strCantPiezas);

            if (cantPiezas!=0)
            {
                cantPiezas--;
            }

            txt_cantPiezas.Text = cantPiezas.ToString();
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.GuardaArticulo();
        }

        private void GuardaArticulo()
        {
            try
            {
                Producto producto = ValidaDatos();
                if (producto != null)
                {
                    _servicios.ServicioProductos.Inserta(producto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Producto ValidaDatos()
        {
            Producto producto = new Producto();
            try
            {
                //------
                string strPrecio = String.IsNullOrEmpty(txt_precio.Text) ? "0" : txt_precio.Text;
                string strCostoProveedor = String.IsNullOrEmpty(txt_costoProveedor.Text) ? "0" : txt_costoProveedor.Text;
                string strCantidadPiezas = String.IsNullOrEmpty(txt_cantPiezas.Text) ? "0" : txt_cantPiezas.Text;
                string strCantidadMinima = String.IsNullOrEmpty(txt_cantidadMinima.Text) ? "0" : txt_cantidadMinima.Text;
                //------
                string codigo = txt_codigo.Text;
                string nombre = txt_nombre.Text;
                int cantidad = int.Parse(strCantidadPiezas);
                int cantidadMinima = int.Parse(strCantidadMinima);

                decimal precio = decimal.Parse(strPrecio);
                decimal costoProveedor = decimal.Parse(strCostoProveedor);

                var departamento = (Departamento)cmbx_departamento.SelectedItem;
                int idDepartamento = departamento.idDepartamento;
                var categoria = (Categoria)cmbx_categoria.SelectedItem;
                int idCategoria = categoria.idCategoria;
                var proveedor = (Proveedor)cmbx_proveedor.SelectedItem;
                int idProveedor = proveedor.IdProveedor;


                producto.IdDepartamento = idDepartamento;
                producto.IdCategoria = idCategoria;
                producto.IdProveedor = idProveedor;
                
                producto.Clave = codigo;
                producto.Nombre = nombre;
                producto.Presentacion = "";
                producto.CantidadMinima = cantidadMinima;
                producto.CantidadActual = cantidad;

                producto.PrecioPublico = precio;
                producto.CostoProveedor = costoProveedor;
                
                producto.Descripcion = ""; //pendiente
                
                producto.Activo = true;

                producto.FechaCreacion = DateTime.Now; //pendiente
                producto.FechaModificacion = DateTime.Now; //pendiente

                return producto;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique los datos.\n" + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        private void btn_cantMinMenos_Click(object sender, EventArgs e)
        {
            string strCantMin = string.IsNullOrEmpty(txt_cantidadMinima.Text) ? "0" : txt_cantidadMinima.Text;
            cantMin = int.Parse(strCantMin);

            if (cantMin != 0)
            {
                cantMin--;
            }

            txt_cantidadMinima.Text = txt_cantidadMinima.ToString();
        }

        private void btn_cantMinMas_Click(object sender, EventArgs e)
        {
            string strCantMin = string.IsNullOrEmpty(txt_cantidadMinima.Text) ? "0" : txt_cantidadMinima.Text;
            cantMin = int.Parse(strCantMin);
            cantMin++;
            txt_cantidadMinima.Text = cantMin.ToString();
        }
    }
}
