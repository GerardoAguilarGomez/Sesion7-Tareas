using System;
using System.Collections.Generic;
using System.Text;

namespace TareasObjetos
{
    class Personas7
    {
        private string nombre;
        private int edad;
        private string dni;
        private char sexo;
        private int peso;
        private float altura;

        public Personas7()
        {
            this.nombre = "";
            this.edad = 0;
            this.dni = "";
            this.sexo = 'H';
            this.peso = 0;
            this.altura = 0;
        }

        public Personas7(string n,int e,char s)
        {
            this.nombre = n;
            this.edad = e;
            this.sexo = s;
            this.dni = "";
            this.peso = 0;
            this.altura = 0;
        }

        public Personas7(string nombre, int edad, string dni, char sexo, int peso, float altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }
    }
}
