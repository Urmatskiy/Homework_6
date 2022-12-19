// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateMassive(int len, int start, int end)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

int CountPositiveNumber(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) counter++;
    }
    return counter;
}

Console.Write("Введите длинну массива: ");
int size = int.Parse(Console.ReadLine());
Console.Write("Введите нижнюю границу чисел массива: ");
int firstPos = int.Parse(Console.ReadLine());
Console.Write("Введите верхнюю границу чисел массива: ");
int lastPos = int.Parse(Console.ReadLine());

int[] array = CreateMassive(size, firstPos, lastPos);
int result = CountPositiveNumber(array);

Console.WriteLine($"[{string.Join(", ", array)}] -> {result}");