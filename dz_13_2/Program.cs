// Задача 13: Напишите программу, которая выводит третью цифру 
//  числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string num_string = num.ToString();
if (num > 99) System.Console.WriteLine(num_string[2]);
else System.Console.WriteLine("Третьей цифры нет");