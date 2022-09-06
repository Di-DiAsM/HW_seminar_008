// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int rows = InputNumber("Введите количество строк массива: ");
int columns = InputNumber("Введите количество столбцов массива: ");

int[,] matrix = new int[rows, columns];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
RowMinSumNum(matrix);


//***********************************************************************************************

void RowMinSumNum(int[,] matr)
{
    int sum = 0;
    int numRow = 0;
    int minSum = int.MaxValue;                               // пришлось погуглить что бы прописать максимальное значение переменной и не было типо 1000000000
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matr[i, j];
        }
        Console.WriteLine($"Сумма {i+1} строки = {sum}");  // проверял суммы строк
        if(sum < minSum)
        {
            minSum = sum;
            numRow = i+1;
        }
        sum = 0;                                            // пока не обнулил не понимал почему не правильно считает строки
    }
    Console.WriteLine($"Cтрока под номером: {numRow} с наименьшей суммой элементов равной: {minSum}");
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