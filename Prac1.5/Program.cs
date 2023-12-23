Console.Write("Введите строку: ");
string userInput = Console.ReadLine();

int wordCount = CountWords(userInput);
string modifiedString = AddStartAndEnd(userInput);

Console.WriteLine($"Количество слов в строке: {wordCount}");
Console.WriteLine($"Модифицированная строка: {modifiedString}");

static int CountWords(string input)
{
    string[] words = input.Split(new char[] { ' ', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
    return words.Length;
}

static string AddStartAndEnd(string input)
{
    return "Start " + input + " End";
}