// Clase abstracta base para todos los productos de la librería

using System;

abstract class Producto
{
    private string codigo;
    private string titulo;
    private double precio;
    private int stock;

    public Producto(string codigo, string titulo, double precio, int stock)
    {
        this.codigo = codigo;
        this.titulo = titulo;
        this.precio = precio;
        this.stock = stock;
    }

    public string GetCodigo() { return codigo; }
    public string GetTitulo() { return titulo; }
    public double GetPrecio() { return precio; }
    public int GetStock() { return stock; }

    public void SetStock(int stock) { this.stock = stock; }

    public abstract void MostrarInfo();
}