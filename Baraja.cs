using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaDeCartas
{
    internal class Baraja
    {
        List<Carta> mazo;

        public List<Carta> Mazo { get { return mazo; } set { mazo = value; } }
        public Baraja () 
        {
            Mazo = new List<Carta> ();

            for (int numeroPalo = 1; numeroPalo <= 4; numeroPalo++) 
            {
                for (int numeroCarta = 1; numeroCarta <= 13; numeroCarta++)
                {
                    Carta cartaParaAgregar = new Carta(numeroPalo,numeroCarta);
                    Mazo.Add (cartaParaAgregar);
                }
            }
        }
        public void Barajar()
        {
            List<Carta> mazoBarajado = new List<Carta> ();

            Random rand = new Random();

            for (int i = 0; i < 52; i++)
            {  
                int posAleatoria = rand.Next(0, Mazo.Count);

                mazoBarajado.Add (Mazo[posAleatoria]);
                Mazo.Remove(Mazo[posAleatoria]);

            }

            Mazo = mazoBarajado;
        }
    }
}
