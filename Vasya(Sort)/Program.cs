Console.Clear();
int n = 20;             // Кол-во дней
int[] a = new int[n];
int box;
int count_4=0;          // Счётчик четверок

for (int i = 0; i < n; i++)
    a[i] = new Random().Next(1, 32);
Console.WriteLine($"Дни уроков [{string.Join(" ", a)}]");

for (int i = 0; i < n-count_4; i++)
{
    if (a[i]%2==0)                      //Если день чётный
    {
        box=a[i];                       //вытаскиваем его в коробку
        for (int j = i; j < n-1; j++)   
            a[j]=a[j+1];                //сдвигаем весь массив на одну позицию влево
        a[n-1]=box; count_4++; i--;     //возвращаем чётный день из коробки в конец массива,
    }                                   //обновляем счётчик четверок и возвращаем счётчик внешнего цикла на эту же позицию(?)
}
Console.Write("Дни троек [");
for (int i = 0; i < n-count_4; i++)
    Console.Write($" {a[i]}");
Console.WriteLine(" ]");

Console.Write("Дни четверок [");
for (int i = n-count_4; i < n; i++)
    Console.Write($" {a[i]}");
Console.WriteLine(" ]");

if (count_4>=n-count_4) Console.Write("YES");
else Console.Write("NO");