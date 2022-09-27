// // Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
var array = new int[8];
for (int i =0; i<8; i++)
array [i] = new Random().Next(int.MinValue, int.MaxValue);
foreach (var e in array) Console.WriteLine(e);
