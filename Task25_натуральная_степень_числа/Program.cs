/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
*/

System.Console.WriteLine("Введите число А: "); //cw - быстрый вызов Console.Writeline
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число В: "); //cw - быстрый вызов Console.Writeline
int secondNumber = Convert.ToInt32(Console.ReadLine());

int thirdNumber = 1;
if (secondNumber < 1)
{
    Console.Write("Число B должно быть натуральным");
}
else
{
    while (secondNumber != 0)
    {
        thirdNumber = thirdNumber * firstNumber;
        secondNumber = secondNumber - 1;
    }
    Console.Write ($"Число А в натуральной степени B равно {thirdNumber}");
}