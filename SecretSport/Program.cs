namespace SecretSport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine());

            while (testCases-- > 0)
            {
                var totalPlays = int.Parse(Console.ReadLine());
                var plays = Console.ReadLine();
                var result = plays.Last() is 'A' ? 'A' : 'B';

                Console.WriteLine(result);
            }
        }
    }
}
