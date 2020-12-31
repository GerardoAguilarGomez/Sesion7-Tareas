using System;
using System.Collections.Generic;
using System.Text;

namespace TareasObjetos
{
    class Operaciones
    {
        private int operador1;
        private int operador2;

        public Operaciones(int operador1, int operador2)
        {
            this.operador1 = operador1;
            this.operador2 = operador2;
        }

        public void Suma()
        {
            Console.WriteLine("{0}+{1}={2}",this.operador1,this.operador2,this.operador1 + this.operador2);
        }

        public void Resta()
        {
            Console.WriteLine("{0}-{1}={2}", this.operador1, this.operador2, this.operador1 - this.operador2);
        }

        public void Multi()
        {
            Console.WriteLine("{0}x{1}={2}", this.operador1, this.operador2, this.operador1 * this.operador2);
        }

        public void Divi()
        {
            Console.WriteLine("{0}/{1}={2}", this.operador1, this.operador2, this.operador1 /this.operador2);
        }
    }
}
