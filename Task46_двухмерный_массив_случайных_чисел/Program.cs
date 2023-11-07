/*
Задайте двумерный массив размером m × n, заполненный случайными целыми числами.
*/

// int TakeEnteredNumber(string massage)
// {
//     System.Console.WriteLine(massage);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int[,] GetRandom2DArray(int start, int end, int row, int col)
// {
//     int[,] array = new int[row, col];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             array[i, j] = new Random().Next(start, end + 1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int userArrayR = TakeEnteredNumber("Введите количество строк: ");
// int userArrayC = TakeEnteredNumber("Введите количество столбцов: ");
// int userArrayStart = TakeEnteredNumber("Введите начало диапазона: ");
// int userArrayEnd = TakeEnteredNumber("Введите конец диапазона: ");
// int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayR, userArrayC);
// Print2DArray(user2DArray);


void Fill2DArray (int[,] arr)
{
    for (int i= 0; i < arr.GetLength(0); i++)
    {
        for (int j= 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-10, 100);
        } 
    }
}

void Print2DArray (int[,] array)
{
        for (int i= 0; i < array.GetLength(0); i++)
    {
        for (int j= 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] array2D = new int[3, 4];
Fill2DArray(array2D);
Print2DArray(array2D);