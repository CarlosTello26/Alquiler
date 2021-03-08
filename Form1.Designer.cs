
namespace Alquiler
{
    partial class Form1
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
            this.BTalquileres = new System.Windows.Forms.Button();
            this.BTvehiculos = new System.Windows.Forms.Button();
            this.DatosAlquileres = new System.Windows.Forms.DataGridView();
            this.Datosdelosvehiculos = new System.Windows.Forms.DataGridView();
            this.BTcargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatosAlquileres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datosdelosvehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // BTalquileres
            // 
            this.BTalquileres.Location = new System.Drawing.Point(144, 32);
            this.BTalquileres.Name = "BTalquileres";
            this.BTalquileres.Size = new System.Drawing.Size(89, 43);
            this.BTalquileres.TabIndex = 0;
            this.BTalquileres.Text = "Alquileres";
            this.BTalquileres.UseVisualStyleBackColor = true;
            this.BTalquileres.Click += new System.EventHandler(this.BTalquileres_Click);
            // 
            // BTvehiculos
            // 
            this.BTvehiculos.Location = new System.Drawing.Point(728, 32);
            this.BTvehiculos.Name = "BTvehiculos";
            this.BTvehiculos.Size = new System.Drawing.Size(89, 43);
            this.BTvehiculos.TabIndex = 1;
            this.BTvehiculos.Text = "Vehiculos";
            this.BTvehiculos.UseVisualStyleBackColor = true;
            this.BTvehiculos.Click += new System.EventHandler(this.BTvehiculos_Click);
            // 
            // DatosAlquileres
            // 
            this.DatosAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosAlquileres.Location = new System.Drawing.Point(12, 116);
            this.DatosAlquileres.Name = "DatosAlquileres";
            this.DatosAlquileres.Size = new System.Drawing.Size(464, 255);
            this.DatosAlquileres.TabIndex = 2;
            // 
            // Datosdelosvehiculos
            // 
            this.Datosdelosvehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datosdelosvehiculos.Location = new System.Drawing.Point(541, 116);
            this.Datosdelosvehiculos.Name = "Datosdelosvehiculos";
            this.Datosdelosvehiculos.Size = new System.Drawing.Size(464, 255);
            this.Datosdelosvehiculos.TabIndex = 3;
            // 
            // BTcargar
            // 
            this.BTcargar.Location = new System.Drawing.Point(430, 395);
            this.BTcargar.Name = "BTcargar";
            this.BTcargar.Size = new System.Drawing.Size(149, 61);
            this.BTcargar.TabIndex = 4;
            this.BTcargar.Text = "Cargar Archivos";
            this.BTcargar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 468);
            this.Controls.Add(this.BTcargar);
            this.Controls.Add(this.Datosdelosvehiculos);
            this.Controls.Add(this.DatosAlquileres);
            this.Controls.Add(this.BTvehiculos);
            this.Controls.Add(this.BTalquileres);
            this.Name = "Form1";
            this.Text = "ALQUILER DE AUTOS ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosAlquileres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datosdelosvehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTalquileres;
        private System.Windows.Forms.Button BTvehiculos;
        private System.Windows.Forms.DataGridView DatosAlquileres;
        private System.Windows.Forms.DataGridView Datosdelosvehiculos;
        private System.Windows.Forms.Button BTcargar;
    }
}

