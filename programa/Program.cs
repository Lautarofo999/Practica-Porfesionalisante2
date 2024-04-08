using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
class Program
{
    static void Main(string[] args)
    {
        
        TipoProducto herramienta = new TipoProducto("Herramienta");
        TipoProducto insumo = new TipoProducto("Insumo");
        TipoProducto electricidad = new TipoProducto("Electricidad");

        
        Tamaño chico = new Tamaño("Chico");
        Tamaño mediano = new Tamaño("Mediano");
        Tamaño grande = new Tamaño("Grande");


        Cliente cliente = new Cliente("12345678", "Lautaro Foss", "lau@gmail.com");


        Producto producto1 = new Producto("Martillo", herramienta, 10.50m, mediano, 20);
        Producto producto2 = new Producto("Bombilla", electricidad, 1.25m, chico, 50);

        List<(Producto, int)> productosCantidad = new List<(Producto, int)>
        {
            (producto1, 2),
            (producto2, 5)
        };
        Venta venta = new Venta(cliente, DateTime.Now, 25.75m, productosCantidad);


        Console.WriteLine("Venta:");
        Console.WriteLine($"Cliente: {venta.Cliente.Nombre}");
        Console.WriteLine($"Fecha: {venta.Fecha}");
        Console.WriteLine($"Monto Total: {venta.MontoTotal}");
        Console.WriteLine("Productos y Cantidad:");
        foreach (var item in venta.ProductosCantidad)
        {
            Console.WriteLine($"{item.Item1.Descripcion}: {item.Item2}");
        }
        

        Console.WriteLine("Producto 1:");
        Console.WriteLine($"Descripción: {producto1.Descripcion}");
        Console.WriteLine($"Tipo: {producto1.Tipo.Nombre}");
        Console.WriteLine($"Precio Unitario: {producto1.PrecioUnitario}");
        Console.WriteLine($"Tamaño: {producto1.Tamaño.Nombre}");
        Console.WriteLine($"Stock: {producto1.Stock}");

        Console.WriteLine();

        Console.WriteLine("Producto 2:");
        Console.WriteLine($"Descripción: {producto2.Descripcion}");
        Console.WriteLine($"Tipo: {producto2.Tipo.Nombre}");
        Console.WriteLine($"Precio Unitario: {producto2.PrecioUnitario}");
        Console.WriteLine($"Tamaño: {producto2.Tamaño.Nombre}");
        Console.WriteLine($"Stock: {producto2.Stock}");

        Console.ReadLine();
    }
}
