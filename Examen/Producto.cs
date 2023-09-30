using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Producto
    {
        public string Nombre;
        public float Precio;

        public Producto(string nombre, float precio)
        {
            this.Nombre = nombre;
            this.Precio = precio;
        }
        public virtual string ObtenerCaracteristicas()
        {
            return $" - Nombre: {Nombre}, Precio: {Precio:C}";
        }

        public virtual float CalcularPrecio()
        {
            return Precio;
        }
    }
}
