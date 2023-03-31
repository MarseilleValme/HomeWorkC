//Заполнение диагоналями

void InputMatrix(int[,] matrix)
{
    int count = 0;
    for (int k = 0; k < matrix.GetLength(0) + matrix.GetLength(1); k++)
        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                if (i + j == k)
                {
                    matrix[i, j] = count; count++;
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

Console.Clear();
int m = 10, n = 4;
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Console.WriteLine("Получена матрица:");
PrintMatrix(matrix);