/*
Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

void reverse(int[] array, int size) 
{
    for (int i = 0, j = size-1; i < j; i++, j-- ) 
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

const int size = 7;
int[] array = {1, 2, 3, 4, 5, 6, 7};

    reverse(array, size);
    
    for ( int i = 0; i < size; i++ ) {
        System.Console.Write($"{array[i]}   ");
    }
    
    return 0;



