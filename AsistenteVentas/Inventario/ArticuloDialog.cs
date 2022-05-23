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
            
            //
            LlenaCombos(listaDepartamentos);

        }

        private void LlenaCombos(List<Departamento> listaDepartamentos) 
        {
            cmbx_departamento.DataSource = listaDepartamentos;
            cmbx_departamento.ValueMember = "idDepartamento";
            cmbx_departamento.DisplayMember = "nombreDepartamento";
        }
    }
}
