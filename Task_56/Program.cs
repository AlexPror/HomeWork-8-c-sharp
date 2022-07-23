/* Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.Clear();

int[,] FillMatrixRndInt(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write(array[i, j] + ",");
            else Console.Write(array[i, j] + "]");
        }
        Console.WriteLine();
    }
}

void FindSumElem(int[,] array)
{
    int[] arrSum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrSum[i] += array[i, j];
        }
        Console.WriteLine($"Сумма элементов строк: {arrSum[i]}");
    }
}

int FindMinElem(int[] arrSum)
{
    int position = 0;
    int minSum = arrSum[0];
    for (int i = 0; i < arrSum.Length; i++)
    {
        if (arrSum[i] < minSum)
        {
            position = i;
            minSum = arrSum[i];
        }
    }
    return position + 1;
}

Console.Write($"Пожалуйста, введите размерность квадратной матрицы: ");
int var = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Исходный массив: ");
int[,] array = FillMatrixRndInt(var, var);
PrintMatrix(array);
FindSumElem(array);
int[] arrSum = new int[array.GetLength(0)];
int result = FindMinElem(arrSum);
Console.WriteLine($"Номер строки с наименьшей суммой: {result}");
