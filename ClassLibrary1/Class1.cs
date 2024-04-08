using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibrary1
{
    public class Producto
    {
        public string Descripcion { get; set; }
        public TipoProducto Tipo { get; set; }
        public decimal PrecioUnitario { get; set; }
        public Tamaño Tamaño { get; set; }
        public int Stock { get; set; }

        public Producto(string descripcion, TipoProducto tipo, decimal precioUnitario, Tamaño tamaño, int stock)
        {
            Descripcion = descripcion;
            Tipo = tipo;
            PrecioUnitario = precioUnitario;
            Tamaño = tamaño;
            Stock = stock;
        }
    }
}