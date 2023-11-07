namespace Interface_Segregation_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            IBorrowableBook book = new Book();
            IBook book2 = new Book();

            book.CheckOut("Peter");
            Console.WriteLine(book.GetDueDate());

            // Book2 is not borrowable, cant be checked out...
            //book2.CheckOut("Peter");
        }
    }
}