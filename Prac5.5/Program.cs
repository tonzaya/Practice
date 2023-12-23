string pathNumsTask5 = "../../../numsTask5.txt";
string [] readNumsTask5 = File.ReadAllLines(pathNumsTask5);

int [] nums = new int[readNumsTask5.Length];
nums = readNumsTask5[0].Split(' ').Select(int.Parse).ToArray();

int maxNum = nums[0];
int minNum = nums[0];
int minIndex = 0;
int maxIndex = 0;
int sum = 0;
int res = 0;

for (int i = 0; i < nums.Length; i++)
{
    if (maxNum < nums[i])   
    {
        maxNum = nums[i];    
        maxIndex = i;
    }
    
    if (minNum > nums[i])  
    {
        minNum = nums[i];     
        minIndex = i;
    }
}
if (minIndex < maxIndex)
{    
    for (int i = minIndex + 1; i < maxIndex; i++)
    {   
        sum += nums[i];
    }
    res = sum / (maxIndex - minIndex - 1);
}

if (minIndex > maxIndex)
{ 
    for (int i = maxIndex + 1; i < minIndex; i++)
    {
        sum += nums[i];
    }
    res = sum / (minIndex - maxIndex - 1);
}
Console.WriteLine($"Среднее арифметическое элементов, расположенных между минимальным({minNum}) и максимальным ({maxNum}) числами = {res}");