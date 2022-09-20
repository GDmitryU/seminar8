// Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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

void SortRowsElements(int[,] array)
{
    int newrows = array.GetLength(0);
    int newcolumns = array.GetLength(1);
    int[] row = new int[newcolumns];
    for (int i = 0; i < newrows; i++)
    {
        for (int j = 0; j < newcolumns; j++)
        {
            row[j] = array[i, j];
        }
        Array.Sort(row);
        Array.Reverse(row);
        for (int j = 0; j < newcolumns; j++)
        {
            array[i, j] = row[j];
        }
    }

}


Console.Write("Введите количество строк ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int columns = int.Parse(Console.ReadLine());
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
SortRowsElements(array);
Console.WriteLine("Новый массив ");
PrintArray(array);