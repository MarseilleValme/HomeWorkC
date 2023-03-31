//Миша и негатив.

void InputMatrix(string[,] matrix)
{
    int pix;
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            pix = new Random().Next(0, 2); // [0-B, 1-W]
            if (pix == 0)
                matrix[i, j] = "B";
            else matrix[i, j] = "W";
        }
}

void PrintMatrix(string[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

int WrongPixel(string[,] photo, string[,] negativ)
{
    int count = 0;
    for (int i = 0; i < photo.GetLength(0); i++)
        for (int j = 0; j < photo.GetLength(1); j++)
            if (photo[i, j] == negativ[i, j])
                count++;
    return count;
}
Console.Clear();
int m = 4, n = 5;
// int[,] matrix = new int[n, m];
string[,] negativ = new string[n, m];
string[,] photo = new string[n, m];
InputMatrix(photo);
Console.WriteLine("Исходная матрица:");
PrintMatrix(photo);
InputMatrix(negativ);
Console.WriteLine("Полученный Мишей негатив:");
PrintMatrix(negativ);
Console.WriteLine($"Неправильных пикселей: {WrongPixel(photo, negativ)}");