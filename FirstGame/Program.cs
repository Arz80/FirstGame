namespace FirstGame;

class Program
{
    private static Game _game = new Game();
    static void Main(string[] args)
    {
        
        while (_game.GetWinner() == Winner.None)
        {
            Console.Clear();
            PrintGame();
            Console.Write("Введите букву: ");
            char res = Console.ReadKey().KeyChar;
            _game.TurnLetter(res);


        }

        Console.Clear();
        PrintGame();
        if (_game.GetWinner() == Winner.Player)
        {
            Console.WriteLine("Победил Игрок");
        }
        else
        {
            Console.WriteLine($"Слово было - {_game.Word}");
            Console.WriteLine("Победил Компьютер");
        }

        Console.ReadKey();
    }

    static void PrintGame()
    {
        Console.WriteLine("Игра висилица");
        Console.WriteLine("Виселица");
        Console.WriteLine();
        Console.Write("Введите букву из загаданного слова. ");
        Console.WriteLine($"У вас осталось {_game.count} попыток");
        Console.WriteLine();
        Console.WriteLine($"{_game.answerWord}");


    }
}