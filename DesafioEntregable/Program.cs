using DesafioEntregable;
using System;

class Program
{
    static void Main(string[] args)
    {
        Usuario Usuario1 = new Usuario ("A2323", 2545225, "Hugo Mansilla", "Uruguay 444");

        Producto Producto1 = new Producto("A2323", 2545225, "Hugo Mansilla", "Uruguay 444");

        ProductoVendido ProductoVendido1 = new ProductoVendido("A2323", 2545225, "Hugo Mansilla", "Uruguay 444");

        Venta Venta1 = new Venta("A2323", 2545225, "Hugo Mansilla", "Uruguay 444");

        
        // Estudiante estudiante2 = persona1;  NO SE PUEDE ASIGNAR UN PADRE A SU HIJO

        Usuario1.MostrarDatos();
        Producto1.MostrarDatos();
        ProductoVendido1.MostrarDatos();
        Venta1.MostrarDatos();

        Console.WriteLine();
    }
}