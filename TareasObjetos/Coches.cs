using System;
using System.Collections.Generic;
using System.Text;

namespace TareasObjetos
{
    class Coches
    {
        private string marca;
        private string modelo;
        private int cilindrada;
        private double potencia;

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Cilindrada { get => cilindrada; set => cilindrada = value; }
        public double Potencia { get => potencia; set => potencia = value; }
    }
}
