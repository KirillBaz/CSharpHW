/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */
Console.WriteLine("Введите координаты первой точки ");
double[] crd1 = {double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())};
Console.WriteLine("Введите координаты второй точки ");
double[] crd2 = {double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())};
double distance = Math.Sqrt((crd2[0]-crd1[0])*(crd2[0]-crd1[0])+(crd2[1]-crd1[1])*(crd2[1]-crd1[1])+(crd2[2]-crd1[2])*(crd2[2]-crd1[2]));
Console.WriteLine(distance);
