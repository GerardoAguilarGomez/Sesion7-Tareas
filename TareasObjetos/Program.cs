﻿using System;

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

            /*
            Operaciones O1 = new Operaciones(54, 23);
            O1.Suma();
            O1.Resta();
            O1.Multi();
            O1.Divi();
            */

            /*
            Personas P1 = new Personas();
            P1.SetNombre("Gerardo");
            P1.Saludar();

            Personas p2 = new Personas();
            p2.SetNombre("Andrés");
            p2.Saludar();
            */

            /*
            Libros L1 = new Libros();
            L1.Autor="Benito Perez Galdos";
            L1.Libro="La odisea";
            L1.Ubicacion="Pasillo 3, estanteria B";
            Console.WriteLine("Libro: {0}; Autor: {1}; Pasillo: {2}",L1.Libro,L1.Autor,L1.Ubicacion);
            */

            /*
            Coches Coche1 = new Coches();
            Coche1.Marca = "Mazda";
            Coche1.Modelo = "Cx5";
            Coche1.Cilindrada = 2000;
            Coche1.Potencia = 165;
            Console.WriteLine("Coche: {0} {1} {2} cc {3} cv", Coche1.Marca,Coche1.Modelo,Coche1.Cilindrada,Coche1.Potencia);
            */

            /*
            Console.WriteLine("Indica longitud de la contraseña: ");
            string r = Console.ReadLine();
            int longi= Convert.ToInt32(r);
            Password P1 = new Password(longi);
            P1.GenerarContraseña();
            //Console.WriteLine(P1.Contraseña);
            */

            Electrodomesticos E1 = new Electrodomesticos(5000,"verde",'F',8);
            E1.Imprimir();
        }
    }
}
