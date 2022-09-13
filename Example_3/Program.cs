// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число, от 1 до которого вам необходимо рассчитать кубы");
int numberN = Convert.ToInt32(Console.ReadLine());
CubNumber(numberN);

void CubNumber(int numberN)
{
    int index = 1;
    while (index <= numberN)
    {
        Console.WriteLine($"{index}^3 = {Math.Pow(index, 3)}.");
        index++;
    }
}
