using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEntregable
{
    public class ProductoVendido
    {
        private int _id;
        private int _idProducto;
        private string _stock;
        private int _idVenta;

        public ProductoVendido(int id, int idProducto, string stock, int idVenta)
        {
            this._id = id;
            this._idProducto = idProducto;
            this._stock = stock;
            this._idVenta = idVenta;
        }

        public virtual void MostrarDatos()
        {
            Console.WriteLine("id: " + this._id);
            Console.WriteLine("ID PRODUCTO: " + this._idProducto);
            Console.WriteLine("STOCK: " + this._stock);
            Console.WriteLine("ID VENTA: " + this._idVenta);
        }
    }
}
