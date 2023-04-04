// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int f(int m, int n)
{
  if (n == m)
    return m;
  return f(m + 1, n) + m;
}

Console.Write("Введите начальное значение: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите конечное значение: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(m, n));