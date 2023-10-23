/*
Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

System.Console.WriteLine("Введите число: "); //cw - быстрый вызов Console.Writeline
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 0; i<=number; i++)
{
    sum += i;
}
Console.WriteLine(sum);
