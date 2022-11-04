// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int lengthArray = GetSize("Задайте длину массива:");
int[] collection = new int[lengthArray];
int maximum = GetBound("Задайте максимальное значение элемента массива:");
int minimum = GetBound("Задайте минимальное значение элемента массива:");
if (ValidateBounds(maximum, minimum)) collection = CreateRandomArray(lengthArray, minimum, maximum);
PrintArray(collection);
int S = GetSumOfOddPositions(collection);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях, равна {S}.");

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

int GetBound(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

bool ValidateBounds(int max, int min)
{
    bool valid = false;
    while (valid == false)
    {
        if (max < min)
        {
            Console.WriteLine("Ошибка. Минимум не должен быть больше максимума.");
            maximum = GetBound("Задайте максимальное значение элемента массива:");
            max = maximum;
            minimum = GetBound("Задайте минимальное значение элемента массива:");
            min = minimum;
        }
        else valid = true;
    }
    return valid;
}

int[] CreateRandomArray(int L, int min, int max)
{
    int[] array = new int[L];
    Random r = new Random();
    for (int i = 0; i < L; i++)
    {
        array[i] = r.Next(min, max + 1);
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
