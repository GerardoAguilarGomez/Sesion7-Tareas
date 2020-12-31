using System;
using System.Collections.Generic;
using System.Text;

namespace TareasObjetos
{
    class Serie
    {
        private string titulo;
        private int num_temp;
        private bool entregado;
        private string genero;
        private string creador;

        public Serie()
        {
            this.titulo ="";
            this.num_temp = 3;
            this.entregado = false;
            this.genero = "";
            this.creador = "";
        }

        public Serie(string titulo,string creador)
        {
            this.titulo = titulo;
            this.num_temp = 3;
            this.entregado = false;
            this.genero = "";
            this.creador =creador;
        }

        public Serie(string titulo, string creador,int num_temp,string genero)
        {
            this.titulo = titulo;
            this.num_temp = num_temp;
            this.entregado = false;
            this.genero = genero;
            this.creador = creador;
        }

        public void Imprimir()
        {
            Console.WriteLine("Serie: {0}. Num Temp: {1}. Entregado: {2}. Genero: {3}. Creador: {4}", this.titulo, this.num_temp, this.entregado, this.genero, this.creador);
        }
    }
}
