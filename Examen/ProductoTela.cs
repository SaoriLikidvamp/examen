using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class ProductoTela : Producto
    {
        public string Tamaño;
        public string Material;
        public string Color;

        public ProductoTela(string nombre, float precio, string tamaño, string material, string color) : base(nombre, precio)
        {
            this.Tamaño = tamaño;
            this.Material = material;
            this.Color = color;
        }
        public override string ObtenerCaracteristicas()
        {
            return $"{base.ObtenerCaracteristicas()}, Tamaño: {this.Tamaño}, Material: {this.Material}, Color: {this.Color}";
        }
    }
}
