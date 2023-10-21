/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int len = Length(number);
int Length(int number)
{
    int index = 0;
    while (number > 0)
    {
        number /= 10;
        index++;
    }
    return index;
}

int Sum(int number, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}
Console.Write($"Сумма цифр в числе { number } равна: { Sum(number, len)}");
