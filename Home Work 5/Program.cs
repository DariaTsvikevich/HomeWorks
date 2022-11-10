//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int [] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int CountEven (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;
    return count;
}
Console.Write("Input number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n);
ShowArray(myArray); 

int result = CountEven(myArray);
Console.WriteLine(result);
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int FindOddSum (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
        sum += array[i];
    return sum;
}
Console.Write("Input number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);

int oddSum = FindOddSum(myArray);
Console.WriteLine($"Sum of odd elements is " + oddSum);
*/
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int FindDiff (int[] array)
{
    int result = 0;
    int min = 0;
    int max = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array [i] < min)
            min = array[i];
        if (array[i] > max)
            max = array[i];
    } 
    Console.WriteLine($"Max number = {max}; min number = {min}");
    result = max - min;
    return result;
}
Console.Write("Input number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minV = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxV = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, minV, maxV);
ShowArray(myArray);

int diff = FindDiff(myArray);
Console.WriteLine ($"Difference of maximal element and minimal element is {diff}.");
*/

