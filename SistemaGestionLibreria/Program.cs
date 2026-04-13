using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Creo el inventario con capacidad para 5 libros
        Inventario inventario = new Inventario(5);

        // Creo los libros
        Libro libro1 = new Libro("L001", "El Principito", 450.00, 10, "Antoine de Saint-Exupéry", "Ficción");
        Libro libro2 = new Libro("L002", "Cien Años de Soledad", 650.00, 8, "Gabriel García Márquez", "Novela");
        Libro libro3 = new Libro("L003", "Don Quijote", 550.00, 5, "Miguel de Cervantes", "Clásico");

        // Agrego los libros al inventario
        inventario.AgregarProducto(libro1);
        inventario.AgregarProducto(libro2);
        inventario.AgregarProducto(libro3);

        // Muestro el inventario inicial
        inventario.MostrarTodo();

        Console.WriteLine();

        // Proceso una venta
        Venta venta = new Venta(libro1, 2);
        venta.ProcesarVenta();
        venta.MostrarVenta();

        Console.WriteLine();

        // Muestro el inventario actualizado
        Console.WriteLine("=== INVENTARIO ACTUALIZADO ===");
        inventario.MostrarTodo();

        Console.ReadKey();
    }
}