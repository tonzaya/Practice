string pathNums = "../../../nums.txt";
string [] readNums = File.ReadAllLines(pathNums);

int [] numbers;
string res = ""; 

numbers = readNums[0].Split(' ').Select(int.Parse).ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 != 0)    
    {
        res = res + (Convert.ToString(numbers[i]) + " ");
    }
}

File.WriteAllText(pathNums, res);