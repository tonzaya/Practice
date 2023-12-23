string pathNumsTask3 = "../../../numsTask3.txt";
string [] readNumsTask3 = File.ReadAllLines(pathNumsTask3);

int [] nums = new int[readNumsTask3.Length];
nums = readNumsTask3[0].Split(',').Select(int.Parse).ToArray();

double maxNum = nums[0];
double minNum = nums[0];

for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}

for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] == 0)
    {
        break;
    }
    
    if (maxNum < nums[i]) 
    {
        maxNum = nums[i];
    }
    
    if (minNum > nums[i]) 
    {
        minNum = nums[i];  
        Console.WriteLine(minNum);
    }     
}

double res = minNum / maxNum;

Console.WriteLine($"Отношение минимального элемента массива к максимальному = {minNum} : {maxNum} = {res}");