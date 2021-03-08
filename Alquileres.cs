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

            Guardar1();

            TXTnit.Text       = "";
            TXTnombre.Text    = "";
            TXTdireccion.Text = "";
        }
        private void Guardar1()
        {
            FileStream stream = new FileStream("ALquileres.txt", FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            for (int i = 0; i <renta.Count; i++)
            {
                writer.WriteLine(renta[i].Nit);
                writer.WriteLine(renta[i].Nombre);
                writer.WriteLine(renta[i].Direccion1);
            }
            writer.Close();

        }
        private void Leer1()
        {
            FileStream stream = new FileStream("Alquileres.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Rentas rentaTemp = new Rentas();

                rentaTemp.Nit = reader.ReadLine();
                rentaTemp.Nombre = reader.ReadLine();
                rentaTemp.Direccion1 = reader.ReadLine();

                renta.Add(rentaTemp);
            }
            reader.Close();
        }

    }
}
