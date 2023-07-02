/*Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("Введите X первой точки:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y первой точки:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z первой точки:");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите X второй точки:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y второй точки:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z второй точки:");
int z2 = Convert.ToInt32(Console.ReadLine());

double i1 = Math.Pow((x1 - x2), 2);
double i2 = Math.Pow((y1 - y2), 2);
double i3 = Math.Pow((z1 - z2), 2);
double nice = i1 + i2 + i3;
double result = Math.Sqrt(nice);

double okay = Math.Round((result), 2); // округление до 2 чисел после запятой
Console.WriteLine($"Ответ: {okay}");

