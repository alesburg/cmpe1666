using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec6Ex1
{
    internal class Program
    {

        private struct SGolfScoreType
        {
            public string _firstName;
            public string _lastName;
            public int _score;
        }
        static void Main(string[] args)
        {
            SGolfScoreType player1, player2;

            Console.Write("player1 first name: ");
            player1._firstName = Console.ReadLine();
            Console.Write("player1 last name: ");
            player1._lastName = Console.ReadLine();
            Console.Write("player1 score : ");
            int.TryParse(Console.ReadLine(),out player1._score);


            Console.Write("player2 first name: ");
            player2._firstName = Console.ReadLine();
            Console.Write("player2 last name: ");
            player2._lastName = Console.ReadLine();
            Console.Write("player2 score : ");
            int.TryParse(Console.ReadLine(), out player2._score);

            if (player1._score > player2._score)
            {
                Console.WriteLine($"{player1._firstName} {player1._lastName} has the higher score with {player1._score}");
            } else
            {
                Console.WriteLine($"{player2._firstName} {player2._lastName} has the higher score with {player2._score}");
            }
            Console.ReadKey();
        }
    }
}
