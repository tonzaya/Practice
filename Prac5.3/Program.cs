string pathNumsTask3 = "../../../numsTask3.txt";
string [] readNumsTask3 = File.ReadAllLines(pathNumsTask3);

int [] nums = new int[readNumsTask3.Length];
nums = readNumsTask3[0].Split(' ').Select(int.Parse).ToArray();

int minNum = nums[0];
int minIndex = 0;

for (int i = 0; i < nums.Length; i++)
{
    if (minNum > nums[i])
    {
        minNum = nums[i];
        minIndex = i;
    }
}

int res = 0;
int sum = 0;

for (int i = 0; i < minIndex; i++)
{ 
    sum += nums[i];
}

res = sum / minIndex;

Console.WriteLine($"Среднее арифметическое элментов расположенных до минимального: {res}");