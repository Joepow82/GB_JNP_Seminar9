// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

void WriteCubes(int limit)
{
    int counter = 1;
    while (counter <= limit)
    {
        Console.Write($"{Convert.ToInt32(Math.Pow(counter, 3))} ");
        counter++;
    }
}

Console.Write("Enter a natural number: ");
int naturalNumber = Convert.ToInt32(Console.ReadLine());
WriteCubes(naturalNumber);