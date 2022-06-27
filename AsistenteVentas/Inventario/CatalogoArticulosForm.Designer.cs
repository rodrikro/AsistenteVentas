
namespace AsistenteVentas.Inventario
{
    partial class CatalogoArticulosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsbox_articulos = new System.Windows.Forms.ListBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbx_categoria = new System.Windows.Forms.ComboBox();
            this.cmbx_departamento = new System.Windows.Forms.ComboBox();
            this.txt_nombreArticulo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsbox_articulos
            // 
            this.lsbox_articulos.FormattingEnabled = true;
            this.lsbox_articulos.Location = new System.Drawing.Point(12, 156);
            this.lsbox_articulos.Name = "lsbox_articulos";
            this.lsbox_articulos.Size = new System.Drawing.Size(877, 316);
            this.lsbox_articulos.TabIndex = 0;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.Location = new System.Drawing.Point(6, 46);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(101, 34);
            this.btn_nuevo.TabIndex = 1;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_nuevo);
            this.groupBox1.Location = new System.Drawing.Point(637, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 91);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_buscar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbx_categoria);
            this.groupBox2.Controls.Add(this.cmbx_departamento);
            this.groupBox2.Controls.Add(this.txt_nombreArticulo);
            this.groupBox2.Location = new System.Drawing.Point(12, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 91);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(536, 47);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(70, 34);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categoría";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Departamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de Artículo";
            // 
            // cmbx_categoria
            // 
            this.cmbx_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_categoria.FormattingEnabled = true;
            this.cmbx_categoria.Location = new System.Drawing.Point(409, 52);
            this.cmbx_categoria.Name = "cmbx_categoria";
            this.cmbx_categoria.Size = new System.Drawing.Size(121, 24);
            this.cmbx_categoria.TabIndex = 2;
            // 
            // cmbx_departamento
            // 
            this.cmbx_departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_departamento.FormattingEnabled = true;
            this.cmbx_departamento.Location = new System.Drawing.Point(260, 52);
            this.cmbx_departamento.Name = "cmbx_departamento";
            this.cmbx_departamento.Size = new System.Drawing.Size(143, 24);
            this.cmbx_departamento.TabIndex = 1;
            this.cmbx_departamento.SelectedValueChanged += new System.EventHandler(this.cmbx_departamento_SelectedValueChanged);
            // 
            // txt_nombreArticulo
            // 
            this.txt_nombreArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombreArticulo.Location = new System.Drawing.Point(6, 53);
            this.txt_nombreArticulo.Name = "txt_nombreArticulo";
            this.txt_nombreArticulo.Size = new System.Drawing.Size(248, 23);
            this.txt_nombreArticulo.TabIndex = 0;
            // 
            // CatalogoArticulosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 493);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsbox_articulos);
            this.Name = "CatalogoArticulosForm";
            this.Text = "Catálogo de Artículos";
            this.Load += new System.EventHandler(this.CatalogoArticulosForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbox_articulos;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_nombreArticulo;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbx_categoria;
        private System.Windows.Forms.ComboBox cmbx_departamento;
    }
}