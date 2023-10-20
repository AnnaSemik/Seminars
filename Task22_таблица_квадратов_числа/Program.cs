/*
Напишите программу, которая принимает на вход число(N) и выдаёт таблицу квадратов чисел от 1 до N.
*/

System.Console.WriteLine("Введите число: "); //cw - быстрый вызов Console.Writeline
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= number; i++)
{
    double result = Math.Pow (i, 2);
    System.Console.WriteLine(result);
}