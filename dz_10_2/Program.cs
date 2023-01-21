//Задача 10: Напишите программу, которая принимает 
//на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
string num_string = num.ToString();
if (num > 99 && num < 1000) System.Console.WriteLine(num_string[1]);
else System.Console.WriteLine("Введено не верное число.");
