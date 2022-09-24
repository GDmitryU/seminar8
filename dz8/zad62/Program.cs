// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

void SpiralFillArray(int columnsnew, int rowsnew)
{
int rows = rowsnew;
int columns= columnsnew;
int[,] array = new int[columns, rows];

int row = 0;
int column = 0;
int horisontal = 1;
int vertical = 0;
int directions = 0;
int lineLen = rows;

for (int i = 0; i < array.Length; i++)
{
    array[row, column] = i + 1;
    if (--lineLen == 0)
    {
        lineLen = rows * (directions % 2) + columns* ((directions + 1) % 2) - (directions / 2 - 1) - 2;
        int temp = horisontal;
        horisontal = -vertical;
        vertical = temp;
        directions++;
    }

    column += horisontal;
    row += vertical;
}
void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
             Console.Write(array[i, j].ToString("D2")+ "\t");
        }
        Console.WriteLine();
    }
}
PrintArray(array);
}
Console.Write("Введите количество строк ");
int newrows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int newcolumns = int.Parse(Console.ReadLine());
int[,] array = new int[newrows, newcolumns];
SpiralFillArray(newrows, newcolumns);
