// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] arr1 = new int[,] { { 2, 4 }, { 3, 2 } };
int[,] arr2 = new int[,] { { 3, 4 }, { 3, 3 } };
int[,] arrResult = new int[arr1.GetLength(1), arr1.GetLength(1)];
if (arr1.GetLength(1) == arr2.GetLength(0))
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                arrResult[i, j] += arr1[i, k] * arr2[k, j];

            }

        }
    }
}
else Console.WriteLine("В данных масиивах разное количество строк и столбцов для их умножения");
for (int i = 0; i < arrResult.GetLength(0); i++)
{
    for (int j = 0; j < arrResult.GetLength(1); j++)
    {
        Console.Write($"{arrResult[i, j]} ");
    }
    Console.WriteLine();
}