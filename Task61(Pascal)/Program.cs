int factorial(int n)
{
    int i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}


void ReleaseTask(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j <= (n - i); j++)
            Console.Write(" ");
        for (int j = 0; j <= i; j++)
        {
            Console.Write(" ");
            Console.Write(factorial(i) / (factorial(j) * factorial(i - j)));
        }
        Console.WriteLine();
    }
}


Console.Write("Введите количество строк треугольника Паскаля: ");
int n = 5;
Console.WriteLine();
ReleaseTask(n);