using System;
using System.Collections.Generic;
using System.Text;

namespace TareasObjetos
{
    class Libros
    {
        private string autor;
        private string libro;
        private string ubicacion;

        public string Autor { 
            get => autor; set => autor = value; 
        }

        public string Libro
        {
            get { return this.libro; }
            set { this.libro = value; }
        }

        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
    }
}
