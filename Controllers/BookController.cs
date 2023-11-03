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
            Book model = new Book {
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
        public void Create(){
            BookCreateView view = new BookCreateView();
            view.Render();
        }
    }
}