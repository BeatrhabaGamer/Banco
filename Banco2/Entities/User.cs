namespace Banco.Entities
{
    internal class User
    {
        public static string Name { get; set; }
        public static int Id { get; set; }
        public static double Money { get; set; }
        public static double Limit { get; set; }

        public static void Reset()
        {
            Name = null;
            Id = -1;
            Money = 0.0;
            Limit = 0.0;
        }
    }
}
