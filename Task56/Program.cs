// Задача 56 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.



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


int SearchMinSumInLines(int[,] matrix)
{
    int[] sumInLines = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumInLines[i] += matrix[i, j];
        }
    }

    int index = 0;
    int minSum = sumInLines[index];

    for (int i = 1; i < sumInLines.Length; i++)
    {
        if (minSum > sumInLines[i])
        {
            index = i;
            minSum = sumInLines[i];
        }
    }

    return index + 1;
}
Console.Clear();
Console.Write("Введите размеры двумерного массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.Clear();
InputMatrix(matrix);
Console.WriteLine("Заданный массив");
PrintMatrix(matrix);
SearchMinSumInLines(matrix);
Console.WriteLine("Номер строки с минимальной суммой элементов - " + SearchMinSumInLines(matrix));
