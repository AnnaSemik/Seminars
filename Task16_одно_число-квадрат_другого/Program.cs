/*
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого. 
*/

System.Console.WriteLine("Введите первое число: "); //cw - быстрый вызов Console.Writeline
int userNumber1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второое число: "); //cw - быстрый вызов Console.Writeline
int userNumber2 = Convert.ToInt32(Console.ReadLine());
int sq1 = userNumber2 * userNumber2;
int sq2 = userNumber1 * userNumber1;
if (sq1 == userNumber1) 
{
    System.Console.WriteLine("Первое число - квадрат второго");
}
else if (sq2 == userNumber2) 
{
    System.Console.WriteLine("Второе число - квадрат первого");
}
else Console.WriteLine("Числа не являются квадратом друг друга");
