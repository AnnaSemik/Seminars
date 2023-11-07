/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/ 

// void Fill2DArray (double[,] arr)
// {
//     for (int i= 0; i < arr.GetLength(0); i++)
//     {
//         for (int j= 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(-10, 100);
//         } 
//     }
// }

// void Print2DArray (double[,] array)
// {
//         for (int i= 0; i < array.GetLength(0); i++)
//     {
//         for (int j= 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// double[,] array2D = new double[3, 4];
// Fill2DArray(array2D);
// Print2DArray(array2D);

int TakeEnteredNumber(string massage)
{
    System.Console.WriteLine(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
double[,] GetRandom2DArray(int start, int end, int row, int col)
{
    double[,] array = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().NextDouble()*(end - start) + start;
        }
    }
    return array;
}

void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(Math.Round(array[i, j], 2) + "\t");
        }
        System.Console.WriteLine();
    }
}

int userArrayR = TakeEnteredNumber("Введите количество строк: ");
int userArrayC = TakeEnteredNumber("Введите количество столбцов: ");
int userArrayStart = TakeEnteredNumber("Введите начало диапазона: ");
int userArrayEnd = TakeEnteredNumber("Введите конец диапазона: ");
double[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayR, userArrayC);
Print2DArray(user2DArray);
