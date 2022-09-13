// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int[] numberA = new int[3];
int[] numberB = new int[3];
Console.WriteLine("Введите координаты первой точки");
Console.Write("x = ");
numberA[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
numberA[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("z = ");
numberA[2] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("x = ");
numberB[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
numberB[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("z = ");
numberB[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Длина отрезка в 3D пространстве " + SegmentLength(numberA, numberB));
double SegmentLength(int[] arrayA, int[] arrayB)
{
    double length = Math.Sqrt(Math.Pow(arrayB[0] - arrayA[0], 2) + Math.Pow(arrayB[1] - arrayA[1], 2) + Math.Pow(arrayB[2] - arrayA[2], 2));
    return length;
}
