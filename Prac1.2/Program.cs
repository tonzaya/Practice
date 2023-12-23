{
List<int> numbers = new List<int>();
        
int input;
do
{
    Console.Write("Введите число (для завершения введите 0): ");
    input = Convert.ToInt32(Console.ReadLine());
    if (input != 0)
    {
        numbers.Add(input);
    }
} while (input != 0);

int sum = 0;
int product = 1;
foreach (int number in numbers)
{
    sum += number;
    product *= number;
}

double average = (double)sum / numbers.Count;

Console.WriteLine("Сумма всех элементов: " + sum);
Console.WriteLine("Произведение всех элементов: " + product);
Console.WriteLine("Среднее значение всех элементов: " + average);
    }
