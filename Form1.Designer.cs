
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
            this.SuspendLayout();
            // 
            // BTalquileres
            // 
            this.BTalquileres.Location = new System.Drawing.Point(12, 32);
            this.BTalquileres.Name = "BTalquileres";
            this.BTalquileres.Size = new System.Drawing.Size(89, 43);
            this.BTalquileres.TabIndex = 0;
            this.BTalquileres.Text = "Alquileres";
            this.BTalquileres.UseVisualStyleBackColor = true;
            this.BTalquileres.Click += new System.EventHandler(this.BTalquileres_Click);
            // 
            // BTvehiculos
            // 
            this.BTvehiculos.Location = new System.Drawing.Point(134, 32);
            this.BTvehiculos.Name = "BTvehiculos";
            this.BTvehiculos.Size = new System.Drawing.Size(89, 43);
            this.BTvehiculos.TabIndex = 1;
            this.BTvehiculos.Text = "Vehiculos";
            this.BTvehiculos.UseVisualStyleBackColor = true;
            this.BTvehiculos.Click += new System.EventHandler(this.BTvehiculos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 117);
            this.Controls.Add(this.BTvehiculos);
            this.Controls.Add(this.BTalquileres);
            this.Name = "Form1";
            this.Text = "ALQUILER DE AUTOS ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTalquileres;
        private System.Windows.Forms.Button BTvehiculos;
    }
}

