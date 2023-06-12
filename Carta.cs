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
        private string paloText;

        public char Palo { get { return palo; } set { palo = value; } }
        public int Valor { get { return valor; } set { valor = value; } }

        public Carta(int palo, int valor)
        {
            switch(palo)
            {
                case 1:
                    Palo = 'c';
                    paloText = "Corazones";
                    break;
                case 2:
                    Palo = 'd';
                    paloText = "Diamantes";
                    break;
                case 3:
                    Palo = 'p';
                    paloText = "Picas";
                    break;
                case 4:
                    Palo = 't';
                    paloText = "Tréboles";
                    break;
            }
            Valor = valor;
        }
        public override string ToString()
        {
            string valorTexto = "";
            switch (valor)
            {
                case 1:
                    valorTexto = "As";
                    break;
                case 11:
                    valorTexto = "J";
                    break;
                case 12:
                    valorTexto = "Q";
                    break;
                case 13:
                    valorTexto = "K";
                    break;
                default:
                    valorTexto = valor.ToString();
                    break;
            }
            return valorTexto + " de "  + paloText;
        }
    }
}
