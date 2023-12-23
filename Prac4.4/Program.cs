string pathNumsTask4 = "../../../numsTask4.txt";
string [] readNumsTask4 = File.ReadAllLines(pathNumsTask4);

double [] nums = new double[readNumsTask4.Length];
nums = readNumsTask4[0].Split(' ').Select(Convert.ToDouble).ToArray();

int k = 0;
for (int i = 1; i < nums.Length; i++)
{
    if (nums[i - 1] == nums[i]) 
    {
        k += 2;
        if (i == nums.Length - 1)
        {
            break;
        } 
        if (nums[i] == nums[i + 1])  
        {
            k--;
        } 
    }
}

Console.WriteLine($"Количество одинаковых рядом стоящих чисел: {k}");