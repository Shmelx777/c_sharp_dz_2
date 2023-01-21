// Задача 13: Напишите программу, которая выводит третью цифру 
//  числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99)
{
    while (num > 999)
    {
        num = num / 10;
    }
    System.Console.WriteLine(num%10);
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}