﻿using System;
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
        public CatalogoArticulosForm()
        {
            InitializeComponent();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            AbrirArticuloDialog();
        }

        private void AbrirArticuloDialog()
        {
            ArticuloDialog articuloDialog = new ArticuloDialog();
            articuloDialog.ShowDialog(this);
        }
    }
}
