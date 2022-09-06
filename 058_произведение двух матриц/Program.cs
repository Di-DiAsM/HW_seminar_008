// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49


Console.Clear();


int rows = InputNumber("Введите количество строк для 2х массивов: ");
int columns = InputNumber("Введите количество столбцов для 2х массивов: ");
Console.WriteLine();

int[,] matrix = new int[rows, columns];
int[,] matrix2 = new int[rows, columns];
int[,] result = new int[rows, columns];

FillMatrix(matrix);
FillMatrix(matrix2);

PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
MultiPlyMatrix(matrix, matrix2);



//***********************************************************************************************

void MultiPlyMatrix(int[,] matr, int[,] matr2)
{
    result = new int[rows, columns];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            result[i, j] += matr[i, j] * matr2[i, j];
        }
    }
    PrintMatrix(result);
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
            matr[i, j] = new Random().Next(1, 5);
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