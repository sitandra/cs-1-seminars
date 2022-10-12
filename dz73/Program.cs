/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

void PrintCubeArray(int[,,] cube)
{
    bool newLine = false;
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                Console.Write($"{cube[i, j, k]}({i},{j},{k}) ");
                if (newLine)
                {
                    Console.WriteLine();
                    newLine = false;
                }
                else
                {
                    newLine = true;
                }
            }
        }

    }
}

int[,,] InitRandomCubeArray(int x, int y, int z, int minValue, int maxValue)
{
    if (maxValue < minValue)
    {
        (minValue, maxValue) = (maxValue, minValue);
    }
    int[,,] cubeArray = new int[x, y, z];
    int[] values = new int[x * y * z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                int value = 0;
                while (values.Contains(value))
                {
                    value = new Random().Next(minValue, maxValue + 1);
                }
                values[i * j * k] = value;
                cubeArray[i, j, k] = value;
            }
        }
    }
    return cubeArray;
}

int[,,] cubeArray = InitRandomCubeArray(2, 2, 2, 10, 99);
PrintCubeArray(cubeArray);