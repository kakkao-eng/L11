using System;

namespace ConsoleApplication1
{
    public class Enemy: Character
    {
        /*private static int enemyCount;

        public Enemy()
        {
            enemyCount = 0;
        }

        public void SpawnEnemy(int spawm)
        {
            enemyCount += spawm;
            Console.WriteLine($"An enemy has spawned! Total Enemies: {spawm}");
        }


        public void DisplayEnemyCount()
        {
            Console.WriteLine($"Total Enemies: {enemyCount}");
        }*/
        public override void Attack()
        {
            GameManager.PlaterHealth -= 10;
            Console.WriteLine("Eemy attacks with claws!");
        }
    }

    

}