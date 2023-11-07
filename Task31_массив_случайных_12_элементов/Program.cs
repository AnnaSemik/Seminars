/*
Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20. 
*/

int[] randomArray = new int[12];
for (int i = 0; i < 12; i++)
{
        randomArray[i] = new Random().Next(-9, 9);
        Console.Write(randomArray[i] + "    ");
}
System.Console.WriteLine();

int positiveSum(int[] randomArray)
{
    int posSum = 0;
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i] > 0)
            posSum = posSum + randomArray[i];
    }
    return posSum;
}

int negativeSum(int[] randomArray)
{
    int negSum = 0;
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i] < 0)
            negSum = negSum + randomArray[i];
    }
    return negSum;
}

Console.WriteLine($"Сумма положительных чисел в массиве = {positiveSum(randomArray)}");
Console.WriteLine($"Сумма отрицательных чисел в массиве = {negativeSum(randomArray)}");