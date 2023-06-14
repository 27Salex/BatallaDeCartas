using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatallaDeCartas
{
    internal class Program
    {
        static void Main()
        {
            Baraja mazo = new Baraja();
            mazo.Barajar();

            List<Player> playerList = new List<Player>();

            for (int i = 0; i < 5; i++)
            {
                Player player = new Player(i);
                playerList.Add(player);
            }

            for (int i = 0;i < 52 / playerList.Count ;i++) 
            {
                foreach (Player player in playerList)
                {
                    player.CogerCarta(mazo);
                }
            }

            foreach (Player player in playerList)
            {
                Console.WriteLine(player.ToString());
                Console.WriteLine(" ");
            }

        }
        static void Menu()
        {
            Console.WriteLine(".------..------..------..------..------..------..------.             " +
                "\r\n|B.--. ||A.--. ||T.--. ||A.--. ||L.--. ||L.--. ||A.--. |          " +
                "\r\n| :(): || (\\/) || :/\\: || (\\/) || :/\\: || :/\\: || (\\/) |         " +
                "\r\n| ()() || :\\/: || (__) || :\\/: || (__) || (__) || :\\/: |        " +
                "\r\n| '--'B|| '--'A|| '--'T|| '--'A|| '--'L|| '--'L|| '--'A|       " +
                "\r\n`------'`------'`------'`------'`------'`------'`------'          " +
                "\r\n.------..------.     .------..------..------..------..------..------." +
                "\r\n|D.--. ||E.--. |     |C.--. ||A.--. ||R.--. ||T.--. ||A.--. ||S.--. |" +
                "\r\n| :/\\: || (\\/) |     | :/\\: || (\\/) || :(): || :/\\: || (\\/) || :/\\: |" +
                "\r\n| (__) || :\\/: |     | :\\/: || :\\/: || ()() || (__) || :\\/: || :\\/: |" +
                "\r\n| '--'D|| '--'E|     | '--'C|| '--'A|| '--'R|| '--'T|| '--'A|| '--'S|" +
                "\r\n`------'`------'     '------'`------'`------'`------'`------'`------'");

            Console.WriteLine("Bienvenido a batalla de cartas!");
            Console.WriteLine("Introduce el numero de jugadores");

            while (!int.TryParse(Console.ReadLine(), out int numDeJugadores))
            {
                Console.WriteLine("Solo se permiten numeros");
            }
        }

    }
}
