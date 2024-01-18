using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEntregable
{
    public class Producto
    {
        private int _id;
        private string _descripcion;
        private int _costo;
        private int _precioVenta;
        private string _stock;
        private int _idUsuario;

        public Producto(int id, string descripcion, int costo, int precioVenta, string stock, int idUsuario)
        {
            this._id = id;
            this._descripcion = descripcion;
            this._costo = costo;
            this._precioVenta = precioVenta;
            this._stock = stock;
            this._idUsuario = idUsuario;
        }

        public virtual void MostrarDatos()
        {
            Console.WriteLine("id: " + this._id);
            Console.WriteLine("DESCRIPCION: " + this._descripcion);
            Console.WriteLine("COSTO: " + this._costo);
            Console.WriteLine("PRECIO DE VENTA: " + this._precioVenta);
            Console.WriteLine("STOCK: " + this._stock);
            Console.WriteLine("ID DE USUARIO: " + this._idUsuario);
        }
    }
}
