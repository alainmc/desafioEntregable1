using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEntregable
{
    public class Usuario
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private string _contrasena;
        private string _mail;
        
        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contrasena, string mail)
        {
            this._id = id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._nombreUsuario = nombreUsuario;
            this._contrasena = contrasena;
            this._mail = mail;
        }

        public virtual void MostrarDatos()
        {
            Console.WriteLine("id: " + this._id);
            Console.WriteLine("NOMBRE: " + this._nombre);
            Console.WriteLine("APELLIDO: " + this._apellido);
            Console.WriteLine("NOMBRE DE USUARIO: " + this._nombreUsuario);
            Console.WriteLine("CONTRASENA: " + this._contrasena);
            Console.WriteLine("MAIL: " + this._mail);
        }
    }
}
