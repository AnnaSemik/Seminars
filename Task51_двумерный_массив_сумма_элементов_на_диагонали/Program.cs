/*
Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
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

int MainDiagonalSum (int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) result = result + array [i, j];
        }
    }
    return result;
}

int userArrayR = TakeEnteredNumber("Введите количество строк: ");
int userArrayC = TakeEnteredNumber("Введите количество столбцов: ");
int userArrayStart = TakeEnteredNumber("Введите начало диапазона: ");
int userArrayEnd = TakeEnteredNumber("Введите конец диапазона: ");

int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayR, userArrayC);

Print2DArray(user2DArray);

int userMainDiagSum = MainDiagonalSum(user2DArray);
System.Console.WriteLine($"Сумма элементов на главной диагонали = {userMainDiagSum}");