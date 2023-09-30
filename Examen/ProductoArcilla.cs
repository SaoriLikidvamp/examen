using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class ProductoArcilla : Producto
    {
        public float Peso;
        public string Tamaño;
        public string Color;

        public ProductoArcilla(string nombre, float precio, float peso, string tamaño, string color): base(nombre, precio)
        {
            this.Peso = peso;
            this.Tamaño = tamaño;
            this.Color = color;
        }
        public override string ObtenerCaracteristicas()
        {
            return $"{base.ObtenerCaracteristicas()}, Peso: {this.Peso} g, Tamaño: {this.Tamaño}, Color: {this.Color}";
        }
    }
}
