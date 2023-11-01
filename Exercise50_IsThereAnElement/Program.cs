//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//1 7 -> такого числа в массиве нет

using System;
using static System.Console;

Clear();
Write("Введите номер строки: ");
int a = int.Parse(ReadLine());
Write("Введите номер столбца: ");
int b = int.Parse(ReadLine());

int [,] array = GetArray(5, 6);

PrintArray(array);
WriteLine();
FindElement(array, a, b);

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

void FindElement (int[,] array, int a, int b){
    if (a > array.GetLength(0) || b > array.GetLength(1)) WriteLine($"{a} {b} -> такого элемента нет в массиве");
    else WriteLine($"{a} {b} -> {array[a, b]}");
}