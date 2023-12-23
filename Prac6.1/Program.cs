string pathWordsTask1 = "../../../wordsTask1.txt";
string [] readWordsTask1 = File.ReadAllLines(pathWordsTask1);

string [] words = new string [readWordsTask1.Length];
words = readWordsTask1[0].Split(' ').ToArray();

Console.Write("Слова с нечетным количеством букв: ");

for (int i = 0; i < words.Length; i++)
{
    string word = words[i];   
    if (word.Length % 2 != 0)
    {       
        Console.Write($"{word} ");
    }
}