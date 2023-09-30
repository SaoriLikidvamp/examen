using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class CarritoCompras
    {
        private List<Producto> productos = new List<Producto>();

        public void AgregarProducto(Producto producto)
        {
            this.productos.Add(producto);
        }

        public float CalcularPrecioTotal()
        {
            float precioTotal = 0;
            foreach (var producto in this.productos)
            {
                precioTotal += (float)producto.CalcularPrecio();
            }
            return precioTotal;
        }

        public void MostrarContenido()
        {
            Console.WriteLine("Contenido del carrito de compras:");
            foreach (var producto in this.productos)
            {
                Console.WriteLine(producto.ObtenerCaracteristicas());
            }
            Console.WriteLine($"- Precio Total: {this.CalcularPrecioTotal():C}");
        }
    }
}
}
