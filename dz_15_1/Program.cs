// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("Введите число дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 0 && num < 6) System.Console.WriteLine("Нет");
else if(num == 6 || num == 7) System.Console.WriteLine("Да");
else System.Console.WriteLine("Введено не верное число");
