class Program
{
    static void Main(string[] args)
    {
        Exception exception = new Exception("Собственное исключение");
        exception.Data.Add("Время исключения: ", DateTime.Now);
        exception.HelpLink = "www.Google.com";
        try
        {
            Console.WriteLine("ЛоЛКеК");
            throw new ArgumentOutOfRangeException("Сообщение об ошибке");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Конец программы");
        }
        Console.ReadKey();

        try
        {
            Console.WriteLine("ЛоЛКеК");
            throw new RankException("Сообщение об ошибке");
        }
        catch (RankException ex)
        {
            Console.WriteLine(ex.GetType);
        }
        finally
        {
            Console.WriteLine("Конец программы");
        }
        Console.ReadKey();
    }
}