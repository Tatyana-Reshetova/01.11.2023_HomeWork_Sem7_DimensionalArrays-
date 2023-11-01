// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
double[,] array = GetArray(3, 4, -10, 10);
PrintArray(array);

double[,] GetArray (int m, int n, double minValue, double maxValue){
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            array[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return array;
}

void PrintArray (double[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i, j]:f1}  ");
        }
    Console.WriteLine();
    }
}