﻿// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

char[,] array = new char[,] { { 'a', 'b' }, { 'c', 'd' } };
// string result = CreateStringFrom2DArray(charArray);
//Console.WriteLine(array);

string result = "";

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        result += array[i, j];
    }
}
Console.WriteLine(result);