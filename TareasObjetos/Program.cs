using System;

namespace TareasObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno A1 = new Alumno("Gerardo Aguilar Gómez", 36);
            A1.MostrarInfo();
            A1.SaberMayorEdad();
        }
    }
}
