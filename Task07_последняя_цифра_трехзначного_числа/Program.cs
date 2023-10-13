/*
Напишите программу, которая принимает на вход трехзначное число, а на выходе показывает последнюю цифру этого числа.

456 -> 6
782 -> 2
918 -> 8
*/

System.Console.WriteLine("Введите число: "); //cw - быстрый вызов Console.Writeline
int lastNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(lastNumber%10);