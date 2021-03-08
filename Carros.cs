using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler
{
    class Carros
    {
        String placa;
        String marca;
        String color;
        String precioporkilometros;
        DateTime fechadealquiler;
        DateTime fechadedevolucion;

        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Color { get => color; set => color = value; }
        public string Precioporkilometros { get => precioporkilometros; set => precioporkilometros = value; }
        public DateTime Fechadealquiler { get => fechadealquiler; set => fechadealquiler = value; }
        public DateTime Fechadedevolucion { get => fechadedevolucion; set => fechadedevolucion = value; }
    }
}
