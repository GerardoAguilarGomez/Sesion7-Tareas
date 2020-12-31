using System;
using System.Collections.Generic;
using System.Text;

namespace TareasObjetos
{
    class Password
    {
        private int longitud;
        private string contraseña;

        public Password()
        {
            this.longitud = 8;
            this.contraseña = "";
        }


        public Password(int l)
        {
            this.longitud = l;
        }

        public int Longitud { get => longitud; set => longitud = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }

        public void GenerarContraseña()
        {
            Random rdn = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
            int longitud = caracteres.Length;
            char letra;

            for (int i = 0; i < this.longitud; i++)
            {
                letra = caracteres[rdn.Next(longitud)];
                this.contraseña += letra.ToString();
            }

            Console.WriteLine("Contraseña aleatoria: {0}", this.contraseña);
        }
    }
}
