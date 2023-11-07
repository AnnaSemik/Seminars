/*
Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] randomArray = new int[12];
for (int i = 0; i < randomArray.Length; i++)
{
        randomArray[i] = new Random().Next(1, 999);
        Console.Write(randomArray[i] + "    ");
}
System.Console.WriteLine();
int res = 0;
for (int i = 0; i < randomArray.Length; i++)
{
    if (randomArray[i] == number) res++;
}
if (res > 0) Console.Write("да");
else Console.Write("нет");
