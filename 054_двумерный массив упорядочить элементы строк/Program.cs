// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

Console.Clear();


int rows = InputNumber("Введите количество строк массива: ");
int columns = InputNumber("Введите количество столбцов массива: ");

int[,] matrix = new int[rows, columns];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
SortingRows(matrix);
PrintMatrix(matrix);

//***********************************************************************************************
void SortingRows(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1)-1; k++)
            {
                if (matr[i, k] > matr[i, k + 1])
                {
                    int temp = matr[i, k];
                    matr[i, k] = matr[i, k + 1];
                    matr[i, k + 1] = temp;
                }
            }
        }
    }
}

int InputNumber(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}