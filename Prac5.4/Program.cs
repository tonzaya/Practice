string pathNumsTask4 = "../../../numsTask4.txt";
string [] readNumsTask4 = File.ReadAllLines(pathNumsTask4);

int [] nums = new int[readNumsTask4.Length];
nums = readNumsTask4[0].Split(' ').Select(int.Parse).ToArray();

int maxNum = nums[0];int sum = 0;

for (int i = 0; i < nums.Length; i++)
{
    for (int j = 0; j < nums.Length; j++)  
    {
        if (maxNum < nums[j])     
        {
            maxNum = nums[j];
        }
    }
    if ((nums[i] == maxNum + 1) || (nums[i] == maxNum - 1)) 
    {
        sum += nums[i];
    }
}

Console.WriteLine($"Сумма чисел, отличающихся от максимального({maxNum}) = {sum} ");