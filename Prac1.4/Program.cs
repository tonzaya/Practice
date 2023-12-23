class Program
{
    static int[] GenerateRandomArray(int startRange, int endRange, int count)
    {
        Random random = new Random();
        int[] array = new int[count];
        for (int i = 0; i < count; i++)
        {
            array[i] = random.Next(startRange, endRange + 1);
        }
        return array;
    }

    static void Main()
    {
        Console.Write("Введите начало диапазона: ");
        int startRange = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите конец диапазона: ");
        int endRange = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество элементов: ");
        int count = Convert.ToInt32(Console.ReadLine());

        int[] randomArray = GenerateRandomArray(startRange, endRange, count);

        Console.WriteLine("Сгенерированный массив:");
        for (int i = 0; i < randomArray.Length; i++)
        {
            Console.Write(randomArray[i] + " ");
        }
    }
}