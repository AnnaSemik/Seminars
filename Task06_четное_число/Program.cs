/*
Напишите программу которая на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).
*/

System.Console.WriteLine("Введите число: "); //cw - быстрый вызов Console.Writeline
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine($"Число `{number}` чётное");
}
else Console.WriteLine($"Число `{number}` нечётное");
