using System;

namespace TareasObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Alumno A1 = new Alumno("Gerardo Aguilar Gómez", 36);
            A1.MostrarInfo();
            A1.SaberMayorEdad();
            */

            /*
            Empleados E1 = new Empleados("Anacleto Perez Sanchez", 3001);
            E1.MostrarInformacion();
            E1.Impuestos();
            */

            Operaciones O1 = new Operaciones(54, 23);
            O1.Suma();
            O1.Resta();
            O1.Multi();
            O1.Divi();
        }
    }
}
