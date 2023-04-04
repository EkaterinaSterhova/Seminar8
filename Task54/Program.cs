// Задача 54: 
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.





void InputMatrix(int[,] matrix) //заполненение двумерного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
    }
}


void PrintMatrix(int[,] matrix)  //вывод двумерного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
       Console.WriteLine(); //пустая строка
    }
}


void SortNumberInmatrixLines(int[,] matrix) //сортировка по возрастанию
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int h = j + 1; h < matrix.GetLength(1); h++)
            {
                if (matrix[i, j] > matrix[i, h])
                {
                    int tempNumber = matrix[i, j];
                    matrix[i, j] = matrix[i, h];
                    matrix[i, h] = tempNumber;
                }
            }
        }
    }
}
Console.Clear();
Console.Write("Введите размеры двумерного массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.Clear();
InputMatrix(matrix);
Console.WriteLine("Заданный массив");
PrintMatrix(matrix);
SortNumberInmatrixLines(matrix);
Console.WriteLine("Элементы в каждой строке упорядочены по возвростанию");
PrintMatrix(matrix);