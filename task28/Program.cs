/* Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] InitMatrix(int height, int width)
{
    int[,] matrix = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}


int n = 12;
int m = 3;

int[,] matrix = InitMatrix(m, n);
PrintMatrix(matrix);