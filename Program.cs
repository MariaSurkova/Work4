// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Pr (string message)
{
    System.Console.Write(messege);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int Po(int powerBase, int exponent)
{
    int Po = 1;
    for (int i = 0; i < exponent; i++)
    {
        Po *= powerBase;
    }
    return powerBase;
}
bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
        System.Console.WriteLine("Показатель")
        return false;
    }
    return true;
}

int powerBase = Pr ("Input os");
int exponent = Pr ("Input pok");
if (ValidateExponent(exponent))
{
    System.Console.WriteLine($"Number {powerBase} in st = {exponent}"
    {Po(powerBase, exponent)}");
}
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 52 -> 11
// 82 -> 10
// 9012 -> 12
int SumAllDigit(int number);
{
    int result = 0;
    while (number > 0)
    {
        result = number % 10;
        number = number / 10;
    }
    return result;
}
int number = Pr ("Input number");
System.Console.WriteLine($"Sum ower{number} = {SumAllDigit(number)}");



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]