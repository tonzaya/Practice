string pathWordsTask2 = "../../../wordsTask2.txt";
string [] readWordsTask2 = File.ReadAllLines(pathWordsTask2);

string  words = string.Join (" ", readWordsTask2);

Console.WriteLine(words);

File.WriteAllText(pathWordsTask2, String.Join(" ", readWordsTask2));