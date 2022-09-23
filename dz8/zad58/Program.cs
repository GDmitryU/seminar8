// Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18



void FillMatrix(int[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
}

void PrintMatrix(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void MatrixProduct(int[,] array1, int[,] array2)
{
    int row1 = array1.GetLength(0);
    int column1 = array1.GetLength(1);
    int row2 = array2.GetLength(0);
    int column2 = array2.GetLength(1);
    int[,] matrixProduct = new int[row2, column1];
    for (int k = 0; k < column2; k++)
    {
        for (int i = 0; i < row1; i++)
        {
            for (int j = 0; j < column1; j++)
            {
                matrixProduct[i, j] += array1[i, k] * array1[k, j];
            }
        }
    }
    PrintMatrix(matrixProduct);
}
Console.Write("Введите количество строк матрицы 1: ");
int rows1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы 1: ");
int columns1 = int.Parse(Console.ReadLine());
int[,] matrix1 = new int[rows1, columns1];

Console.Write("Введите количество строк матрицы 2: ");
int rows2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы 2: ");
int columns2 = int.Parse(Console.ReadLine());
int[,] matrix2 = new int[rows2, columns2];

FillMatrix(matrix1);
FillMatrix(matrix2);
Console.WriteLine(" матрица 1: ");
PrintMatrix(matrix1);
Console.WriteLine();
Console.WriteLine(" матрица 2: ");
PrintMatrix(matrix2);
Console.WriteLine();
if (rows2 == columns1)
{
    int[,] result = new int[rows2, columns1];
    Console.WriteLine("Произведение матриц :  ");
    MatrixProduct(matrix1, matrix2);
}
else
{
    Console.WriteLine(" Эти матрицы перемножить невозожно");
}
