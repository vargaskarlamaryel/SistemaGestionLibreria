// Maneja el arreglo de productos de la librería

using System;

class Inventario
{
    private Producto[] productos;
    private int total;

    public Inventario(int capacidad)
    {
        productos = new Producto[capacidad];
        total = 0;
    }

    // Agrego un producto al arreglo
    public void AgregarProducto(Producto producto)
    {
        if (total >= productos.Length)
        {
            Console.WriteLine("Inventario lleno.");
            return;
        }

        productos[total] = producto;
        total++;
    }

    // Busco un producto por su código
    public Producto BuscarProducto(string codigo)
    {
        for (int i = 0; i < total; i++)
        {
            if (productos[i].GetCodigo() == codigo)
                return productos[i];
        }

        Console.WriteLine($"Producto {codigo} no encontrado.");
        return null;
    }

    // Muestro todos los productos del inventario
    public void MostrarTodo()
    {
        Console.WriteLine("=== INVENTARIO ===");
        for (int i = 0; i < total; i++)
        {
            productos[i].MostrarInfo();
        }
    }
}