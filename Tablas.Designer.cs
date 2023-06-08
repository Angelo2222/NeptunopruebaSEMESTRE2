
namespace Neptuno_prueba
{
    partial class frmTablas
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
            this.btnBaseDeDatos = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtBaseDatos = new System.Windows.Forms.TextBox();
            this.lblBaseDatos = new System.Windows.Forms.Label();
            this.lblTabla = new System.Windows.Forms.Label();
            this.dgvTablas = new System.Windows.Forms.DataGridView();
            this.cmbTablas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaseDeDatos
            // 
            this.btnBaseDeDatos.Location = new System.Drawing.Point(560, 55);
            this.btnBaseDeDatos.Name = "btnBaseDeDatos";
            this.btnBaseDeDatos.Size = new System.Drawing.Size(96, 36);
            this.btnBaseDeDatos.TabIndex = 21;
            this.btnBaseDeDatos.Text = "Seleccionar BD";
            this.btnBaseDeDatos.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(15, 376);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(96, 36);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // txtBaseDatos
            // 
            this.txtBaseDatos.Location = new System.Drawing.Point(98, 6);
            this.txtBaseDatos.Name = "txtBaseDatos";
            this.txtBaseDatos.ReadOnly = true;
            this.txtBaseDatos.Size = new System.Drawing.Size(100, 20);
            this.txtBaseDatos.TabIndex = 19;
            // 
            // lblBaseDatos
            // 
            this.lblBaseDatos.AutoSize = true;
            this.lblBaseDatos.Enabled = false;
            this.lblBaseDatos.Location = new System.Drawing.Point(12, 9);
            this.lblBaseDatos.Name = "lblBaseDatos";
            this.lblBaseDatos.Size = new System.Drawing.Size(80, 13);
            this.lblBaseDatos.TabIndex = 18;
            this.lblBaseDatos.Text = "Base de Datos:";
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Enabled = false;
            this.lblTabla.Location = new System.Drawing.Point(212, 8);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(37, 13);
            this.lblTabla.TabIndex = 17;
            this.lblTabla.Text = "Tabla:";
            // 
            // dgvTablas
            // 
            this.dgvTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablas.Location = new System.Drawing.Point(15, 55);
            this.dgvTablas.Name = "dgvTablas";
            this.dgvTablas.Size = new System.Drawing.Size(518, 306);
            this.dgvTablas.TabIndex = 16;
            // 
            // cmbTablas
            // 
            this.cmbTablas.Enabled = false;
            this.cmbTablas.FormattingEnabled = true;
            this.cmbTablas.Location = new System.Drawing.Point(255, 5);
            this.cmbTablas.Name = "cmbTablas";
            this.cmbTablas.Size = new System.Drawing.Size(121, 21);
            this.cmbTablas.TabIndex = 15;
            // 
            // frmTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 418);
            this.Controls.Add(this.btnBaseDeDatos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtBaseDatos);
            this.Controls.Add(this.lblBaseDatos);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.dgvTablas);
            this.Controls.Add(this.cmbTablas);
            this.Name = "frmTablas";
            this.Text = "Tablas";
            this.Load += new System.EventHandler(this.frmTablas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaseDeDatos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtBaseDatos;
        private System.Windows.Forms.Label lblBaseDatos;
        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.DataGridView dgvTablas;
        private System.Windows.Forms.ComboBox cmbTablas;
    }
}