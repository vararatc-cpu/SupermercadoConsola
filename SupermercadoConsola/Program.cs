using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al supermercado.");
        // Lista de productos disponibles
        List<Producto> productos = new List<Producto>()
        {
            new Producto("Manzana", 0.5m),
            new Producto("Leche", 1.2m),
            new Producto("Pan", 0.8m),
            new Producto("Arroz", 2.0m),
            new Producto("Jugo", 1.5m)
        };

        // Lista para almacenar los pedidos del cliente
        List<Pedido> carrito = new List<Pedido>();

        // Aquí pondremos el menú (lo haremos en el siguiente paso)
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n--- MENÚ ---");
            Console.WriteLine("1. Mostrar productos");
            Console.WriteLine("2. Añadir producto al carrito");
            Console.WriteLine("3. Ver carrito");
            Console.WriteLine("4. Generar factura");
            Console.WriteLine("5. Salir");
            Console.Write("Elige una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    // Mostrar productos
                    for (int i = 0; i < productos.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {productos[i].Nombre} - ${productos[i].Precio}");
                    }
                    break;

                case "2":
                    // Añadir producto al carrito (lo haremos en el siguiente paso)
                    break;

                case "3":
                    // Ver carrito (lo haremos después)
                    break;

                case "4":
                    // Generar factura (lo haremos después)
                    break;

                case "5":
                    salir = true;
                    Console.WriteLine("¡Gracias por visitar el supermercado!");
                    break;

                default:
                    Console.WriteLine("Opción no válida, intenta de nuevo.");
                    break;
            }
        }
    }
}
