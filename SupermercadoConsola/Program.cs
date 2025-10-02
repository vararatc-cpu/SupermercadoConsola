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
    }
}
