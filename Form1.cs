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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTalquileres_Click(object sender, EventArgs e)
        {
            Form Alquileres = new Alquileres();
            Alquileres.Show();
        }

        private void BTvehiculos_Click(object sender, EventArgs e)
        {
            Form Vehiculos = new Vehiculos();
            Vehiculos.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTcargar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
