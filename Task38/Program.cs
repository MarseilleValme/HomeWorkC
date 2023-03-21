void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (100 - 10) + 10, 2);
}

double DiffMaxMin(double[] array)
{
    double min=array[0];
    double max=array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<min) min=array[i];
        if (array[i]>max) max=array[i];
    }
    return max-min;
}
// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементами массива.
// [3.03 7.85 22.13 2.05 78.48] -> 76.43

Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];
InputArray(array);
Console.Write($"[{string.Join(", ", array)}]");
Console.WriteLine($" -> {DiffMaxMin(array)}");