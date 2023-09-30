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
                precioTotal += producto.CalcularPrecio();
            }
            return precioTotal;
        }

        public void MostrarContenido()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Contenido del carrito de compras:");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(" ");
            foreach (var producto in this.productos)
            {
                Console.WriteLine(producto.ObtenerCaracteristicas());
            }
            Console.WriteLine(" ");
            Console.WriteLine($"------ Precio Total: {this.CalcularPrecioTotal():C} ------");
            Console.WriteLine(" ");
        }
    }
}
