/*
Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/

Console.Write("Введите номер четверти координат: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("В первой координатной четверти (x > 0) и (y > 0)");
}

else if (number == 2)
{
    Console.WriteLine("Во второй координатной четверти (x < 0) и (y > 0)");
}

else if (number == 3)
{
    Console.WriteLine("В третьей координатной четверти (x < 0) и (y < 0)");
}
else if (number == 4)
{
    Console.WriteLine("В четвертой координатной четверти (x > 0) и (y < 0)");
}
else
{
    System.Console.WriteLine("Введен неправильный номер");
}