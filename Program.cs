// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив: 1+5+8/3
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] matrix = new int[3, 3];
double sum = 0;
double result = 0;
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
FillArray(matrix);
PrintArray(matrix);
for (int j = 0; j < matrix.GetLength(0); j++)
{

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sum += matrix[i, j];
    }
   
    result = sum / matrix.GetLength(1);
    result = Math.Round(result, 2);
    Console.Write(result + "- Среднее арифметическое столбца " );
    result = 0;
    sum = 0;
}
