// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateRandomArray(int L)
{
    int[] array = new int[L];
    Random r = new Random();
    for (int i = 0; i < L; i++)
    {
        array[i] = r.Next(-100, 101);
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

int GetSumOfOddPositions(int[] array)
{
    int i = 1;
    int s = 0;
    while (i < array.Length)
    {
        s += array[i];
        i += 2;
    }
    return s;
}

int[] collection = CreateRandomArray(10);
PrintArray(collection);
int S = GetSumOfOddPositions(collection);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях, равна {S}.");
