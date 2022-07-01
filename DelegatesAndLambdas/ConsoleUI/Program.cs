
class Program
{
    delegate int MathOp(int x, int y);

    delegate T Combine<T>(T a, T b);

    static void Main(string[] args)
    {
        MathOp f = Add;
        f = Sub;

        Console.WriteLine(f(84, 42));

        CalculateAndPrint(21, 21, Add);

        CalculateAndPrint(22, 22, (x, y) => x * y);
        CalculateAndPrint(22, 22, (x, y) => x + y);
        CalculateAndPrint(22, 22, (x, y) => x - y);

        CalculateAndPrint("A", "B", (x, y) => x + y);
        CalculateAndPrint(true, true, (x, y) => x && y);
    }

    static void CalculateAndPrint<T>(T x, T y, Combine<T> f)
    {
        var result = f(x, y);
        Console.WriteLine(result);
    }

    static int Add(int x, int y)
    {
        return x + y;
    }

    static int Sub(int a, int b)
    {
        return a - b;
    }
}
