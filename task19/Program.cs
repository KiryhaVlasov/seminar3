// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
Console.Clear();
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
string num = Convert.ToString(number);

if (num[0] == num[4] & num[1] == num[3])
{
    Console.WriteLine("Это палиндром");
}
else
{
    Console.WriteLine("Это не палиндром");
}
