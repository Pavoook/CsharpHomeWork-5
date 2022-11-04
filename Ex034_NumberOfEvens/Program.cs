// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int GetSize(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());
    while (number <= 0)
    {
        Console.WriteLine("Неверное значение. Введите целое число больше нуля:");
        number = int.Parse(Console.ReadLine());
    }
    return number;
}

int[] CreateRandomArray(int L)
{
    int[] array = new int[L];
    Random r = new Random();
    for (int i = 0; i < L; i++)
    {
        array[i] = r.Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
}

int GetNumberOfEvens(int[] array)
{
    int n = 0;
    foreach (int i in array)
    {
        if (i % 2 == 0) n ++;
    }
    return n;
}

int lengthArray = GetSize("Задайте длину массива:");
int[] collection = CreateRandomArray(lengthArray);
PrintArray(collection);
int N = GetNumberOfEvens(collection);
Console.WriteLine($"Количество четных чисел в массиве равно {N}.");
