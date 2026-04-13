// Registra y procesa la venta de un producto

using System;

class Venta
{
    private Producto producto;
    private int cantidad;
    private double total;

    public Venta(Producto producto, int cantidad)
    {
        this.producto = producto;
        this.cantidad = cantidad;
        this.total = producto.GetPrecio() * cantidad;
    }

    // Proceso la venta descontando el stock
    public void ProcesarVenta()
    {
        IVendible vendible = (IVendible)producto;
        vendible.Vender(cantidad);
    }

    // Muestro el detalle de la venta
    public void MostrarVenta()
    {
        Console.WriteLine("=== VENTA PROCESADA ===");
        Console.WriteLine($"Producto : {producto.GetTitulo()}");
        Console.WriteLine($"Cantidad : {cantidad}");
        Console.WriteLine($"Total    : RD${total:F2}");
        Console.WriteLine($"Stock restante: {producto.GetStock()}");
    }
}