// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.Clear();
int[,] array = new int[,]{
    {1,4,7,2,},{5,9,2,3,},{8,4,2,4,}
};
int tempPosition = 0;
int tempo = 0;
int max = 0;
int count = 0;

void sortArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            tempPosition = j;
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, k] > arr[i, tempPosition])
                {
                    tempPosition = k;
                }
            }
            tempo = arr[i, j];
            arr[i, j] = arr[i, tempPosition];
            arr[i, tempPosition] = tempo;
        }
    }
}


void printArray(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j]} ");
        }
        Console.WriteLine();
    }
}
printArray(array);
sortArray(array);
Console.WriteLine();
printArray(array);