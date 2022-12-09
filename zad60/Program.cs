// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.Clear();
int[,,] array = new int[2, 2, 2];

bool examination(int el, int[,,] arr)
{
    bool result = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (el == arr[i, j, k]) result = true;
            }
        }
    }
    return result;
}

int madeEl()
{
    int elem = new Random().Next(10, 99);
    bool checkNow = examination(elem, array);
    if (checkNow == true) madeEl();
    return elem;
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
            array[i, j, k] = madeEl();
    }
}

void printArray(int[,,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            for (int k = 0; k < mas.GetLength(2); k++)
            {
                Console.Write($"{mas[i, j, k]} (index)[{i}, {j} ,{k}]");
            }
            Console.WriteLine();
        }
    }
}
printArray(array);