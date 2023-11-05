namespace MVC.Controllers
{
    using BookMan.ConsoleApp.Views;
    using Models;
    using Views;
    /// <summary>
    /// lớp điều khiển, giúp ghép nối dữ liệu sách với giao diện
    /// </summary>
    public class BookController
    {
        /// <summary>
        /// ghép nối dữ liệu 1 cuốn sách với giao diện hiển thị 1 cuốn sách
        /// </summary>
        /// <param name="id"></param>
        public void Single(int id)
        {
            Book model = new Book
            {
                Id = 1,
                Authors = "Adam Freeman",
                Title = "Expert ASP.NET Web API 2 for MVC Dev",
                Publisher = "Apress",
                Year = 2014,
                Tags = "C#,ASP.NET,MVC",
                Description = "Expert insight and understanding of how to create, customize, and deploy comlox, flexible, and robust HTTP web services",
                Rating = 4,
                Reading = true
            };

            BookSingleView view = new BookSingleView(model);
            view.Render();
        }
        public void Create()
        {
            BookCreateView view = new BookCreateView();
            view.Render();
        }
        public void Update(int id)
        {
            var model = new Book();
            var view = new BookUpdateView(model);
            view.Render();
        }
        public void List()
        {
            Book[] model = new Book[] {
                new Book{Id = 1, Title = "A new book 1"},
                new Book{Id = 2, Title = "A new book 2"},
                new Book{Id = 3, Title = "A new book 3"},
                new Book{Id = 4, Title = "A new book 4"},
                new Book{Id = 5, Title = "A new book 5"},
                new Book{Id = 6, Title = "A new book 6"},
            };
            BookListView view = new BookListView(model);
            view.Render();
        }
    }
}