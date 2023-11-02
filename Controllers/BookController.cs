namespace MVC.Controllers
{
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
            Book model = new Book();
            BookSingleView view = new BookSingleView(model);
            view.Render();
        }
    }
}