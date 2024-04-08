using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Venta
    {
        public Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal MontoTotal { get; set; }
        public List<(Producto, int)> ProductosCantidad { get; set; }

        public Venta(Cliente cliente, DateTime fecha, decimal montoTotal, List<(Producto, int)> productosCantidad)
        {
            Cliente = cliente;
            Fecha = fecha;
            MontoTotal = montoTotal;
            ProductosCantidad = productosCantidad;
        }
    }
}
