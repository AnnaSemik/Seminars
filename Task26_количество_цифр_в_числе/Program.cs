/*
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.Write("Введите число: ");
        string str = Console.ReadLine();
 
        int x = Convert.ToInt32(str);
 
        int counter = 0;
 
        while (x>0)
        {
            counter++;
            x = x / 10;
        }
 
        Console.WriteLine("Данное число содержит цифр: " + counter);