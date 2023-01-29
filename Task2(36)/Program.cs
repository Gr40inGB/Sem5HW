// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] GetFilledArray(int size, int minValue, int maxValue)
{
    int[] ArrayForFill = new int[size];
    for (int i = 0; i < size; i++)
    {
        ArrayForFill[i] = new Random().Next(minValue, maxValue + 1);
    }
    return ArrayForFill;
}

int[] SummInNotByTwoIndex(int[] ArrayForCheck)
{
    int countIndex = 0;
    int summ = 0;
    for (int j = 1; j < ArrayForCheck.Length; j += 2)
    {
        countIndex++;
        summ += ArrayForCheck[j];
    }
    return new[] { countIndex, summ };
}

void main()
{
    Console.Clear();
    int randomSize = new Random().Next(6, 30);
    int[] OurArray = GetFilledArray(randomSize, -100, 100);
    System.Console.WriteLine($"Сгенерирован массив из {randomSize} значений:\n{String.Join(" ", OurArray)}");
    int[] ResultArray = SummInNotByTwoIndex(OurArray);
    System.Console.WriteLine($" Сумма значений на нечётных ({ResultArray[0]} шт) позициях равна {ResultArray[1]} ");
}

main();
