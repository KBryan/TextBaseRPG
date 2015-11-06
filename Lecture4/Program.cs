using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy firstEnemy = new Enemy();
            Enemy secondEnemy = new Enemy("Enemy1", 3, true, 1);

            string myPlayerName;
            string myDecision;
            firstEnemy.enemyAttack();
            Console.WriteLine("Enter Player Name");
            myPlayerName = Console.ReadLine();
            Console.WriteLine("Welcome {0}, to our game", myPlayerName);
            Console.Read();
            Console.WriteLine("Enter cavern y / n");
            myDecision = Console.ReadLine();
           
            Console.Read();
        }
    }
}
