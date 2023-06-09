using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaTelefonica.Model
{
    public class Contacto
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Telefono { get; set; }

        public string Celular { get; set; }

        public string Email { get; set; }

        public Contacto(string nombre, string apellido, string telefono, string celular, string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Celular = celular;
            Email = email;
        }
    }
}
