Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
// Интерполяция строк
// Console.WriteLine($"Результат {a} + {b} = {a + b}");
// Console.WriteLine("Результат " + a + " + " + b + " = " + (a + b));
// Console.WriteLine(a > b);
if (a > b)
    Console.WriteLine(a);
else if (a < b)
    Console.WriteLine(b);
else
    Console.WriteLine("=");
