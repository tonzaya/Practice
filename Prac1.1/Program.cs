Console.WriteLine("Массив из 10 рандомных чисел: ");
int[] array = new int[10];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next();
    Console.WriteLine(array[i]);
}

int MinNum = 0;
int MinValue = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < MinValue)    
    {
        MinValue = array[i]; 
        MinNum = i;
    }
}
Console.WriteLine($"Минимальное число: {MinValue} \t его порядковый номер: {MinNum} ");