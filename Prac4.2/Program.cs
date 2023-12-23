string pathNumsTask2 = "../../../numsTask2.txt";
string [] readumsTask2 = File.ReadAllLines(pathNumsTask2);

double [] nums;

nums = readumsTask2[0].Split(';').Select(Convert.ToDouble).ToArray();

Console.WriteLine("Массив чисел:");

double sum = 0.0;

for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] == 0)
    {
        break;
    }    
    if (nums[i] > 0) 
    {
        sum += nums[i];
    }
    Console.Write($"{nums[i]} ");
}

Console.WriteLine($"\nСумма всех чисел до 0: {sum}");