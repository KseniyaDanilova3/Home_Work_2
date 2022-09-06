// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6

Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberA = Convert.ToString(number);
if (numberA.Length > 2)
{
    Console.WriteLine($"третья цифра числа:  {numberA[2]}");
}
else
{
    Console.WriteLine("третьей цифры нет");
}