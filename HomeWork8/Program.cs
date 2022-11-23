//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}
void Sort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int x = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = x;
                }
            }
        }
    }

}
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
Console.WriteLine();
Sort(myArray);
Show2dArray(myArray);
*/
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}
int[] Sum(int[,] array)
{
    int[] arr = new int[array.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        arr[i] = sum;
        sum = 0;
    }
    return arr;
}

int Line(int[] array)
{
    int min = array[0];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
            {
                min = array[i];
                k = i;
            }
    }
    return k;
}
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
int[] myArray2 = Sum(myArray);
Console.WriteLine($"Row with the minimal sum of elements is {Line(myArray2) + 1} line" );
*/
//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}
void Multiplication(int[,] array1, int[,] array2)
{
    int[,] array = new int[array1.GetLength(0), array2.GetLength(1)];

    if (array1.GetLength(1) != array2.GetLength(0))
    {
        Console.WriteLine("Uncorrect!");
        return;
    }

    else
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    array[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }
    }
    Show2dArray(array);
}
Console.Write("Input a number of rows first: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns first : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value first: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value first: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Input a number of rows second: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns second: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value second: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value second: ");
int max1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("First matrix:");
int[,] myArray = CreateRandom2dArray(m, n, x, max);
Show2dArray(myArray);

Console.WriteLine("Second matrix:");
int[,] myArray2 = CreateRandom2dArray(m1, n1, x1, max1);
Show2dArray(myArray2);

Console.WriteLine("Multiplication:");
Multiplication(myArray, myArray2);
*/
//Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] CreateRandom3dArray(int rows, int columns, int count, int[] array)
{
    int n = 0;
    int z = 0;
    int[,,] array2 = new int[rows, columns, count];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < count; k++)
            {
                array2[i, j, k] = array[n = new Random().Next(0, 180 - z)];
                array[n] = array[180 - z - 1];
                z++;
            }
        }

    }
    return array2;
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }

    }
}

int[] CreateRandomArray()
{
    int[] array = new int[180];
    for (int i = 0; i < 180; i++)
    {
        if (i < 90)
            array[i] = -99 + i;
        else
            array[i] = i - 80;
    }
    return array;
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of count: ");
int k = Convert.ToInt32(Console.ReadLine());
if (m * n * k > 180)
    Console.WriteLine("It is not possible to create an array with non-repeating numbers!");
else
{
    int[] myArray2 = CreateRandomArray();
    int[,,] myArray = CreateRandom3dArray(m, n, k, myArray2);
    Show3dArray(myArray);
}
*/