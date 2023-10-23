/*
Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

System.Console.WriteLine("Введите число: "); //cw - быстрый вызов Console.Writeline
int number = Convert.ToInt32(Console.ReadLine());
int sum = 1;
for (int i = 1; i<=number; i++)
{
    sum *= i;
}
Console.WriteLine(sum);
