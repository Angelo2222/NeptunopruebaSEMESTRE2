
namespace Neptuno_prueba
{
    partial class frmMenu
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.mrcConsultas = new System.Windows.Forms.GroupBox();
            this.btnListadoClientes = new System.Windows.Forms.Button();
            this.btnTablas = new System.Windows.Forms.Button();
            this.mrcConsultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 285);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // mrcConsultas
            // 
            this.mrcConsultas.Controls.Add(this.btnListadoClientes);
            this.mrcConsultas.Controls.Add(this.btnTablas);
            this.mrcConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcConsultas.Location = new System.Drawing.Point(12, 12);
            this.mrcConsultas.Name = "mrcConsultas";
            this.mrcConsultas.Size = new System.Drawing.Size(303, 267);
            this.mrcConsultas.TabIndex = 12;
            this.mrcConsultas.TabStop = false;
            this.mrcConsultas.Text = "Consultas";
            // 
            // btnListadoClientes
            // 
            this.btnListadoClientes.Location = new System.Drawing.Point(37, 99);
            this.btnListadoClientes.Name = "btnListadoClientes";
            this.btnListadoClientes.Size = new System.Drawing.Size(99, 46);
            this.btnListadoClientes.TabIndex = 12;
            this.btnListadoClientes.Text = "Listado de Clientes";
            this.btnListadoClientes.UseVisualStyleBackColor = true;
            // 
            // btnTablas
            // 
            this.btnTablas.Location = new System.Drawing.Point(155, 99);
            this.btnTablas.Name = "btnTablas";
            this.btnTablas.Size = new System.Drawing.Size(99, 46);
            this.btnTablas.TabIndex = 13;
            this.btnTablas.Text = "Tablas";
            this.btnTablas.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 311);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mrcConsultas);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.mrcConsultas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox mrcConsultas;
        private System.Windows.Forms.Button btnListadoClientes;
        private System.Windows.Forms.Button btnTablas;
    }
}