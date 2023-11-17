namespace MVC.Controllers
{
    using DataServices;
    using Framework;
    using Views;
    public class BookController : ControllerBase
    {
        protected Repository Repository;
        public BookController(SimpleDataAccess context)
        {
            Repository = new Repository(context);
        }
        public void Single(int id, string path = "")
        {
            var model = Repository.Select(id);
            Render(new BookSingleView(model), path);
        }
        public void Create()
        {
            Render(new BookCreateView());
        }
        public void Update(int id)
        {
            var model = Repository.Select(id);
            Render(new BookUpdateView(model));
        }
        public void List(string path = "")
        {
            var model = Repository.Select();
            Render(new BookListView(model), path);
        }
    }
}