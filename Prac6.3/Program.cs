Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
        
bool isEvenAndMultipleOfTen = false;
        
if (number % 2 == 0 && number % 10 == 0) {
    isEvenAndMultipleOfTen = true;
}
        
Console.WriteLine($"Число {number} {(isEvenAndMultipleOfTen ? "четное и кратно 10" : "не является четным и/или кратным 10")}");

