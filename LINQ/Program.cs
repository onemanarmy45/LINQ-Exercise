 namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>() { "Prince of Persia: Sands of Time", "Splinter Cell" };

            videoGames.Add("Tecmo Bowl");
            videoGames.Add("Super Smash Bros");

            var orderOfGames = videoGames.OrderBy(name => name.Length);

            foreach (var game in orderOfGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}
