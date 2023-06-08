
namespace Neptuno_prueba
{
    partial class frmClientes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.mrcFiltros = new System.Windows.Forms.GroupBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblListado = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Compania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo_Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrcFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(51, 394);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(96, 36);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(654, 394);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(96, 36);
            this.btnListar.TabIndex = 18;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // mrcFiltros
            // 
            this.mrcFiltros.Controls.Add(this.cmbPais);
            this.mrcFiltros.Controls.Add(this.cmbCiudad);
            this.mrcFiltros.Controls.Add(this.lblPais);
            this.mrcFiltros.Controls.Add(this.lblCiudad);
            this.mrcFiltros.Enabled = false;
            this.mrcFiltros.Location = new System.Drawing.Point(51, 75);
            this.mrcFiltros.Name = "mrcFiltros";
            this.mrcFiltros.Size = new System.Drawing.Size(360, 46);
            this.mrcFiltros.TabIndex = 17;
            this.mrcFiltros.TabStop = false;
            this.mrcFiltros.Text = "Filtros";
            // 
            // cmbPais
            // 
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(232, 16);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(121, 21);
            this.cmbPais.TabIndex = 11;
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(55, 16);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(121, 21);
            this.cmbCiudad.TabIndex = 10;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(194, 19);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(32, 13);
            this.lblPais.TabIndex = 9;
            this.lblPais.Text = "País:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(6, 19);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 8;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.Location = new System.Drawing.Point(300, 21);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(245, 31);
            this.lblListado.TabIndex = 16;
            this.lblListado.Text = "Listado de Clientes";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.Nombre_Compania,
            this.Nombre_Contacto,
            this.Cargo_Contacto,
            this.Direccion,
            this.Ciudad,
            this.Region,
            this.Codigo_Postal,
            this.Pais,
            this.Telefono,
            this.Fax});
            this.dgvClientes.Location = new System.Drawing.Point(51, 127);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.Size = new System.Drawing.Size(699, 252);
            this.dgvClientes.TabIndex = 15;
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "Id. de Cliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.Width = 87;
            // 
            // Nombre_Compania
            // 
            this.Nombre_Compania.HeaderText = "Nombre de compañia";
            this.Nombre_Compania.Name = "Nombre_Compania";
            this.Nombre_Compania.Width = 122;
            // 
            // Nombre_Contacto
            // 
            this.Nombre_Contacto.HeaderText = "Nombre del contacto";
            this.Nombre_Contacto.Name = "Nombre_Contacto";
            this.Nombre_Contacto.Width = 120;
            // 
            // Cargo_Contacto
            // 
            this.Cargo_Contacto.HeaderText = "Cargo del contacto";
            this.Cargo_Contacto.Name = "Cargo_Contacto";
            this.Cargo_Contacto.Width = 112;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 77;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.Width = 65;
            // 
            // Region
            // 
            this.Region.HeaderText = "Region";
            this.Region.Name = "Region";
            this.Region.Width = 66;
            // 
            // Codigo_Postal
            // 
            this.Codigo_Postal.HeaderText = "Código Postal";
            this.Codigo_Postal.Name = "Codigo_Postal";
            this.Codigo_Postal.Width = 89;
            // 
            // Pais
            // 
            this.Pais.HeaderText = "País";
            this.Pais.Name = "Pais";
            this.Pais.Width = 54;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 74;
            // 
            // Fax
            // 
            this.Fax.HeaderText = "Fax";
            this.Fax.Name = "Fax";
            this.Fax.Width = 49;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.mrcFiltros);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.dgvClientes);
            this.Name = "frmClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.mrcFiltros.ResumeLayout(false);
            this.mrcFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.GroupBox mrcFiltros;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Compania;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo_Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
    }
}

