using System;
public class Pair<T1, T2>
{
    public T1 First { get; set; }
    public T2 Second { get; set; }
    public Pair(T1 first, T2 second)
    {
        First = first;
        Second = second;
    }
}
class Program
{
    static void Main()
    {
        Pair<int, string> pair = new Pair<int, string>(5, "Hello");
        Console.WriteLine($"Первое значение: {pair.First}, Второе значение: {pair.Second}");
    }
}
