using System;
class Utils
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}
class Program
{
    static void Main()
    {
        int num1 = 5, num2 = 10;
        Console.WriteLine($"До Swap: {num1}, {num2}");
        Utils.Swap(ref num1, ref num2);
        Console.WriteLine($"Числа после Swap: {num1}, {num2}");
        string str1 = "Hello", str2 = "World";
        Console.WriteLine($"До Swap: {str1}, {str2}");
        Utils.Swap(ref str1, ref str2);
        Console.WriteLine($"Строки после Swap: {str1}, {str2}");
    }
}
