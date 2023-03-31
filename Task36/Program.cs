//Task36
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 1000);
}

int SumOdd_i(int[] array)
{
    int sum=0;
    for (int i = 1; i < array.Length; i+=2)
            sum=sum+array[i];
    return sum;
}
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.Write($"[{string.Join(", ", array)}]");
Console.WriteLine($" -> {SumOdd_i(array)}");