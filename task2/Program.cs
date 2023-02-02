// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int sum(int[] array)
{
    int count = 0;
    int res = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        
        res = res + array[i];
        count++;
        
    }
    return res;
}

int[] array = GetArray(8, 0, 99);
Console.Write($"[{String.Join(" ", array)}]");
int res =sum(array);
Console.WriteLine($" --> {res}");