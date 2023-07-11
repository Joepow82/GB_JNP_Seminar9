//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

int PowerNumber(int number, int power)
{
    int result = number;

    for (int pow = 1; pow < power; pow++)
        result *= number;

    return result;
}
Console.Write("Enter a number and power with comma and space (like \"a, b\"): ");
string[] input = Console.ReadLine().Split(", ");
int num = Convert.ToInt32(input[0]);
int pow = Convert.ToInt32(input[1]);
Console.WriteLine($"{num}^{pow} equals {PowerNumber(num, pow)}");