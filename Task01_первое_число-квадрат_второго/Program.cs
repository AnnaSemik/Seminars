/*
Напишите программу, которая на вход принимает два числа, и проверяет, является ли первое число квадратом второго.
*/

System.Console.WriteLine("Введите первое число: "); //cw - быстрый вызов Console.Writeline
int userNumber1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второое число: "); //cw - быстрый вызов Console.Writeline
int userNumber2 = Convert.ToInt32(Console.ReadLine());
int sq = userNumber2 * userNumber2;
bool result = sq == userNumber1;
Console.WriteLine(result);

