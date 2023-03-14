int cell = 1000;      // Задаём размер элементов массива (кол-во ягод на кусте)
int len_a = 10;       // Задаём длинну исходного массива (кол-во кустов на грядке)
int[] a = new int[len_a];

Console.WriteLine("Исходный массив");
for (int i = 0; i < len_a; i++)     // Создаём исходный массив
{
    a[i] = new Random().Next(1, cell);
    Console.Write($"{a[i]}, ");
}
Console.WriteLine();

int len_b = len_a + 2;
int[] b = new int[len_b];
Console.WriteLine("Увеличенный массив");
for (int i = 0; i < len_b; i++)     // Копируем исходный массив в увеличенный, добавляя 1-й и 2-й элементы в конец
{
    if (i < len_a)
        b[i] = a[i];
    else b[i] = a[i - len_a];
    Console.Write($"{b[i]}, ");
}
Console.WriteLine();
int sum = 0;
int maxsum = sum;
Console.WriteLine("Суммы 3-х соседних");
for (int i = 1; i < len_b - 1; i++)     // находим макс.сумму 3-х соседних элементов
{
    sum = b[i - 1] + b[i] + b[i + 1];
    if (sum > maxsum)
        maxsum = sum;
    Console.Write($"Сумма {sum}, ");
}
Console.WriteLine();
Console.WriteLine($"За 1 заход, робот соберёт максимум {maxsum} ягод.");