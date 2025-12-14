using System;
public class Box<T>
{
    private T item;
    public void Put(T item)
    {
        this.item = item;
    }
    public T Get()
    {
        return item;
    }
}
class Program
{
    static void Main()
    {
        Box<int> intBox = new Box<int>();
        intBox.Put(42);
        Console.WriteLine($"Число в коробке: {intBox.Get()}");
        Box<string> stringBox = new Box<string>();
        stringBox.Put("Hello");
        Console.WriteLine($"Строка в коробке: {stringBox.Get()}");
    }
}
