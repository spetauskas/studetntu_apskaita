namespace studetntu_apskaita
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IMenuService menu = new Menu();
            menu.Menudisplay();
            





            Console.WriteLine("Hello, World!");

            using var context = new UniversityContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            //var adventure = new Category { Name = "Adventure" };
            //context.Categories.Add(adventure);
            //context.SaveChanges();

            //var hoobit = new Book { Name = "Hoobit", Year = 1937 };
            //context.Books.Add(hoobit);
            //context.SaveChanges();

            //var bookCategory = new BookCategory { Book = hoobit, Category = adventure };
            //context.BookCategories.Add(bookCategory);
            //context.SaveChanges();
        }
    }
}
