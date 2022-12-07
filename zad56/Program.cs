// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

Console.Clear();
int[,] array = new int[,]{
{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4},
{5, 2, 6, 7}};

int searchLineMinimum(int[,] arr)
{
    int lineMinSum = 0;
    int sum = 1000000;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        int sumTemp = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sumTemp += arr[i, j];
        }
        if (sumTemp < sum)
        {
            sum = sumTemp;
            lineMinSum = i;
            //  Console.WriteLine($"sum={sum}, sumTemp={sumTemp}, line={lineMinSum}");
        }
        Console.WriteLine($"Sum of line {i} elements: {sumTemp} sum={sum}");
    }
    return lineMinSum + 1;
}
int line = searchLineMinimum(array);
Console.WriteLine(line);