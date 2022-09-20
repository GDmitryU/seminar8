// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке 
//и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] array)
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

void PrintArray(int[,] array)
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

int CompareSumRowsElements(int[,] array)
{
    int minSumRowElements = int.MaxValue;
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int sumRowElements = 0;
    int minSumRowNumber = 0;
    for (int i = 0; i < rows; i++)
    {
        sumRowElements = 0;
        int rowIndex = i;
        for (int j = 0; j < columns; j++)
        {
            sumRowElements += array[i, j];
        }
        if (sumRowElements <= minSumRowElements)
        {
            minSumRowElements = sumRowElements;
            minSumRowNumber = rowIndex;
        }
    }
    return minSumRowNumber;
}




Console.Write("Введите количество строк ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int columns = int.Parse(Console.ReadLine());
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
int result = CompareSumRowsElements(array);
Console.WriteLine($"Индекс строки с минимальной суммой элементов = {result} ");