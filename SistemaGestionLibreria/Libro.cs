// Libro hereda de Producto e implementa IVendible

using System;

class Libro : Producto, IVendible
{
    private string autor;
    private string genero;

    public Libro(string codigo, string titulo, double precio, int stock,
                 string autor, string genero)
        : base(codigo, titulo, precio, stock)
    {
        this.autor = autor;
        this.genero = genero;
    }

    public string GetAutor() { return autor; }

    public override void MostrarInfo()
    {
        Console.WriteLine($"[{GetCodigo()}] {GetTitulo()} - {autor} | " +
                          $"Precio: RD${GetPrecio():F0} | Stock: {GetStock()}");
    }

    public void Vender(int cantidad)
    {
        if (cantidad > GetStock())
        {
            Console.WriteLine($"Stock insuficiente para: {GetTitulo()}");
            return;
        }
        SetStock(GetStock() - cantidad);
    }
}