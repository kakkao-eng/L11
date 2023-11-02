using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Player player1 = new Player();
            Player player2 = new Player();
            Player player3 = new Player();
            
            player1.IncreaseScore(50);
            Player.DisplayScore();            
            Console.WriteLine();
            player2.IncreaseScore(30);
            player2.DisplayScore();
            Console.WriteLine();
            player3.IncreaseScore(30);*/
            /*Player.DisplayScore();*/

            /*Enemy enemy = new Enemy();
            Enemy enemy2 = new Enemy();
            
            enemy.SpawnEnemy(2);
            enemy.DisplayEnemyCount();
            
            
            enemy2.SpawnEnemy(3);
            enemy2.DisplayEnemyCount();
            */

            /*GameManager.PlaterHealth = 100;
            GameManager.Score = 0;

            List<Character> entites = new List<Character>();
            
            entites.Add(new Player());
            entites.Add(new Enemy());
            entites.Add(new Enemy());
            
            Console.WriteLine("Simulating atacks");

            foreach (var entite in entites)
            {
                GameManager.ProcessEntityAttack(entite);
            }*/

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Additon of {a} and {b} is: {Calculator.Add(a,b)}");
            Console.WriteLine($"Subtraction of {a} and {b} is: {Calculator.Subtract(a,b)}");
        }
    }
}