// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GetFilledArray(int size, int minValue, int maxValue)
{
    int[] ArrayForFill = new int[size];
    for (int i = 0; i < size; i++)
    {
        ArrayForFill[i] = new Random().Next(minValue, maxValue + 1);
    }
    return ArrayForFill;
}

int CheckByTwo(int[] ArrayForCheck)
{
    int countByTwo = 0;
    for (int j = 0; j < ArrayForCheck.Length; j++)
    {
        if (ArrayForCheck[j] % 2 == 0)
        {
            countByTwo++;
        }
    }
    return countByTwo;
}

void main()
{
    int randomSize = new Random().Next(6, 30);
    int[] OurArray = GetFilledArray(randomSize, 100, 999);
    System.Console.WriteLine($"Сгенерирован массив из {randomSize} значений:\n{String.Join(" ", OurArray)}");
    System.Console.WriteLine($" Чётных значений в массиве {CheckByTwo(OurArray)} шт");
}

main();

