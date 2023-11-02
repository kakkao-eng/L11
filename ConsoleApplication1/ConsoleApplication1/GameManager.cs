namespace ConsoleApplication1
{
    public static class GameManager
    {
        public static int PlaterHealth { get; set; }
        public static int Score { get; set; }

        public static void ProcessEntityAttack(Character etity)
        {
            etity.Attack();
        }
    }
}