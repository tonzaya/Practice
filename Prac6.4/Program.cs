Random random = new Random();
int length = random.Next(5, 10); 
double[] array = new double[length];
        
Console.WriteLine("Исходный массив:");
for (int i = 0; i < length; i++) {
    array[i] = random.NextDouble() * 20 - 10; 
    Console.Write(array[i] + " ");
}
Console.WriteLine();

double[] positiveArray = Array.FindAll(array, x => x > 0);
double[] negativeArray = Array.FindAll(array, x => x < 0);
        
Console.WriteLine("Массив из положительных элементов:");
foreach (var item in positiveArray) {
    Console.Write(item + " ");
}
Console.WriteLine();
        
Console.WriteLine("Массив из отрицательных элементов:");
foreach (var item in negativeArray) {
    Console.Write(item + " ");
}
Console.WriteLine();