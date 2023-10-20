/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.*/

int InputN(string message)
{
System.Console.Write($"{message}: ");
int value;
if (int.TryParse(Console.ReadLine(), out value))
{
return value;
}
System.Console.WriteLine("Вы ввели не число");
Environment.Exit(1);
return 0;

}
int x1 = InputN ("Введите координату X точки A");
int y1 = InputN ("Введите координату Y точки A");
int x2 = InputN ("Введите координату X точки B");
int y2 = InputN ("Введите координату Y точки B");

double dis(int x1, int y1, int x2, int y2)
{
int deltax = x2 - x1;
int deltay = y2 - y1;

return Math.Sqrt(deltax*deltax+deltay*deltay);
}
System.Console.Write($"Растояние между точками A и B равно {dis(x1, y1, x2, y2):F2} ");