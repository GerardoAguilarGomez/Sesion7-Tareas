using System;
using System.Collections.Generic;
using System.Text;

namespace TareasObjetos
{
    class Empleados
    {
        private string nombre;
        private int sueldo;

        public Empleados(string nombre, int sueldo)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("El nombre del empleado es {0} y su sueldo es de {1} €", this.nombre, this.sueldo);
        }
        public void Impuestos()
        {
            if (this.sueldo >= 3000)
            {
                Console.WriteLine("El empleado debe pagar impuestos");
            }
            else
            {
                Console.WriteLine("El empleado no debe pagar impuestos");
            }
        }
    }
}
