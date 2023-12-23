string pathNumsTask2 = "../../../numsTask2.txt";
string [] readNumsTask2 = File.ReadAllLines(pathNumsTask2);

double [] nums = new double[readNumsTask2.Length];
nums = readNumsTask2[0].Split(';').Select(Convert.ToDouble).ToArray();

Array.Sort(nums);

File.WriteAllText(pathNumsTask2, String.Join("; ", nums));