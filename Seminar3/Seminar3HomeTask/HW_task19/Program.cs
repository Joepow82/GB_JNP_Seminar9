// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

bool CheckPalindrome(int number)
{
    int reversed = 0;
    int temp = number;
    while (reversed < number)
    {
        reversed = reversed * 10 + temp % 10;
        temp /= 10;
    }
    if (reversed == number) return true;
    else return false;
}

Console.Write("Enter a natural number: ");
int naturalNumber = Convert.ToInt32(Console.ReadLine());

bool result = CheckPalindrome(naturalNumber);

Console.WriteLine($"Is number {naturalNumber} a palindrome? -> {result}");
