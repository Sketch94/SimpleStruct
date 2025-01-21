public struct MyStruct
{
    public int X { get; }
    public int Y { get; }

    public MyStruct(int x, int y)
    {
        X = x;
        Y = y;
    }

    public MyStruct WithX(int x) => new MyStruct(x, Y);
    public MyStruct WithY(int y) => new MyStruct(X, y);

    public override string ToString() => $"({X}, {Y})";

}

public class Program
{
    public static void Main()
    {
        var s = new MyStruct(1, 2);
        Console.WriteLine(s);
        Console.WriteLine(s.WithX(3));
        Console.WriteLine(s.WithY(4));
    }
}

