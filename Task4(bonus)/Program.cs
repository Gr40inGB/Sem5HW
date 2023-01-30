
// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. 
// Реализовать невозрастающую сортировку.

// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]

int[] GetFilledArray(int size, int minValue, int maxValue)
{
    int[] ArrayForFill = new int[size];
    for (int i = 0; i < size; i++)
    {
        ArrayForFill[i] = new Random().Next(minValue, maxValue + 1);
    }
    return ArrayForFill;
}

void SortedArray(int[] ArrayForSort)
{
    for (int i = 0; i < ArrayForSort.Length; i++)
    {
        for (int j = 0; j < ArrayForSort.Length - 1; j++)
        {
            if (ArrayForSort[j] < ArrayForSort[j + 1])
            {
                int tempValue = ArrayForSort[j];
                ArrayForSort[j] = ArrayForSort[j + 1];
                ArrayForSort[j + 1] = tempValue;
            }
        }
    }
}

void main()
{
    Console.Clear();
    int randomSize = new Random().Next(6, 30);
    int[] OurArray = GetFilledArray(randomSize, 1, 20);
    System.Console.WriteLine($"Был сгенерирован массив из {randomSize} значений:\n{String.Join(" ", OurArray)}\n");
    SortedArray(OurArray);
    System.Console.WriteLine($"Массив был отсортирован  как невозрастающий: \n{String.Join(" ", OurArray)}");
}

main();

