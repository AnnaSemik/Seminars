/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

System.Console.WriteLine("Введите число: "); //cw - быстрый вызов Console.Writeline
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber == 1)
    Console.WriteLine("Нет");
if (dayNumber == 2)
    Console.WriteLine("Нет");
if (dayNumber == 3)
    Console.WriteLine("Нет");
if (dayNumber == 4)
    Console.WriteLine("Нет");
if (dayNumber == 5)
    Console.WriteLine("Нет");
if (dayNumber == 6)
    Console.WriteLine("Да");
if (dayNumber == 7)
    Console.WriteLine("Да");
if (dayNumber > 7)
    Console.WriteLine("Такого дня недели нет:)");
if (dayNumber == 0)
    Console.WriteLine("Такого дня недели нет:)");
