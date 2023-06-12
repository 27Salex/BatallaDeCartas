using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BatallaDeCartas
{
    internal class Carta
    {
        private char palo;
        private int valor;

        public char Palo { get { return palo; } set { palo = value; } }
        public int Valor { get { return valor; } set { valor = value; } }

        public Carta(char palo, int valor)
        {
            Palo = palo;
            Valor = valor;
        }
        public override string ToString()
        {
            return "El palo de la carta es: " + Palo + " y el numero es: " + Valor;
        }
    }
}
