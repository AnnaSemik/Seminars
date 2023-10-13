/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
System.Console.WriteLine("Введите число: "); //cw - быстрый вызов Console.Writeline
int Number = Convert.ToInt32(Console.ReadLine());
int secondNumber = Number/10;
Console.WriteLine(secondNumber%10);
