﻿// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int m = 5, count=0;
Console.WriteLine($"Введите {m} чисел");
for (int i = 0; i < m; i++)
    if (int.Parse(Console.ReadLine()!)>0) count++;
Console.WriteLine($"Пользователь ввёл {count} положительных чисел");