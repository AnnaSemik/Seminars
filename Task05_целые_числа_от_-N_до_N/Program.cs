/*
Напишите программу, котоая на вход принимает одно число (N), а на выходе показывает все целые числа от -N до N.
*/
System.Console.WriteLine("Введите число: "); //cw - быстрый вызов Console.Writeline
int N = Convert.ToInt32(Console.ReadLine());
for (int i=-N; i<=N; i++)
    Console.WriteLine(i);
