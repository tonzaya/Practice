﻿Random rnd = new Random();

Dictionary<string, int[]> temp = new Dictionary<string, int[]>() 
{
    ["январь"] = new int[30],
    ["февраль"] = new int[30], 
    ["март"] = new int[30],
    ["апрель"] = new int[30],
    ["май"] = new int[30],
    ["июнь"] = new int[30],
    ["июль"] = new int[30],
    ["август"] = new int[30],
    ["сентябрь"] = new int[30],
    ["октябрь"] = new int[30],
    ["ноябрь"] = new int[30],
    ["декабрь"] = new int[30]
};

foreach (string i in temp.Keys)
{
    for (int j = 0; j < 30; j++)
    {
        if (i == "январь" || i == "февраль" || i == "декабрь")       
        {
            temp[i][j] = rnd.Next(-35, 0);
        }
        else if (i == "март" || i == "апрель" || i == "май")   
        {
            temp[i][j] = rnd.Next(0, 20);
        }
        else if (i == "июнь" || i == "июль" || i == "август")   
        {
            temp[i][j] = rnd.Next(5, 35);
        }
        else    
        {
            temp[i][j] = rnd.Next(-15, 10);
        }
    }
}

Dictionary<string, double> AverageTemperature(Dictionary<string, int[]> temperature)
{
    Dictionary<string, double> res= new Dictionary<string, double>();
    int sumVal = 0;

    foreach (string i in temperature.Keys)
    {
        for (int j = 0; j < 30; j++)
        {
            sumVal += temperature[i][j];
        }
        res[i] = Math.Round(sumVal / 30.0, 1, MidpointRounding.AwayFromZero);
        sumVal = 0;
    }

    return res;
}

Dictionary<string, double> answer = AverageTemperature(temp);

foreach (var i in answer)
{
    Console.WriteLine($"Средняя температура за {i.Key}: {i.Value}");
}