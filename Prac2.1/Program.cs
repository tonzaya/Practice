int [] array = new int [100];
array[0] = 100;

for (int i = 0; i < array.Length; i++){
    if (i == 0)   
    {
        Console.Write($"{array[i]} ");
    }
    
    else
    {
        array[i] = array[i - 1] - 3;
        Console.Write($"{array[i]} ");
        
    }
}