Random rnd = new Random();

int m = 12, d = 30;

int[,] temp = new int[m,d];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < d; j++)    
    {
        if (i == 0 || i == 1 || i == 11) 
        {
            temp[i, j] = rnd.Next(-35, 0);
        }
        else if (i == 2 || i == 3 || i == 4)
        {
            temp[i, j] = rnd.Next(0, 20);
        }
        else if (i == 5 || i == 6 || i == 7)    
        {
            temp[i, j] = rnd.Next(5, 35);
        }
        else        
        {
            temp[i, j] = rnd.Next(-15, 10);
        }
    }
}
double[] AvgTemp(int[,] temperature)
{    
    double[] avg = new double[12];
    
    double SumTemp = 0;  
    for (int i = 0; i < 12; i++)
    { 
        for (int j = 0; j < 30; j++)
        {
            SumTemp += temperature[i, j];
        }
        avg[i] = Math.Round(SumTemp / 30.0, 2, MidpointRounding.ToEven);
        SumTemp = 0;
    }
    return avg;
}
double [] averageTemperature = AvgTemp(temp);
Array.Sort(averageTemperature);

foreach (double i in averageTemperature)
{    
    Console.WriteLine($"Средняя температура : {i}");
}