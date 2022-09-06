// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

Console.Clear();

int[,,] matrix = new int[2, 2, 2];

FillMatrix(matrix);
PrintMatrix(matrix);

void FillMatrix(int[,,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Random rand = new Random();
                bool flag = true;
                int randomNum = 0;
                while (flag)
                {
                    randomNum = rand.Next(10, 100);
                    foreach (int item in matr)
                    {
                        if (item == randomNum)
                        {
                            flag = false;
                        }
                    }
                    if (flag == true)
                    {
                        matr[i, j, k] = randomNum;
                        flag = false;
                    }
                    else flag = true;
                }
                
            }
        }
    }
}

void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]} ({i}, {j}, {k})\t");
            }
        }
        Console.WriteLine();
    }
}
