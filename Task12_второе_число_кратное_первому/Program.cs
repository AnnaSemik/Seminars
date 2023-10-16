/*
Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если второе число некратно первому, 
то программа выводит остаток от деления.
*/

System.Console.WriteLine("Введите первое число: "); //cw - быстрый вызов Console.Writeline
int first = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второое число: "); //cw - быстрый вызов Console.Writeline
int second = Convert.ToInt32(Console.ReadLine());
int remainder = second%first;
if (remainder==0)
{
    System.Console.WriteLine("Второе число " + second + " кратно первому числу " + first);
}
else 
{
    System.Console.WriteLine("Некратно, остаток: " + remainder);
}