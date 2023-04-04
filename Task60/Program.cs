void InputMatrix(int[,,] matrix)
{
    int[] generated = new int[100]; //Создаём массив "флажков" под каждое двузначное число.
    generated[0] = 1;  //Переключаем нулевой флажок как точку входа в WHILE на 9-й строке
    for (int x = 0; x < matrix.GetLength(0); ++x)
        for (int y = 0; y < matrix.GetLength(1); ++y)
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                while (generated[matrix[x, y, z]] == 1)                          //Пока не попадётся ещё не переключенный флажок
                    matrix[x, y, z] = new Random().Next(10, generated.Length);   // — генерим новые числа.
                generated[matrix[x, y, z]] = 1;                                  //Помечаем ячейку с номером уже сгенерённого числа,
            }                                                                    //переключая её флажок.
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
            for (int z = 0; z < matrix.GetLength(2); z++)
                Console.Write($"{matrix[x, y, z]}({x},{y},{z})\t");
            Console.WriteLine();
        }
}

int x = 3, y = 3, z = 3;
int[,,] matrix = new int[x, y, z];
InputMatrix(matrix);
Console.WriteLine("Получена матрица:");
PrintMatrix(matrix);