Console.WriteLine("Введите количество строк n:");
int n = int.Parse(Console.ReadLine());
        
Console.WriteLine("Введите количество столбцов m:");
int m = int.Parse(Console.ReadLine());
        
int[,] a = new int[n, m];

Random random = new Random();
for (int i = 0; i < n; i++) {
    for (int j = 0; j < m; j++) {
        a[i, j] = random.Next(2);
    }
}

int[,] b = new int[n, m + 1];
for (int i = 0; i < n; i++) {
    int count = 0;
            
    for (int j = 0; j < m; j++) {
        b[i, j] = a[i, j];
                
        if (a[i, j] == 1) {
            count++;
        }
    }

    if (count % 2 == 0) {
        b[i, m] = 0;
    } else {
        b[i, m] = 1;
    }
}

Console.WriteLine("Исходная матрица:");
for (int i = 0; i < n; i++) {
    for (int j = 0; j < m; j++) {
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Новая матрица:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m + 1; j++)
    {
        Console.Write(b[i, j] + " ");
    }

    Console.WriteLine();
}