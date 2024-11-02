using FCT_game__console_.Bot;
using FCT_game__console_.Game;
using FCT_game__console_.Player;
using FCT_game__console_.Menu;

namespace Game
{
    class Program
    {
        static async Task Main()
        {
            RulesPrinter.PrintRules();
            Console.Clear();

            Console.Write("Напишите своё имя: ");
            string firstPlayerName = Console.ReadLine();
            if (firstPlayerName == null) throw new ArgumentNullException(nameof(firstPlayerName) ??
                throw new ArgumentNullException($"firstPlayerName"));
            Console.Clear();

            IPlayer firstPlayer = new Player(firstPlayerName), secondPlayer = new Player("Denyux");
            IGameSettings settings = new GameSettings()
            {
                SuccessPoints = 500,
                DrawPoints = 100,
                FailurePoints = 0
            };
            IGame game = new GameTime(settings, firstPlayer, secondPlayer, gameTimeInMilliseconds: 1 * 60 * 1000);

            IDictionary<string, IBot> bots = new Dictionary<string, IBot>()
            {
                { "pc", new RandomBot(0.5d) },
                { "aa", new RandomBot(0.66d) },
                { "bb", new RandomBot(0.34d) }
            };
            IBotFactory botFactory = new BotFactory(bots);

            Random random = new();

            Console.WriteLine("Выберите игрока:");
            Console.WriteLine("\tpc: Игрок, которого выберет компьютер;");
            Console.WriteLine("\taa: Игрок A (только для 2 партии);");
            Console.WriteLine("\tbb: Игрок B (только для 2 партии);");
            Console.Write("Выбор: ");
            
            var input = Console.ReadLine();
            var bot = botFactory.GetBot(input ?? throw new ArgumentNullException(nameof(input))) ??
                throw new ArgumentNullException($"bot");
            Console.Clear();

            Console.WriteLine("Поиск игрока...");
            await Task.Delay(TimeSpan.FromSeconds(random.NextDouble() * 20));

            bool playerChoice, botChoice;
            double botTimeoutInSeconds;
            do
            {
                Console.Clear();

                Console.WriteLine($"Ваш счёт: {game.FirstPlayer.Points}");
                Console.WriteLine($"Счёт игрока {game.SecondPlayer.Name}: {game.SecondPlayer.Points}\n");

                Console.Write("Сделайте выбор: ");
                var choice = Console.ReadKey().Key;
                playerChoice = choice != ConsoleKey.D0;

                Console.WriteLine($"\n\n{game.SecondPlayer.Name} думает...");
                botTimeoutInSeconds = new Random().NextDouble() * 5;
                await Task.Delay(TimeSpan.FromSeconds(random.NextDouble() * botTimeoutInSeconds));
                botChoice = bot.GetAnswer();

            } while (game.MakeChoice(playerChoice, botChoice));

            Console.Clear();
            Console.WriteLine("ИГРА ОКОНЧЕНА!");
            Console.WriteLine($"\t{game.FirstPlayer.Name} - {game.FirstPlayer.Points}");
            Console.WriteLine($"\t{game.SecondPlayer.Name} - {game.SecondPlayer.Points}");

            Console.Write(game.FirstPlayer.Name + ": ");
            foreach (var choice in game.FirstPlayer.Choices) Console.Write(choice ? "1" : "0");
            Console.Write("\n" + game.SecondPlayer.Name + ": ");
            foreach (var choice in game.SecondPlayer.Choices) Console.Write(choice ? "1" : "0");
        }
    }
}