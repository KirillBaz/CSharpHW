/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */
int[] number = new int[5];
Console.WriteLine("Введите пятизначное число по цифрам");
for( int i = 0; i<number.Length; i++) number[i]=Convert.ToInt32(Console.ReadLine());
if (number[0]==number[4] && number[1]==number[3]) Console.WriteLine("Да");
else Console.WriteLine("Нет");
