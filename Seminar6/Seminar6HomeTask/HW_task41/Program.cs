// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

int GetNaturalCount(int numbers)
{
    int naturals = 0, counter = 0;
    while (counter < numbers)
    {
        Console.Write($"Enter the {counter + 1} number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) naturals++;
        counter++;
    }
    return naturals;
}

Console.Write("Enter count of numbers: ");
int numCount = Convert.ToInt32(Console.ReadLine());
int natural = GetNaturalCount(numCount);
Console.WriteLine($"There's {natural} natural numbers");