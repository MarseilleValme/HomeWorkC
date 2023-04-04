void InputMatrix(int[,,] matrix)            //Сам бился над "неповторением" пол дня — ниасилил. 
{                                           //Нагуглил для двумерного, адаптировал под трехмерный и сократил.                                         
    bool[] used = new bool[100];
    for (int i = 0; i < matrix.GetLength(0); ++i)
        for (int j = 0; j < matrix.GetLength(1); ++j)
            for (int l = 0; l < matrix.GetLength(2); l++)
            {
                matrix[i, j, l] = new Random().Next(used.Length);
                while (used[matrix[i, j, l]])
                    matrix[i, j, l] = new Random().Next(used.Length);
                used[matrix[i, j, l]] = true;
            }
}
// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы 
// каждого элемента. Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintMatrix(int[,,] matrix)
{
    for (int x = 0; x < matrix.GetLength(0); x++)
        for (int y = 0; y < matrix.GetLength(1); y++)
        {
            for (int z = 0; z < matrix.GetLength(1); z++)
                Console.Write($"{matrix[x, z, y]}({x},{z},{y})\t");
            Console.WriteLine();
        }
}

int x = 3, y = 3, z = 3;
int[,,] m = new int[x, y, z];
InputMatrix(m);
Console.WriteLine("Получена матрица:");
PrintMatrix(m);