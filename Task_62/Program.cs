/* Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

Console.Clear();

Console.Write("Введите число строк и столбцов двумерного массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[,] galaxyMatrix = new int[num, num];
int indexI = 0;
int indexJ = 0;
int count = 1;
while (count <= galaxyMatrix.GetLength(0) * galaxyMatrix.GetLength(1))
{
    galaxyMatrix[indexI, indexJ] = count;
    count++;
    if (indexI <= indexJ + 1 && indexI + indexJ < galaxyMatrix.GetLength(1) - 1)
        indexJ++;
    else if (indexI < indexJ && indexI + indexJ >= galaxyMatrix.GetLength(0) - 1)
        indexI++;
    else if (indexI >= indexJ && indexI + indexJ > galaxyMatrix.GetLength(1) - 1)
        indexJ--;
    else
        indexI--;
}


void PrintGalaxy(int[,] galaxy)
{
    for (int indexI = 0; indexI < galaxy.GetLength(0); indexI++)
    {
        for (int indexJ = 0; indexJ < galaxy.GetLength(1); indexJ++)
        {
            Console.Write($"{galaxy[indexI, indexJ]}" + "\t");
        }
        Console.WriteLine();
    }
}

PrintGalaxy(galaxyMatrix);



// Задача 62. Заполните спирально массив 4 на 4.
// Console.Clear();
// int n = 5;
// int[,] sqareMatrix = new int[n, n];

// int temp = 1;//  2-3-4 -5                                                0  0  1 2 3 
// int indexI = 0;   // 1                                                        0  1  2 3 4
// int indexJ = 0;  //  1-2 -3                                                   1
// while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
// {
//     sqareMatrix[indexI, indexJ] = temp;
//     temp++;
//     if (indexI <= indexJ + 1 && indexI + indexJ < sqareMatrix.GetLength(1) - 1)
//         indexJ++;
//     else if (indexI < indexJ && indexI + indexJ >= sqareMatrix.GetLength(0) - 1)
//         indexI++;
//     else if (indexI >= indexJ && indexI + indexJ > sqareMatrix.GetLength(1) - 1)
//         indexJ--;
//     else
//         indexI--;
// }
// void WriteArray(int[,] array)
// {
//     for (int indexI = 0; indexI < array.GetLength(0); indexI++)
//     {
//         for (int indexJ = 0; indexJ < array.GetLength(1); indexJ++)
//         {
//             Console.Write($" {array[indexI, indexJ]}" + "\t");
//         }

//         Console.WriteLine();
//     }
// }
// WriteArray(sqareMatrix);
