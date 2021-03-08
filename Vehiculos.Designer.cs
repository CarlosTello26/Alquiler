
namespace Alquiler
{
    partial class Vehiculos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FECHAalquiler = new System.Windows.Forms.MonthCalendar();
            this.FECHAdevolucion = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXTplaca = new System.Windows.Forms.TextBox();
            this.TXTmarca = new System.Windows.Forms.TextBox();
            this.TXTcolor = new System.Windows.Forms.TextBox();
            this.TXTprecio = new System.Windows.Forms.TextBox();
            this.BTingresarvehiculo = new System.Windows.Forms.Button();
            this.DATOSvehiculos = new System.Windows.Forms.DataGridView();
            this.BTmostrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATOSvehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio * kilometro:";
            // 
            // FECHAalquiler
            // 
            this.FECHAalquiler.Location = new System.Drawing.Point(29, 40);
            this.FECHAalquiler.Name = "FECHAalquiler";
            this.FECHAalquiler.TabIndex = 4;
            // 
            // FECHAdevolucion
            // 
            this.FECHAdevolucion.Location = new System.Drawing.Point(356, 40);
            this.FECHAdevolucion.Name = "FECHAdevolucion";
            this.FECHAdevolucion.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FECHAalquiler);
            this.groupBox1.Controls.Add(this.FECHAdevolucion);
            this.groupBox1.Location = new System.Drawing.Point(12, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 231);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fechas de ingreso y devolucion";
            // 
            // TXTplaca
            // 
            this.TXTplaca.Location = new System.Drawing.Point(120, 24);
            this.TXTplaca.Name = "TXTplaca";
            this.TXTplaca.Size = new System.Drawing.Size(141, 20);
            this.TXTplaca.TabIndex = 7;
            // 
            // TXTmarca
            // 
            this.TXTmarca.Location = new System.Drawing.Point(120, 64);
            this.TXTmarca.Name = "TXTmarca";
            this.TXTmarca.Size = new System.Drawing.Size(141, 20);
            this.TXTmarca.TabIndex = 8;
            // 
            // TXTcolor
            // 
            this.TXTcolor.Location = new System.Drawing.Point(120, 103);
            this.TXTcolor.Name = "TXTcolor";
            this.TXTcolor.Size = new System.Drawing.Size(141, 20);
            this.TXTcolor.TabIndex = 9;
            // 
            // TXTprecio
            // 
            this.TXTprecio.Location = new System.Drawing.Point(120, 143);
            this.TXTprecio.Name = "TXTprecio";
            this.TXTprecio.Size = new System.Drawing.Size(141, 20);
            this.TXTprecio.TabIndex = 10;
            // 
            // BTingresarvehiculo
            // 
            this.BTingresarvehiculo.Location = new System.Drawing.Point(12, 179);
            this.BTingresarvehiculo.Name = "BTingresarvehiculo";
            this.BTingresarvehiculo.Size = new System.Drawing.Size(113, 61);
            this.BTingresarvehiculo.TabIndex = 11;
            this.BTingresarvehiculo.Text = "Ingresar";
            this.BTingresarvehiculo.UseVisualStyleBackColor = true;
            this.BTingresarvehiculo.Click += new System.EventHandler(this.BTingresarvehiculo_Click);
            // 
            // DATOSvehiculos
            // 
            this.DATOSvehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATOSvehiculos.Location = new System.Drawing.Point(293, 12);
            this.DATOSvehiculos.Name = "DATOSvehiculos";
            this.DATOSvehiculos.Size = new System.Drawing.Size(374, 196);
            this.DATOSvehiculos.TabIndex = 12;
            // 
            // BTmostrar
            // 
            this.BTmostrar.Location = new System.Drawing.Point(148, 179);
            this.BTmostrar.Name = "BTmostrar";
            this.BTmostrar.Size = new System.Drawing.Size(113, 61);
            this.BTmostrar.TabIndex = 13;
            this.BTmostrar.Text = "Mostrar";
            this.BTmostrar.UseVisualStyleBackColor = true;
            this.BTmostrar.Click += new System.EventHandler(this.BTmostrar_Click);
            // 
            // Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 499);
            this.Controls.Add(this.BTmostrar);
            this.Controls.Add(this.DATOSvehiculos);
            this.Controls.Add(this.BTingresarvehiculo);
            this.Controls.Add(this.TXTprecio);
            this.Controls.Add(this.TXTcolor);
            this.Controls.Add(this.TXTmarca);
            this.Controls.Add(this.TXTplaca);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Vehiculos";
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.Vehiculos_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DATOSvehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar FECHAalquiler;
        private System.Windows.Forms.MonthCalendar FECHAdevolucion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXTplaca;
        private System.Windows.Forms.TextBox TXTmarca;
        private System.Windows.Forms.TextBox TXTcolor;
        private System.Windows.Forms.TextBox TXTprecio;
        private System.Windows.Forms.Button BTingresarvehiculo;
        private System.Windows.Forms.DataGridView DATOSvehiculos;
        private System.Windows.Forms.Button BTmostrar;
    }
}