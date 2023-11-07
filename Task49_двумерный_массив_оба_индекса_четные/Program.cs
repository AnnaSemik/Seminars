/*
Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
*/

int TakeEnteredNumber(string massage)
{
    System.Console.WriteLine(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] GetRandom2DArray(int start, int end, int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(start, end + 1);
        }
    }
    return array;
}

//int[,] GetIndex2DArray(int row, int col)
// {
//     int[,] array = new int[row, col];
//     for (int i = 0; i < row; i++)
//     {
//         if (i % 2 == 0)
//         {
//             for (int j = 0; j < col; j++)
//             {
//                 if (j % 2 == 0)
//                 {
//                     array[i, j] = i + j;
//                 }
//             }
//         }
//     }
//     return array;
// }

int[,] ModifyArray (int[,] array)
{
    int [,] result = array;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) result [i, j] = (array [i, j] * array [i, j]); 
        }
    }
    return result;
}


void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int userArrayR = TakeEnteredNumber("Введите количество строк: ");
int userArrayC = TakeEnteredNumber("Введите количество столбцов: ");
int userArrayStart = TakeEnteredNumber("Введите начало диапазона: ");
int userArrayEnd = TakeEnteredNumber("Введите конец диапазона: ");

int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayR, userArrayC);

Print2DArray(user2DArray);

int[,] NewArray = ModifyArray(user2DArray);

System.Console.WriteLine();
Print2DArray(NewArray);
