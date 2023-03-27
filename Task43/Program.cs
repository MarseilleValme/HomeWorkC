// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
double x, y, z;
Console.Write("Введите b1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите K1: ");
int k1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите b2: ");
int b2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите K2: ");
int k2 = int.Parse(Console.ReadLine()!);
x=b2-b1;
y=k1-k2;
x=x/y;
y=k1*x+b1;
Console.WriteLine($"Кординаты точки пересечения: х={x}, y={y}");

// x=(b2-b1)/(k1-k2) Почемуто выдаёт ноль (вместо -0,5). Поэтому пришлось вот так изгаляться.