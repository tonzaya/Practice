int[] array = new int[100];

for (int i = 0; i < array.Length; i++)
{
    array[i] = 2 * i + 1;
}

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}