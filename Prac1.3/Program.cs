{
    List<string> strings = new List<string>();

    string input;
    do
    {
        Console.Write("Введите строку (для завершения введите пустую строку): ");
        input = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(input))
        {
            strings.Add(input);
        }
    } while (!string.IsNullOrWhiteSpace(input));

    if (strings.Count > 0)
    {
        string shortest = strings[0];
        string longest = strings[0];

        foreach (string str in strings)
        {
            if (str.Length < shortest.Length)
            {
                shortest = str;
            }

            if (str.Length > longest.Length)
            {
                longest = str;
            }
        }

        Console.WriteLine("Самая короткая строка: " + shortest);
        Console.WriteLine("Самая длинная строка: " + longest);
    }
    else
    {
        Console.WriteLine("Список строк пуст.");
    }
}
