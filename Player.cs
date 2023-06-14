using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaDeCartas
{
    internal class Player
    {
        private int playerId;
        private string name;
        List<Carta> mano;
        public List<Carta> Mano { get { return mano; } set { mano = value; } }
        public int Id { get { return playerId; }}
        public string Name { get { return name; }}

        public Player(int ID)
        {
            mano = new List<Carta>();
            playerId = ID;
        }
        public void CogerCarta(Baraja baraja)
        {
            Carta carta = baraja.Mazo[0];
            mano.Add(carta);
            baraja.QuitarCarta(carta);
        }
        public override string ToString()
        {
            string result = "";

            foreach (Carta carta in mano)
            {
                result += carta.ToString() + ",\n";
            }
            return result;
        }
    }
}
