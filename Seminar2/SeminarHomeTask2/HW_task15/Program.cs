//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да 
//7 -> да 
//1 -> нет

bool IsWeekend(int weekday)
{
    // with weekday larger than week
    // return weekday % 7 == 0 || weekday % 7 == 6;
    // only with one week
    return weekday > 5 && weekday < 8;
}

Console.Write("Enter a day number: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

bool isWeekend = IsWeekend(dayNumber);

Console.WriteLine(isWeekend ? $"Day {dayNumber} is weekend" : $"Day {dayNumber} is not weekend");