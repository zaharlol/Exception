using System;

class Program
{
    static void Main(string[] args)
    {
        Exc exce = new Exc();
        string[] exc = { "IndexOutOfRangeException", "InvalidOperationException ","KeyNotFoundException", "otImplementedException"};
        var exc1 = exc[0]; 

        try
        {
            for (int i = 0; i < 4; i++)
            {
                new Exception{};
                Person person = new Person { Name = "Tom", Age = 17 };
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}

class Person
{
    private int age;
    public string Name { get; set; } = "";
    public int Age
    {
        get => age;
        set
        {
            if (value < 18)
                throw new Exception("Лицам до 18 регистрация запрещена");
            else
                age = value;
        }
    }
}

enum Exc
{
    IndexOutOfRangeException, 
    InvalidOperationException,  
    KeyNotFoundException,
    otImplementedException
}