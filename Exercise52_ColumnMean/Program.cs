//Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

using System;
using static System.Console;

int [,] array = GetArray(5, 6);

Clear();
PrintArray(array);
WriteLine();
GetAverageColumn(array);

int[,] GetArray (int m, int n){
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            array[i, j] = new Random().Next(1,10);
        }
    }
    return array;
}

void PrintArray (int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Write($"{array[i, j]}  ");
        }
    WriteLine();
    }
}

void GetAverageColumn (int[,] array){
    Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.GetLength(1); i++){
        double average = 0;
        for (int j = 0; j < array.GetLength(0); j++){
            average += array[j, i];
        }
        Write($"{average/array.GetLength(0)}; ");
    }
}