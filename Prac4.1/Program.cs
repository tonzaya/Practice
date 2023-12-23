    Console.WriteLine("Введите целое положительное число n:");
     int n = int.Parse(Console.ReadLine());


    int product = CalculateProduct(n);

    Console.WriteLine("Произведение натуральных чисел, кратных трём и не превышающих " + n + ": " + product);
    
    static int CalculateProduct(int n)
    {
        int product = 1;

        for (int i = 3; i <= n; i += 3)
        {
            product *= i;
        }

        return product;
    }
