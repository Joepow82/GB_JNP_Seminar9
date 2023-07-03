//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8 
//918 -> 1
int ReturnSecondDigit(int number)
{
    // return number / 10 % 10;
    int lastTwoDigits = number / 10;
    int secondDigit = lastTwoDigits % 10;
    return secondDigit;
}

Console.Write("Enter three-digit number: ");
int input = Convert.ToInt32(Console.ReadLine());
int result = ReturnSecondDigit(input);

Console.WriteLine($"Second digit of {input} is {result}");
