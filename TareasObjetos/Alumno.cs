using System;
using System.Collections.Generic;
using System.Text;

namespace TareasObjetos
{
    class Alumno
    {
        private string nombre;
        private int edad;

        public Alumno(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("El alumno se llama {0} y tiene {1} años", this.nombre, this.edad);
        }
        public void SaberMayorEdad()
        {
            if (this.edad >= 18)
            {
                Console.WriteLine("El alumno es mayor de edad");
            }
            else
            {
                Console.WriteLine("El alumno es menor de edad");
            }
        }
    }
}
