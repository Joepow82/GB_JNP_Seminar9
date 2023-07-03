//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.Write("Entre any whole number: ");
int usernumber = int.Parse(Console.ReadLine());

string usernumberStr = Math.Abs(usernumber).ToString();
if (usernumberStr.Length < 3)
{
    Console.Write("Your number has no third digit");
}
else
{
    Console.WriteLine($"Third digit: {usernumberStr [2]}");
}