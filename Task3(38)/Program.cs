// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] GetFilledArrayDouble(int size)
{
    double[] ArrayForFill = new double[size];
    Random TempRandom = new Random();

    for (int i = 0; i < size; i++)
    {                      // рандомный double от 0 до 1 возводим в рандомную степень от 10
        ArrayForFill[i] = TempRandom.NextDouble() * Math.Pow(10, TempRandom.Next(3, 10));
        ArrayForFill[i] = TempRandom.Next(1, 6) % 2 == 0 ? -ArrayForFill[i] : ArrayForFill[i]; // рандом для задания минуса
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
    double[] OurArray = GetFilledArrayDouble(randomSize);
    System.Console.WriteLine($"Сгенерирован массив из {randomSize} значений:\n");

    for (int i = 0; i < randomSize; i++)
    {
        System.Console.Write(" {0,20:F8} ", OurArray[i]);
        System.Console.WriteLine();
    }

    // int[] ResultArray = SummInNotByTwoIndex(OurArray);
    // System.Console.WriteLine($" Сумма значений на нечётных ({ResultArray[0]} шт) позициях равна {ResultArray[1]} ");
}

main();
