using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            CarritoCompras carrito = new CarritoCompras();
            bool continueFlag = true;

            while (continueFlag)
            {
                Console.WriteLine("¿Qué desea hacer?");
                Console.WriteLine("1. Agregar producto al carrito");
                Console.WriteLine("2. Ver contenido del carrito");
                Console.WriteLine("3. Finalizar compra");
                Console.WriteLine("4. Salir");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Agregando producto al carrito...");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine(" ");
                        Console.WriteLine("Lista de productos:");
                        Console.WriteLine("1. Producto de tela");
                        Console.WriteLine("2. Producto de arcilla");

                        int tipoProducto;
                        if (!int.TryParse(Console.ReadLine(), out tipoProducto) || (tipoProducto != 1 && tipoProducto != 2))
                        {
                            Console.WriteLine("Opción no válida. Por favor, ingrese 1 o 2.");
                            Console.WriteLine(" ");
                            continue;
                        }

                        Producto producto;
                        if (tipoProducto == 1)
                        {
                            Console.WriteLine(" ");
                            Console.Write("Nombre: ");
                            string nombre = Console.ReadLine();
                            Console.Write("Tamaño: ");
                            string tamaño = Console.ReadLine();
                            Console.Write("Material: ");
                            string material = Console.ReadLine();
                            Console.Write("Color: ");
                            string color = Console.ReadLine();
                            Console.Write("Precio: ");
                            float precio = float.Parse(Console.ReadLine());
                            Console.WriteLine(" ");
                            producto = new ProductoTela(nombre, precio, tamaño, material, color);
                        }
                        else
                        {
                            Console.WriteLine(" ");
                            Console.Write("Nombre: ");
                            string nombre = Console.ReadLine();
                            Console.Write("Peso (en gramos): ");
                            float peso = float.Parse(Console.ReadLine());
                            Console.Write("Tamaño: ");
                            string tamaño = Console.ReadLine();
                            Console.Write("Color: ");
                            string color = Console.ReadLine();
                            Console.Write("Precio: ");
                            float precio = float.Parse(Console.ReadLine());
                            Console.WriteLine(" ");
                            producto = new ProductoArcilla(nombre, precio, peso, tamaño, color);
                        }
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine("Características del producto:");
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine(" ");
                        Console.WriteLine(producto.ObtenerCaracteristicas());
                        Console.WriteLine(" ");
                        Console.Write("¿Desea añadir este producto al carrito? (S/N): ");
                        string userInput = Console.ReadLine().ToLower();

                        if (userInput == "s")
                        { 
                            carrito.AgregarProducto(producto);
                            Console.WriteLine(" ");
                            Console.WriteLine("--- Producto añadido al carrito ---");
                            Console.WriteLine(" ");
                        }
                        break;

                    case "2":
                        Console.WriteLine(" ");
                        Console.WriteLine("Mostrando contenido del carrito...");
                        Console.WriteLine(" ");
                        carrito.MostrarContenido();
                        break;

                    case "3":
                        Console.WriteLine("---------------------");
                        Console.WriteLine("Finalizando compra...");
                        Console.WriteLine("---------------------");
                        carrito.MostrarContenido();
                        Console.WriteLine(" ");
                        Console.Write("¿Desea crear un nuevo carrito de compras? (S/N): ");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        string user = Console.ReadLine().ToLower();
                        if (user == "s")
                        {
                            carrito = new CarritoCompras();
                            Console.WriteLine(" ");
                            Console.WriteLine("------------ Nuevo Carrito de compras ------------");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            Console.WriteLine("--- Gracias por su compra ---");
                            continueFlag = false;
                        }
                        break;

                    case "4":
                        Console.WriteLine("--- Saliendo del programa... ---");
                        continueFlag = false;
                        break;

                    default:
                        Console.WriteLine(" ");
                        Console.WriteLine("Opción no válida. Por favor, ingrese una opción válida.");
                        break;
                }
            }
        }
    }
}
