//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int[] ReturnEnteredArray()
{
    int size = 8;
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter the {i + 1} element of the array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

void ShowArray(int[] array)
{
    foreach (int element in array)
        Console.Write($"{element} ");

    Console.WriteLine("Done");
}

int[] myArray = ReturnEnteredArray();
ShowArray(myArray);