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
    public partial class Alquileres : Form
    {
        List<Rentas> renta = new List<Rentas>();
        
        public Alquileres()
        {
            InitializeComponent();
        }

        private void Alquileres_Load(object sender, EventArgs e)
        {

        }

        private void BTingresaralquiler_Click(object sender, EventArgs e)
        {
            Rentas rentaTemp = new Rentas();

            rentaTemp.Nit = TXTnit.Text;
            rentaTemp.Nombre = TXTnombre.Text;
            rentaTemp.Direccion1 = TXTdireccion.Text;         
        }
    }
}
