//Horizontal Transposition (реверс двумерной матрицы относительно горизонтали)

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 101); // [0, 100]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void HorizontalTransposition(int[,] matrix)
{
    int box, n = matrix.GetLength(0);       // Удобства восприятия 29-й и 30-й строчек для
    for (int i = 0; i <= n / 2 - 1; i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            box = matrix[i, j];
            matrix[i, j] = matrix[n - 1 - i, j];
            matrix[n - 1 - i, j] = box;
        }
}
Console.Clear();
int m = 4, n = 5;
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Console.WriteLine("Исходная матрица:");
PrintMatrix(matrix);
HorizontalTransposition(matrix);
Console.WriteLine("Транспонированная матрица:");
PrintMatrix(matrix);