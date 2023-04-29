class Program
{
    public static void Main()
    {
        NumberRad numberRad = new NumberRad();
        numberRad.NumberReadEvent += ShowNumber;

        while (true) 
        {
            try
            {
                numberRad.Read();
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено некорректное значение");
            }
        }
        
        static void ShowNumber(int number)
        {
            switch (number)
            {
                case 1: Plus(); break;
                case 2: Minus(); break;
            }
        }
        static void Plus()
        {
            string[] words = { "Аня", "Лера", "Петя", "Катя", "Вася" };

            IEnumerable<string> query = from word in words
                                        orderby word.Substring(0, 1)
                                        select word;

            foreach (string str in query)
                Console.WriteLine(str);
        }
        static void Minus()
        {
            string[] words = { "Аня", "Лера", "Петя", "Катя", "Вася" };

            IEnumerable<string> query = from word in words
                                        orderby word.Substring(0, 1) descending
                                        select word;

            foreach (string str in query)
                Console.WriteLine(str);
        }
    }
}

class NumberRad
{
    public delegate void NumberRadDelegate(int number);
    public event NumberRadDelegate NumberReadEvent;

    public void Read()
    {
        Console.WriteLine("Число 1 (А-Я), число 2 (Я-А)");

        int number = Convert.ToInt32(Console.ReadLine());

        if (number != 1 && number != 2) throw new FormatException();

        NumberEntered(number);
    }
     protected virtual void NumberEntered(int number)
    {
        NumberReadEvent?.Invoke(number);
    }
}