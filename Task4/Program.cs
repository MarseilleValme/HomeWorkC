Console.Clear();
Console.Write("Введите 1-ое число: ");
    int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
    int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-ое число: ");
    int c = Convert.ToInt32(Console.ReadLine());
if (a == b && b == c)
    Console.WriteLine("Числа равны");
    else if (b <= a && a >= c)
        Console.WriteLine($"Максимальное {a}");
        else if (a <= c && c >= b)
            Console.WriteLine($"Максимальное {c}");
            else if (a <= b && b >= c)
                Console.WriteLine($"Максимальное {b}");
                   
