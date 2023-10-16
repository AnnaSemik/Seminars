/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/

System.Console.WriteLine("Введите первое число: "); //cw - быстрый вызов Console.Writeline
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите первое число: "); //cw - быстрый вызов Console.Writeline
int secondNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число: "); //cw - быстрый вызов Console.Writeline
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber && firstNumber > thirdNumber)
{
    Console.WriteLine ($"Максимальное число {firstNumber}");
}
else if (secondNumber > thirdNumber)
{
    Console.WriteLine ($"Максимальное число {secondNumber}");
}
else
{
    Console.WriteLine ($"Максимальное число {thirdNumber}");
}
