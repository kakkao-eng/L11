using System;
using System.Security.Policy;

namespace ConsoleApplication1
{
    public class Player: Character
    {
        public override void Attack()
        {
            GameManager.Score += 10;
            Console.WriteLine("Player");
        }
            
        
        /*private static int playerScore;

        public Player()
        {
            playerScore = 0;
        }

        public void IncreaseScore(int points)
        {
            playerScore += points;
            Console.WriteLine($"Score increased by {points}. Current Sore: {playerScore}");
        }

        public static void DisplayScore()
        {
            Console.WriteLine($"Player's Score: {playerScore}");
        }*/
        


        

    }





}
    
