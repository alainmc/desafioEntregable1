using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEntregable
{
    public class Venta
    {
        private int _id;
        private string _comentarios;
        private int _idUsuario;

        public Venta(int id, string comentarios, int idUsuario)
        {
            this._id = id;
            this._comentarios = comentarios;
            this._idUsuario = idUsuario;
        }

        public virtual void MostrarDatos()
        {
            Console.WriteLine("id: " + this._id);
            Console.WriteLine("COMENTARIOS: " + this._comentarios);
            Console.WriteLine("ID USUARIO: " + this._idUsuario);
        }
    }
}
