string pathNumsTask1 = "../../../numsTask1.txt";
string [] readNumsTask1 = File.ReadAllLines(pathNumsTask1);

int [] nums = new int [readNumsTask1.Length];
nums = readNumsTask1[0].Split(' ').Select(int.Parse).ToArray();

int minNum = nums[0];
int minIndex = 0;

for (int i = 0; i < nums.Length; i++)
{   
    if (minNum > nums[i])
    {      
        minNum = nums[i];
        minIndex = i;
    }
    else   
    {
        continue;
    }
}

if (minIndex != nums.Length - 1)
{
    int res = 1;
    
    for (int i = minIndex + 1; i < nums.Length; i++)
    {
        if (minIndex == nums.Length - 1)
        {           
            break;
        }
        res *= nums[i];
    }
    Console.WriteLine($"{res}"); 
}
else
{    
    int res = 0;
    Console.WriteLine($"{res}");
}