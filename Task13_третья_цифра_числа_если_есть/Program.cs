/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

System.Console.WriteLine("Введите число: "); //cw - быстрый вызов Console.Writeline
int Number = Convert.ToInt32(Console.ReadLine());
int result = -1;
if (Number >= 100)
{
    while (Number > 999)
    {
        Number = Number / 10;
    }
    result = Number % 10;
}
bool check=Convert.ToBoolean(Number);
if (Number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine(result);
}

