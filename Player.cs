using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaDeCartas
{
    internal class Player
    {
        private int id;
        private string name;
        List<Carta> mano;
        public List<Carta> Mano { get { return mano; } set { mano = value; } }
        public int Id { get { return id; }}
        public string Name { get { return name; }}
    }
}
