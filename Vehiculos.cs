using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Alquiler
{
    public partial class Vehiculos : Form
    {
        List<Carros> carros = new List<Carros>();

        public Vehiculos()
        {
            InitializeComponent();
        }

        private void Vehiculos_Load(object sender, EventArgs e)
        {

        }

        private void BTingresarvehiculo_Click(object sender, EventArgs e)
        {
            Carros carroTemp = new Carros();

            carroTemp.Placa = TXTplaca.Text;
            carroTemp.Marca = TXTmarca.Text;
            carroTemp.Color = TXTcolor.Text;
            carroTemp.Precioporkilometros = TXTprecio.Text;
            carroTemp.Fechadealquiler = FECHAalquiler.SelectionStart;
            carroTemp.Fechadedevolucion = FECHAdevolucion.SelectionStart;

            carros.Add(carroTemp);


        }
    }
}
