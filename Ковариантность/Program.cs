using System.Security.Cryptography.X509Certificates;

class Program
{
    public delegate Car car();
    public delegate Parent par();
    delegate void  ChildI (Child child);
    public static Car cars()
    {
        return null;
    }
    public static Lexus LXs()
    {
        return null;
    }
    public static Parent pars()
    {
        return null;
    }
    public static Child Chs()
    {
        return null;
    }
    static void Main(string[] args)
    {
        car car = cars;
        car car1 = LXs;

        ChildI child = GPI;
        child.Invoke(new Child());
        
        Console.Read();
    }
    public static void GPI(Parent p)
    {
        Console.WriteLine(p.GetType());
    }
}
class Car { }
class Lexus : Car { }
class Parent { }
class Child : Parent { }