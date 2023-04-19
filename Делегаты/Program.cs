using System.Reflection.Metadata.Ecma335;

class Program
{
    public delegate void Minus(int a, int b);
    delegate void ShowMessageDelegate(string _message);
    delegate int RandomNumberDelegate();
    static void Main(string[] args)
    {
        Func<int, int, int, int> sumDelegate = Sum;
        int result = sumDelegate.Invoke(1, 30, 120);
        Console.WriteLine(result);

        Predicate <string> checkLengthDelegate = CheckLength;
        bool status = checkLengthDelegate.Invoke("skill_factory");
        Console.WriteLine(status);

        ShowMessageDelegate sh = (string _message) =>
        {
            Console.WriteLine(_message);
        };
        sh.Invoke("Hello World!");
        Console.Read();

        RandomNumberDelegate randomNumberDelegate = () =>
        {
            return new Random().Next(0, 100);
        };
        int resul = randomNumberDelegate.Invoke();
        Console.WriteLine(resul);
        Console.Read();
    }

    static void Minusus(int a, int b)
    {
        int c = b - a;
        Console.WriteLine(c);
    }
    static void Plus(int a, int b)
    {
        int c = b + a;
        Console.WriteLine(c);
    }
    static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }
    static bool CheckLength(string _row)
    {
        if (_row.Length > 3) return true;
        return false;
    }
}