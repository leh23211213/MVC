namespace MVC.DataServices
{
    using Models;
    public class SimpleDataAccess : IDataAccess
    {
        public List<Book> Books { get; set; }
        public void Load()
        {
            Books = new List<Book>
            {
                new Book{Id = 1, Title = "A new book 1"},
                new Book{Id = 2, Title = "A new book 2"},
                new Book{Id = 3, Title = "A new book 3"},
            };
        }
        public void SaveChanges() { }
    }
}