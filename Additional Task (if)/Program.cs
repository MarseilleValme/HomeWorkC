int cell = 1000;      // Задаём размер элементов массива (кол-во ягод на кусте)
int n = 10;           // Задаём длинну исходного массива (кол-во кустов на грядке)
int[] a = new int[n];
for (int i = 0; i < n; i++)
    a[i] = new Random().Next(1, cell);   

int sum = 0;
int maxsum = sum;
for (int i = 1; i < n - 1; i++)
{
    sum = a[i - 1] + a[i] + a[i + 1];
    if (sum > maxsum)
        maxsum = sum;
}
if (maxsum < a[n-2]+a[n-1]+a[0])
    maxsum = a[n-2]+a[n-1]+a[0];
else if (maxsum < a[n-1]+a[0]+a[1])
         maxsum = a[n-1]+a[0]+a[1];
Console.WriteLine($"За 1 заход, робот соберёт максимум {maxsum} ягод.");