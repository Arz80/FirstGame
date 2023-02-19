namespace FirstGame;

public enum Winner
{
    None,       //игра не закончилась
    Player,     //Выиграл игрок
    Computer,   //Выиграл компьютер
}
// Класс Game
internal class Game
{
    private string path = "words.txt";
    private string[] allWords { get; set; }

    public int count = 6;
    public string Word { get; set; }

    public string answerWord = "";


    public Game()
    {
        GetWords();
        Choiceword();
        AnswerWord();
    }

    public void AnswerWord()
    {
        foreach (var item in Word)
        {
            answerWord += "*";
        }

    }
    public Winner GetWinner()
    {
        if (answerWord == Word)
        {
            return Winner.Player;
        }
        if (answerWord != Word && count <= 0)
        {
            return Winner.Computer;
        }
        return Winner.None;
    }
    public void TurnLetter(char letter)
    {
        string temp = "";
        bool riteAnswer = true;
        //string temp = "";
        for (int i = 0; i < Word.Length; i++)
        {
            if (Word[i] == letter)
            {
                temp += Word[i];
                riteAnswer = false;
            }
            else
            {
                if (answerWord[i] == '*')
                {
                    temp += "*";
                }
                else
                {
                    temp += answerWord[i];
                }
            }

        }
        if (riteAnswer)
        {
            count--;
        }
        answerWord = temp;
    }
    private void GetWords()
    {
        allWords = File.ReadAllLines(path);
    }

    private void Choiceword()
    {
        Random rand = new Random();
        int countOfWords = allWords.Length;
        int indexword = rand.Next(countOfWords);

        Word = allWords[indexword];
    }

}