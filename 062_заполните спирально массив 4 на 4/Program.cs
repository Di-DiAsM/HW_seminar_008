// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7
Console.Clear();

int n = 4;
int[,] matrix = new int[n, n];

int num = 1;                                          // начинаем отсчет цифр
int shift = 0;                                        // сдвиг, управляет рамкой, соответственно подходит для большей квадратной матрицы

for (shift = 0; shift < n - 2; shift++)
{
    for (int i = 0 + shift; i < n - shift; i++)
    {
        matrix[0 + shift, i] = num;
        num++;
    }
    num--;                                            // убираем что бы угол не считал два раза
    for (int i = 0 + shift; i < n - shift; i++)
    {
        matrix[i, n - 1 - shift] = num;
        num++;
    }
    num--;
    for (int i = n - 1 - shift; i >= 0 + shift; i--)
    {
        matrix[n - 1 - shift, i] = num;
        num++;
    }
    num--;
    for (int i = n - 1 - shift; i >= 1 + shift; i--)
    {
        matrix[i, 0 + shift] = num;
        num++;
    }
}

PrintMatrix(matrix);

//***********************************************************************************************

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}
