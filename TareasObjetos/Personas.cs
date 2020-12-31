using System;
using System.Collections.Generic;
using System.Text;

namespace TareasObjetos
{
    class Personas
    {
        private string nombre;

        public void SetNombre(string n)
        {
            this.nombre = n;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola, soy {0}", this.nombre);
        }
    }
}
