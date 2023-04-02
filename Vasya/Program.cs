Console.Clear();
int n = 10;                 // Кол-во дней
int[] a = new int[n];
int[] b = new int[n];       
int count_3=0, count_4=0;   // Счётчики троек и четверок
for (int i = 0; i < n; i++)
    a[i] = new Random().Next(1, 32);
Console.Write($"Дни уроков [{string.Join(" ", a)}]");

for (int i = 0; i < n; i++)
    if (a[i]%2!=0)
    {
        b[count_3]=a[i]; count_3++;
    } 
    else 
    {
        b[n-1-count_4]=a[i]; count_4++;
    }
Console.Write($"b [{string.Join(" ", b)}]");
Console.WriteLine();
for (int i = 0; i < count_3; i++)
    Console.Write($" {b[i]}");
Console.WriteLine();
for (int i = count_3; i < n; i++)
    Console.Write($" {b[n-1+count_3-i]}");
Console.WriteLine();
if (count_3<=count_4) Console.WriteLine("YES");
else Console.WriteLine("NO");