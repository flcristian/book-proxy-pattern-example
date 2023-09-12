using book_proxy_pattern_example;

internal class Program
{
    private static void Main(string[] args)
    {
        IBook book = new BookProxy();

        Console.WriteLine(book);
        book.ChangeTitle("Romeo si Julieta");
        book.ChangeAuthor("Shakespeare");
        book.ChangeCoverColor("Red");
        book.AddPages(120);
        Console.WriteLine(book);
    }
}