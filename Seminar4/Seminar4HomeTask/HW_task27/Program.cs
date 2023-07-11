//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumDigits(int number)
{
    int result = 0;
    int numberCopy = number;

    while (numberCopy != 0)
    {
        result += numberCopy % 10;
        numberCopy /= 10;
    }

    return result;
}

Console.Write("Enter a number: ");
int myNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of digits in {myNumber} equals {SumDigits(myNumber)}");