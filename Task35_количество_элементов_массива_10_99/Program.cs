/*
Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элемента. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int[] randomArray = new int[123];
for (int i = 0; i < randomArray.Length; i++)
{
        randomArray[i] = new Random().Next(1, 99);
        Console.Write(randomArray[i] + "    ");
}
System.Console.WriteLine();
int res = 0;
for (int i = 0; i < randomArray.Length; i++)
{
    if (Enumerable.Range(10,99).Contains(randomArray[i])) res++;
}
Console.WriteLine($"Количество = {res}");



