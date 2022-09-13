// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число для проверки на палиндром ");
string number = Console.ReadLine();
Console.WriteLine(CheckPalindrome(number));

string CheckPalindrome(string str)
{
    if (str.Length == 5)
    {
        if (str[0] == str[4] && str[1] == str[3])
            return "Это палиндром";
        else
            return "Это не палиндром";
    }
    return "Введеное число не пятизначное";
}