public class Pedido
{
    public Producto Producto { get; set; }
    public int Cantidad { get; set; }

    public Pedido(Producto producto, int cantidad)
    {
        Producto = producto;
        Cantidad = cantidad;
    }

    public decimal Total()
    {
        return Producto.Precio * Cantidad;
    }
}
