//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int aX, aY, aZ;
int bX, bY, bZ;

Console.WriteLine("Введите посследовательность координат: ");
Console.Write("aX: ");
aX = Convert.ToInt32(Console.ReadLine());
Console.Write("aY: ");
aY = Convert.ToInt32(Console.ReadLine());
Console.Write("aZ: ");
aZ = Convert.ToInt32(Console.ReadLine());

Console.Write("bX: ");
bX = Convert.ToInt32(Console.ReadLine());
Console.Write("bY: ");
bY = Convert.ToInt32(Console.ReadLine());
Console.Write("bZ: ");
bZ = Convert.ToInt32(Console.ReadLine());

double dist = Math.Pow(bX - aX, 2) + Math.Pow(bY - aY, 2) + Math.Pow(bZ - aZ, 2);
dist = Math.Sqrt(dist);
dist = Math.Round(dist, 2);


Console.WriteLine(dist);

