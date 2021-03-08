
namespace Alquiler
{
    partial class Alquileres
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
            this.TXTdireccion = new System.Windows.Forms.TextBox();
            this.TXTnombre = new System.Windows.Forms.TextBox();
            this.TXTnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTingresaralquiler = new System.Windows.Forms.Button();
            this.DATOSalquileres = new System.Windows.Forms.DataGridView();
            this.BTmostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DATOSalquileres)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTdireccion
            // 
            this.TXTdireccion.Location = new System.Drawing.Point(71, 103);
            this.TXTdireccion.Name = "TXTdireccion";
            this.TXTdireccion.Size = new System.Drawing.Size(143, 20);
            this.TXTdireccion.TabIndex = 12;
            // 
            // TXTnombre
            // 
            this.TXTnombre.Location = new System.Drawing.Point(71, 58);
            this.TXTnombre.Name = "TXTnombre";
            this.TXTnombre.Size = new System.Drawing.Size(143, 20);
            this.TXTnombre.TabIndex = 11;
            // 
            // TXTnit
            // 
            this.TXTnit.Location = new System.Drawing.Point(71, 12);
            this.TXTnit.Name = "TXTnit";
            this.TXTnit.Size = new System.Drawing.Size(143, 20);
            this.TXTnit.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Direccion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombrte:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nit:";
            // 
            // BTingresaralquiler
            // 
            this.BTingresaralquiler.Location = new System.Drawing.Point(269, 37);
            this.BTingresaralquiler.Name = "BTingresaralquiler";
            this.BTingresaralquiler.Size = new System.Drawing.Size(122, 61);
            this.BTingresaralquiler.TabIndex = 14;
            this.BTingresaralquiler.Text = "Ingresar";
            this.BTingresaralquiler.UseVisualStyleBackColor = true;
            this.BTingresaralquiler.Click += new System.EventHandler(this.BTingresaralquiler_Click);
            // 
            // DATOSalquileres
            // 
            this.DATOSalquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATOSalquileres.Location = new System.Drawing.Point(13, 151);
            this.DATOSalquileres.Name = "DATOSalquileres";
            this.DATOSalquileres.Size = new System.Drawing.Size(585, 282);
            this.DATOSalquileres.TabIndex = 15;
            // 
            // BTmostrar
            // 
            this.BTmostrar.Location = new System.Drawing.Point(425, 34);
            this.BTmostrar.Name = "BTmostrar";
            this.BTmostrar.Size = new System.Drawing.Size(122, 61);
            this.BTmostrar.TabIndex = 16;
            this.BTmostrar.Text = "Mostrar";
            this.BTmostrar.UseVisualStyleBackColor = true;
            this.BTmostrar.Click += new System.EventHandler(this.BTmostrar_Click);
            // 
            // Alquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 464);
            this.Controls.Add(this.BTmostrar);
            this.Controls.Add(this.DATOSalquileres);
            this.Controls.Add(this.BTingresaralquiler);
            this.Controls.Add(this.TXTdireccion);
            this.Controls.Add(this.TXTnombre);
            this.Controls.Add(this.TXTnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Alquileres";
            this.Text = "Alquileres";
            this.Load += new System.EventHandler(this.Alquileres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DATOSalquileres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTdireccion;
        private System.Windows.Forms.TextBox TXTnombre;
        private System.Windows.Forms.TextBox TXTnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTingresaralquiler;
        private System.Windows.Forms.DataGridView DATOSalquileres;
        private System.Windows.Forms.Button BTmostrar;
    }
}