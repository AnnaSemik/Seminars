/*
Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m=3, n=4
0 1 2 3
1 2 3 4
2 3 4 5
*/

int TakeEnteredNumber(string massage)
{
    System.Console.WriteLine(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] GetIndex2DArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
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
int[,] user2DArray = GetIndex2DArray(userArrayR, userArrayC);
Print2DArray(user2DArray);
