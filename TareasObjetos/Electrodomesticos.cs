using System;
using System.Collections.Generic;
using System.Text;

namespace TareasObjetos
{
    class Electrodomesticos
    {
        private int precio_base;
        private string color;
        private char consumo_energetico;
        private int peso;
        string[] colores = { "blanco", "negro", "rojo", "azul", "gris" };

        public Electrodomesticos()
        {
            this.color = "Blanco";
            this.precio_base = 100;
            this.consumo_energetico = 'F';
            this.peso = 5;
            

        }

        public Electrodomesticos(int precio_base, int peso)
        {
            this.color = "Blanco";
            this.consumo_energetico = 'F';
            this.precio_base = precio_base;
            this.peso = peso;
        }

        public Electrodomesticos(int precio_base, string color, char consumo_energetico, int peso)
        {
            this.precio_base = precio_base;
            this.color = ValidarColor(color);
            this.consumo_energetico = consumo_energetico;
            this.peso = peso;
        }

        public string ValidarColor(string c)
        {
            bool saber = false;
            for(int i = 0; i <= colores.Length - 1; i++)
            {
                if (colores[i] == c)
                {
                    saber = true;
                }
            }
            if (saber == true)
            {
                return c;
            }
            else
            {
                return "Blanco";
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Precio: {0}; Color: {1}; Consumo: {2}; Peso: {3}", this.precio_base, this.color, this.consumo_energetico,this.peso);
        }
    }
}
